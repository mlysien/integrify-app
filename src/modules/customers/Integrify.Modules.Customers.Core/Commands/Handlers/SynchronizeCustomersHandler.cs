using Integrify.Modules.Customers.Port;
using Integrify.Shared.Abstractions.Commands;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Customers.Core.Commands.Handlers;

internal class SynchronizeCustomersHandler(
    ILogger<SynchronizeCustomersHandler> logger,
    ICustomerSourcePort sourcePort,
    ICustomerTargetPort targetPort) : ICommandHandler<SynchronizeCustomers>
{
    public async Task HandleAsync(SynchronizeCustomers command, CancellationToken cancellationToken = default)
    { 
        logger.LogInformation("Customers synchronization started");
        
        var customersCollection = await sourcePort.GetCollectionAsync();

        foreach (var customer in customersCollection)
        {
            logger.LogInformation("Processing Customer with Id: {0}", customer.Id);
            
            await targetPort.SaveAsync(customer);
        }
    }
}