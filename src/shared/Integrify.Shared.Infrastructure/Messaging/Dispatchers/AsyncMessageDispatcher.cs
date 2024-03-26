using Inflow.Shared.Infrastructure.Messaging.Dispatchers;
using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Shared.Infrastructure.Messaging.Dispatchers;

internal sealed class AsyncMessageDispatcher(IMessageChannel channel, IMessageContextProvider messageContextProvider)
    : IAsyncMessageDispatcher
{
    public async Task PublishAsync<T>(T message, CancellationToken cancellationToken = default)
        where T : class, IMessage
    {
        var messageContext = messageContextProvider.Get(message);
        await channel.Writer.WriteAsync(new MessageEnvelope(message, messageContext), cancellationToken);
    }
}