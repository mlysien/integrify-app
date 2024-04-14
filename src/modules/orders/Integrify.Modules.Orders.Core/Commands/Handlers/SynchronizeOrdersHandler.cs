using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Dispatchers;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Orders.Core.Commands.Handlers;

internal sealed class SynchronizeOrdersHandler(
    ILogger<SynchronizeOrdersHandler> logger,
    IDispatcher dispatcher)
    : ICommandHandler<SynchronizeOrders>
{
    public async Task HandleAsync(SynchronizeOrders command, CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Order synchronization started");
        
        
    }
}