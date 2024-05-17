using Integrify.Integrations.Orders.Port.Driven;
using Integrify.Integrations.Orders.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Orders.Adapter.Driven;

public class OrdersErpSimulatorDrivenAdapter : IOrdersIntegrationDrivenPort
{
    public Task SaveOrderAsync(OrderModel orderModel)
    {
        return Task.CompletedTask;
    }
}