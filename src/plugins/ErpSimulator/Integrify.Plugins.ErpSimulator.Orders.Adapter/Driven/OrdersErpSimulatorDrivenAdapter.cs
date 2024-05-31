using Integrify.Integrations.Orders.Model;
using Integrify.Integrations.Orders.Port.Driven;

namespace Integrify.Plugins.ErpSimulator.Orders.Adapter.Driven;

public class OrdersErpSimulatorDrivenAdapter : IOrdersIntegrationDrivenPort
{
    public Task PushAsync(OrderIntegrationModel integrationModel)
    {
        return Task.CompletedTask;
    }
}