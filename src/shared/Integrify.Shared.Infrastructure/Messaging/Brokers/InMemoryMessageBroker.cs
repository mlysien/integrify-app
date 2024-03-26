using Humanizer;
using Inflow.Shared.Infrastructure.Messaging.Dispatchers;
using Integrify.Shared.Abstractions.Contexts;
using Integrify.Shared.Abstractions.Messaging;
using Integrify.Shared.Abstractions.Modules;
using Integrify.Shared.Infrastructure.Messaging.Contexts;
using Integrify.Shared.Infrastructure.Messaging.Dispatchers;
using Microsoft.Extensions.Logging;

namespace Integrify.Shared.Infrastructure.Messaging.Brokers;

internal sealed class InMemoryMessageBroker(
    IModuleClient moduleClient,
    IAsyncMessageDispatcher asyncMessageDispatcher,
    IContext context,
    IMessageContextRegistry messageContextRegistry,
    MessagingOptions messagingOptions,
    ILogger<InMemoryMessageBroker> logger)
    : IMessageBroker
{
    public Task PublishAsync(IMessage message, CancellationToken cancellationToken = default)
        => PublishAsync(cancellationToken, message);

    public Task PublishAsync(IMessage[] messages, CancellationToken cancellationToken = default)
        => PublishAsync(cancellationToken, messages);
        
    private async Task PublishAsync(CancellationToken cancellationToken, params IMessage[] messages)
    {
        if (messages is null)
        {
            return;
        }

        messages = messages.Where(x => x is not null).ToArray();

        if (!messages.Any())
        {
            return;
        }

        foreach (var message in messages)
        {
            var messageContext = new MessageContext(Guid.NewGuid(), context);
            messageContextRegistry.Set(message, messageContext);
                
            var module = message.GetModuleName();
            var name = message.GetType().Name.Underscore();
            var requestId = context.RequestId;
            var traceId = context.TraceId;
            var messageId = messageContext.MessageId;
            var correlationId = messageContext.Context.CorrelationId;
                
            logger.LogInformation("Publishing a message: {Name} ({Module}) [Request ID: {RequestId}, Message ID: {MessageId}, Correlation ID: {CorrelationId}, Trace ID: '{TraceId}']...",
                name, module, requestId, messageId, correlationId, traceId);
        }
        
        var tasks = messagingOptions.UseAsyncDispatcher
            ? messages.Select(message => asyncMessageDispatcher.PublishAsync(message, cancellationToken))
            : messages.Select(message => moduleClient.PublishAsync(message, cancellationToken));

        await Task.WhenAll(tasks);
    }
}