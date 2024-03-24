using System.Collections.Concurrent;
using System.Reflection;
using Inflow.Shared.Infrastructure.Messaging.Contexts;
using Inflow.Shared.Infrastructure.Modules;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Messaging;
using Integrify.Shared.Abstractions.Modules;

namespace Integrify.Shared.Infrastructure.Modules;

internal sealed class ModuleClient(
    IModuleRegistry moduleRegistry,
    IModuleSerializer moduleSerializer,
    IMessageContextRegistry messageContextRegistry,
    IMessageContextProvider messageContextProvider)
    : IModuleClient
{
    private readonly ConcurrentDictionary<Type, MessageAttribute> _messages = new();

    public Task SendAsync(string path, object request, CancellationToken cancellationToken = default)
        => SendAsync<object>(path, request, cancellationToken);

    public async Task<TResult> SendAsync<TResult>(string path, object request,
        CancellationToken cancellationToken = default) where TResult : class
    {
        var registration = moduleRegistry.GetRequestRegistration(path);
        if (registration is null)
        {
            throw new InvalidOperationException($"No action has been defined for path: '{path}'.");
        }

        var receiverRequest = TranslateType(request, registration.RequestType);
        var result = await registration.Action(receiverRequest, cancellationToken);

        return TranslateType<TResult>(result);
    }

    public async Task PublishAsync(object message, CancellationToken cancellationToken = default)
    {
        var module = message.GetModuleName();
        var key = message.GetType().Name;
        var registrations = moduleRegistry
            .GetBroadcastRegistrations(key)
            .Where(r => r.ReceiverType != message.GetType());

        var tasks = new List<Task>();

        foreach (var registration in registrations)
        {
            if (!_messages.TryGetValue(registration.ReceiverType, out var messageAttribute))
            {
                messageAttribute = registration.ReceiverType.GetCustomAttribute<MessageAttribute>();
                if (message is ICommand)
                {
                    messageAttribute = message.GetType().GetCustomAttribute<MessageAttribute>();
                    module = registration.ReceiverType.GetModuleName();
                }

                if (messageAttribute is not null)
                {
                    _messages.TryAdd(registration.ReceiverType, messageAttribute);
                }
            }

            if (messageAttribute is not null && !string.IsNullOrWhiteSpace(messageAttribute.Module) &&
                (!messageAttribute.Enabled || messageAttribute.Module != module))
            {
                continue;
            }

            var action = registration.Action;
            var receiverMessage = TranslateType(message, registration.ReceiverType);
            if (message is IMessage messageData)
            {
                var messageContext = messageContextProvider.Get(messageData);
                messageContextRegistry.Set((IMessage)receiverMessage, messageContext);
            }

            tasks.Add(action(receiverMessage, cancellationToken));
        }

        await Task.WhenAll(tasks);
    }

    private T TranslateType<T>(object value)
        => moduleSerializer.Deserialize<T>(moduleSerializer.Serialize(value));

    private object TranslateType(object value, Type type)
        => moduleSerializer.Deserialize(moduleSerializer.Serialize(value), type);
}