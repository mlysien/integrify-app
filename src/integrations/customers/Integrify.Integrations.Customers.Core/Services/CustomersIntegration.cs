using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Customers.Core.Services;

internal sealed class CustomersIntegration(ILogger<CustomersIntegration> logger) : ICustomersIntegration
{
    public Task RunIntegration()
    {
        logger.LogInformation("Customers integration started");

        return Task.CompletedTask;
    }
}