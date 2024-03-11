namespace Integrify.Shared.Abstractions.Messaging;

/// <summary>
/// Provides methods for publishing messages
/// </summary>
public interface IMessageBroker
{
    /// <summary>
    /// Publishing specified message
    /// </summary>
    /// <param name="message">Publishing message</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task PublishAsync(IMessage message, CancellationToken cancellationToken = default);
}