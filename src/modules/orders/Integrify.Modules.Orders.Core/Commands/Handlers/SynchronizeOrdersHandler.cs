using Integrify.Modules.Orders.Core.Events;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Dispatchers;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Orders.Core.Commands.Handlers;

internal sealed class SynchronizeOrdersHandler(
    ILogger<SynchronizeOrdersHandler> logger,
    IMessageBroker messageBroker)
    : ICommandHandler<SynchronizeOrders>
{
    public async Task HandleAsync(SynchronizeOrders command, CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Orders synchronization started");
        
        await messageBroker.PublishAsync(new OrdersSynchronizationRequested(), cancellationToken);
    }
}