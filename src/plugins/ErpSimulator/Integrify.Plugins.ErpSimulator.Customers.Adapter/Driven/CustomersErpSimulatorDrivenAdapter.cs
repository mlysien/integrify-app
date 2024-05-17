using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driven;

public class CustomersErpSimulatorDrivenAdapter : ICustomersIntegrationDrivenPort
{
    public Task SaveCustomerAsync(CustomerModel customerModel)
    {
        // todo: here should be some business logic for saving customer model into real ERP system
         
        return Task.CompletedTask;
    }
}