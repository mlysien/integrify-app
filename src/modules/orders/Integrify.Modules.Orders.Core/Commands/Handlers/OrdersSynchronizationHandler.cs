using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Dispatchers;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Orders.Core.Commands.Handlers;

internal sealed class OrdersSynchronizationHandler(
    ILogger<OrdersSynchronizationHandler> logger,
    IDispatcher dispatcher)
    : ICommandHandler<OrdersSynchronization>
{
    public async Task HandleAsync(OrdersSynchronization command, CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Order synchronization started");

        await dispatcher.SendAsync(new GetOrders(), cancellationToken);
    }
}