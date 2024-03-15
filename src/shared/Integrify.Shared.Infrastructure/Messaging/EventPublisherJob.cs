using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Integrify.Shared.Infrastructure.Messaging;

internal sealed class EventPublisherJob(
    IEventChannel eventChannel,
    IEventPublisher eventPublisher,
    ILogger<EventPublisherJob> logger)
    : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await foreach (var @event in eventChannel.Reader.ReadAllAsync(stoppingToken))
        {
            try
            {
                await eventPublisher.PublishAsync(@event, stoppingToken);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, exception.Message);
            }
        }
    }
}