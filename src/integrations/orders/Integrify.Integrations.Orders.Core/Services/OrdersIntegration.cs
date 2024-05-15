using Microsoft.Extensions.Logging;

namespace Integrify.Integrations.Orders.Core.Services;

internal class OrdersIntegration(ILogger<OrdersIntegration> logger) : IOrdersIntegration
{
    public Task RunIntegration()
    {
        logger.LogInformation("Orders integration started");
        
        return Task.CompletedTask;
    }
}