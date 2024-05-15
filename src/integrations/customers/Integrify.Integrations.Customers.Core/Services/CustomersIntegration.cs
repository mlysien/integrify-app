using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Driving;
using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Customers.Core.Services;

public class CustomersIntegration(ILogger<CustomersIntegration> logger) : ICustomersIntegration
{
    public async Task RunIntegration()
    {
        logger.LogInformation("Customers integration started");
    }
}