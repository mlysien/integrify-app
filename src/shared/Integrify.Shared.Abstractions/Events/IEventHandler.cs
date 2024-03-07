namespace Integrify.Shared.Abstractions.Events;

/// <summary>
/// Interface for handling events
/// </summary>
public interface IEventHandler<in TEvent> where TEvent : class, IEvent
{
    /// <summary>
    /// Handling specified event
    /// </summary>
    /// <param name="event">Handling event</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task HandleAsync(TEvent @event, CancellationToken cancellationToken = default);
}