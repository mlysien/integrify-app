using Integrify.Modules.Customers.Core.Events;
using Integrify.Modules.Customers.Port.Api;
using Integrify.Shared.Abstractions.Commands;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Customers.Core.Commands.Handlers;

internal class SynchronizeCustomersHandler(
    ILogger<SynchronizeCustomersHandler> logger,
    ICustomerSourceApi customerSourceApi,
    ICustomerTargetApi customerTargetApi) : ICommandHandler<SynchronizeCustomers>
{
    public async Task HandleAsync(SynchronizeCustomers command, CancellationToken cancellationToken = default)
    { 
        logger.LogInformation("Customers synchronization started");
        
        var customersCollection = await customerSourceApi.GetCustomersCollectionAsync();

        foreach (var customerDto in customersCollection)
        {
            logger.LogInformation("Processing Customer with Id: {0}", customerDto.Id);
            
            await customerTargetApi.SaveCustomerAsync(customerDto);
        }
    }
}