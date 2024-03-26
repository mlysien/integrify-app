using Inflow.Shared.Infrastructure.Messaging.Dispatchers;
using Integrify.Shared.Abstractions.Modules;
using Integrify.Shared.Infrastructure.Contexts;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Integrify.Shared.Infrastructure.Messaging.Dispatchers;

internal sealed class AsyncDispatcherJob(
    IMessageChannel messageChannel,
    IModuleClient moduleClient,
    ContextAccessor contextAccessor,
    ILogger<AsyncDispatcherJob> logger)
    : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("Running the async dispatcher.");
        await foreach (var envelope in messageChannel.Reader.ReadAllAsync(stoppingToken))
        {
            try
            {
                contextAccessor.Context ??= envelope.MessageContext.Context;
                await moduleClient.PublishAsync(envelope.Message, stoppingToken);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, exception.Message);
            }
        }

        logger.LogInformation("Finished running the async dispatcher.");
    }
}