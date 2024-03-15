using Humanizer;
using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Logging;

namespace Integrify.Shared.Infrastructure.Messaging;

internal sealed class DefaultMessageBroker(
    IEventPublisher eventPublisher,
    ILogger<DefaultMessageBroker> logger
) : IMessageBroker
{
    public async Task PublishAsync(IEvent @event, CancellationToken cancellationToken = default)
    {
        var name = @event.GetType().Name.Underscore();
        logger.LogInformation($"Publishing an event: {name}...");
        await eventPublisher.PublishAsync(@event, cancellationToken);
    }
}