using Integrify.Modules.Customers.Core.Events;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Customers.Core.Commands.Handlers;

internal class SynchronizeCustomersHandler(
    ILogger<SynchronizeCustomersHandler> logger,
    IMessageBroker messageBroker) : ICommandHandler<SynchronizeCustomers>
{
    public async Task HandleAsync(SynchronizeCustomers command, CancellationToken cancellationToken = default)
    { 
        logger.LogInformation("Customers synchronization started");
        
        await messageBroker.PublishAsync(new CustomersSynchronizationRequested(), cancellationToken);
    }
}