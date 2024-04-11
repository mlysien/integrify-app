using Integrify.Modules.Orders.Core.Events;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Dispatchers;
using Integrify.Shared.Abstractions.Messaging;
using Integrify.Shared.Abstractions.Plugins;
using Integrify.Shared.Abstractions.Time;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Orders.Core.Commands.Handlers;

internal sealed class OrdersSynchronizationHandler(
    ILogger<OrdersSynchronizationHandler> logger,
    IClock clock,
    IDispatcher dispatcher)
    : ICommandHandler<OrdersSynchronization>
{
    public async Task HandleAsync(OrdersSynchronization command, CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Order synchronization started");

        await dispatcher.SendAsync(new GetOrders(), cancellationToken);
    }
}