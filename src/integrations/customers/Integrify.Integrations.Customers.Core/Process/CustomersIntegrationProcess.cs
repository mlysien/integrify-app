using Integrify.Integrations.Customers.Core.Abstractions;
using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Customers.Core.Process;

internal sealed class CustomersIntegrationProcess(
    ILogger<CustomersIntegrationProcess> logger,
    IIntegrationRepository integrationRepository,
    ICustomersIntegrationDrivingPort drivingPort,
    ICustomersIntegrationDrivenPort drivenPort) 
    : ICustomersIntegrationProcess
{
    public async Task ExecuteIntegrationProcess()
    {
        logger.LogInformation("Customers integration started");

        var lastIntegrationTimestamp = await integrationRepository.GetLastIntegrationTimestamp("customers");
        
        var customersCollection = await drivingPort.FetchCollectionAsync(lastIntegrationTimestamp);

        logger.LogInformation("Received {count} customers", customersCollection.Count);

        foreach (var customerModel in customersCollection)
        {
            logger.LogInformation("Processing customer with Id: {id}", customerModel.Id);

            if (customerModel.IsActive is not true)
            {
                logger.LogWarning("Customer is not active, skipped");
            }
            
            await drivenPort.PushAsync(customerModel);
        }

        await integrationRepository.UpdateLastIntegrationTimestamp();
    }
}