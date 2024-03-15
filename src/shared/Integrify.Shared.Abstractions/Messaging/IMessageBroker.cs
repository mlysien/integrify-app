using Integrify.Shared.Abstractions.Events;

namespace Integrify.Shared.Abstractions.Messaging;

/// <summary>
/// Provides methods for publishing messages
/// </summary>
public interface IMessageBroker
{
    /// <summary>
    /// Publishing specified event
    /// </summary>
    /// <param name="event">Publishing event</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task PublishAsync(IEvent @event, CancellationToken cancellationToken = default);
}