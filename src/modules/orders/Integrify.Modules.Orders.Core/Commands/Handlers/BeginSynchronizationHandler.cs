using Integrify.Shared.Abstractions.Commands;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Orders.Core.Commands.Handlers;

internal sealed class OrdersSynchronizationHandler(ILogger<OrdersSynchronizationHandler> logger)
    : ICommandHandler<OrdersSynchronization>
{
    public Task HandleAsync(OrdersSynchronization command, CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Order synchronization started");
        
        return Task.CompletedTask;
    }
}