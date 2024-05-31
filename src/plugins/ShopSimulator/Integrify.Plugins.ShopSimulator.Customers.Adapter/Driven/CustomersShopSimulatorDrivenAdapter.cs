using Integrify.Integrations.Customers.Model;
using Integrify.Integrations.Customers.Port.Driven;

namespace Integrify.Plugins.ShopSimulator.Customers.Adapter.Driven;

public class CustomersShopSimulatorDrivenAdapter : ICustomersIntegrationDrivenPort
{
    public Task PushAsync(CustomerIntegrationModel integrationModel)
    {
        return Task.CompletedTask;
    }
}