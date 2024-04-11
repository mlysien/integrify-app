using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Plugins;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Orders.Core.Commands.Handlers;

internal class GetOrdersHandler(
    ILogger<GetOrdersHandler> logger,
    IInboundPlugin inboundPlugin) :  ICommandHandler<GetOrders>
{
    public async Task HandleAsync(GetOrders command, CancellationToken cancellationToken = default)
    {
        var orders = await inboundPlugin.FetchAsync();
        
        logger.LogInformation($"Fetched {orders.Count()} orders");
        
        throw new NotImplementedException();
    }
}