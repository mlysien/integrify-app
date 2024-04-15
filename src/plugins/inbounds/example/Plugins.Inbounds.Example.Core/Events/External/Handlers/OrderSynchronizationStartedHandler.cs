using Integrify.Shared.Abstractions.Dispatchers;
using Integrify.Shared.Abstractions.Events;
using Microsoft.Extensions.Logging;
using Plugins.Inbounds.Example.Service.Services.Abstractions;

namespace Plugins.Inbounds.Example.Core.Events.External.Handlers;

internal class OrderSynchronizationStartedHandler(
    IRestApiService restApiService,
    ILogger<OrderSynchronizationStartedHandler> logger
    ) : IEventHandler<OrderSynchronizationStarted>
{
    public async Task HandleAsync(OrderSynchronizationStarted @event, CancellationToken cancellationToken = default)
    {
        var orders = await restApiService.GetOrders();
        
        logger.LogInformation("Fetched {ordersCount} orders", orders.Count);
    }
}