using Integrify.Integrations.Customers.Core.Abstractions;
using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Driving;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Customers.Core.Process;

internal sealed class CustomersIntegrationProcess(
    ILogger<CustomersIntegrationProcess> logger,
    ICustomersIntegrationRepository repository,
    ICustomersIntegrationDrivingPort drivingPort,
    ICustomersIntegrationDrivenPort drivenPort) 
    : ICustomersIntegrationProcess
{
    public async Task ExecuteIntegrationProcessAsync()
    {
        logger.LogInformation("Customers integration started");

        var timestamp = await repository.GetLastIntegrationTimestampAsync();
        var customersCollection = await drivingPort.FetchCollectionAsync(timestamp);

        logger.LogInformation("Received {count} customers", customersCollection.Count);

        foreach (var customerModel in customersCollection)
        {
            logger.LogInformation("Processing customer with Id: {id}, Name: {name}", 
                customerModel.Id.Value, customerModel.Name);

            if (customerModel.IsActive is not true)
            {
                logger.LogWarning("Customer is not active, skipped");
            }

            await drivenPort.PushAsync(customerModel);
        }
        
        await repository.UpdateIntegrationTimestampAsync();
        
        logger.LogInformation("Customers integration finished");
    }
}