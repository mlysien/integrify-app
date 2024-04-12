using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Plugins;
using Microsoft.Extensions.Logging;
using Plugins.Inbounds.Example.Api.Contracts.Orders;

namespace Integrify.Modules.Orders.Core.Commands.Handlers;

internal class GetOrdersHandler(
    ILogger<GetOrdersHandler> logger,
    IInboundPlugin inboundPlugin) :  ICommandHandler<GetOrders>
{
    public async Task HandleAsync(GetOrders command, CancellationToken cancellationToken = default)
    {
        var orders = await inboundPlugin.GetOrdersAsync<ExampleOrderContract>();
        
        logger.LogInformation($"Fetched {orders.Count()} orders");
    }
}