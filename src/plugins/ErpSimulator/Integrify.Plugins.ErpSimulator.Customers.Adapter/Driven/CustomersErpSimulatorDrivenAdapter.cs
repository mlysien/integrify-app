using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driven;

public class CustomersErpSimulatorDrivenAdapter : ICustomersIntegrationDrivenPort
{
    public Task SaveCustomerAsync(CustomerModel customerModel)
    {
        throw new NotImplementedException();
    }
}