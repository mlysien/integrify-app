using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Driving;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Customers.Core.Services;

public class CustomersIntegration(
    ILogger<CustomersIntegration> logger,
    ICustomersIntegrationDrivingPort drivingPort,
    ICustomersIntegrationDrivenPort drivenPort) : ICustomersIntegration
{
    public async Task RunIntegration()
    {
        logger.LogInformation("Customers integration started");

        var customersCollection = await drivingPort.GetCustomersCollection();

        foreach (var customerModel in customersCollection)
        {
            logger.LogInformation("Processing Customer with Id: {0}", customerModel.Id);

            await drivenPort.SaveCustomerAsync(customerModel);
        }
    }
}