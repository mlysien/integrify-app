using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Customers.Core.Services;

internal sealed class CustomersIntegration(ILogger<CustomersIntegration> logger) : ICustomersIntegration
{
    public async Task RunIntegration()
    {
        logger.LogInformation("Customers integration started");
    }
}