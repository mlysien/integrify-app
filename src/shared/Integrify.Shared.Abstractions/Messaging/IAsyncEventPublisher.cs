using Integrify.Shared.Abstractions.Events;

namespace Integrify.Shared.Abstractions.Messaging;

public interface IAsyncEventPublisher
{
    Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default)
        where TEvent : class, IEvent;
}