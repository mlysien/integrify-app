using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Customers.Adapter.Driven;

public class CustomersShopSimulatorDrivenAdapter : ICustomersIntegrationDrivenPort
{
    public Task SaveCustomerAsync(CustomerModel customerModel)
    {
        throw new NotImplementedException();
    }
}