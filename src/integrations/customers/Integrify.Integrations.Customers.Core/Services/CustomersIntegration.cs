using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Driving;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Customers.Core.Services;

internal sealed class CustomersIntegration(
    ILogger<CustomersIntegration> logger,
    ICustomersIntegrationDrivingPort drivingPort,
    ICustomersIntegrationDrivenPort drivenPort) : ICustomersIntegration
{
    public async Task RunCustomersIntegration()
    {
        logger.LogInformation("Customers integration started");

        var customersCollection = await drivingPort.GetCustomersCollectionAsync();

        logger.LogInformation("Received {count} customers", customersCollection.Count);

        foreach (var customerModel in customersCollection)
        {
            logger.LogInformation("Processing customer with Id: {id}", customerModel.Id);

            if (customerModel.IsActive is not true)
            {
                logger.LogInformation("Customer is not active, skipped");
            }
            
            await drivenPort.SaveCustomerAsync(customerModel);
        }
    }
}