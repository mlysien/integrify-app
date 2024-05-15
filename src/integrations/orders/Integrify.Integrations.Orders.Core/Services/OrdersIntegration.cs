using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Orders.Core.Services;

internal class OrdersIntegration(ILogger<OrdersIntegration> logger) : IOrdersIntegration
{
    public async Task RunIntegration()
    {
        logger.LogInformation("Orders integration started");
    }
}