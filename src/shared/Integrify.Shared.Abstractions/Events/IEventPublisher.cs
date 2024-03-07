namespace Integrify.Shared.Abstractions.Events;

/// <summary>
/// Interface for publishing events
/// </summary>
public interface IEventPublisher
{
    /// <summary>
    /// Publishing specified event
    /// </summary>
    /// <param name="event">Publishing event</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default) where TEvent : class, IEvent;
}