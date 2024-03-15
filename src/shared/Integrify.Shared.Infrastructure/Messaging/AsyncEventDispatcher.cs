using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Shared.Infrastructure.Messaging;

public class AsyncEventPublisher : IAsyncEventPublisher
{
    public Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default) where TEvent : class, IEvent
    {
        throw new NotImplementedException();
    }
}