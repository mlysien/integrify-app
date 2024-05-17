using Integrify.Integrations.Orders.Port.Driven;
using Integrify.Integrations.Orders.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Orders.Adapter.Driven;

public class OrdersShopSimulatorDrivenAdapter : IOrdersIntegrationDrivenPort
{
    public Task SaveOrderAsync(OrderIntegrationModel orderIntegrationModel)
    {
        throw new NotImplementedException();
    }
}