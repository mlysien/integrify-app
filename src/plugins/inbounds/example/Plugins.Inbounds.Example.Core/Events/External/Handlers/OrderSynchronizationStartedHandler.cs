using Integrify.Shared.Abstractions.Events;
using Microsoft.Extensions.Logging;

namespace Plugins.Inbounds.Example.Core.Events.External.Handlers;

internal class OrderSynchronizationStartedHandler(
    ILogger<OrderSynchronizationStartedHandler> logger
    ) : IEventHandler<OrderSynchronizationStarted>
{
    public async Task HandleAsync(OrderSynchronizationStarted @event, CancellationToken cancellationToken = default)
    {
        
        logger.LogInformation("Welcome in inbound plugin");
    }
}