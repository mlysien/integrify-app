using Integrify.Integrations.Orders.Model;
using Integrify.Integrations.Orders.Port.Driven;

namespace Integrify.Plugins.ShopSimulator.Orders.Adapter.Driven;

public class OrdersShopSimulatorDrivenAdapter : IOrdersIntegrationDrivenPort
{
    public Task PushAsync(OrderIntegrationModel integrationModel)
    {
        throw new NotImplementedException();
    }
}