using Integrify.Integrations.Customers.Model;
using Integrify.Integrations.Customers.Port.Driven;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driven;

internal sealed class CustomersErpSimulatorDrivenAdapter : ICustomersIntegrationDrivenPort
{
    public Task PushAsync(CustomerIntegrationModel integrationModel)
    {
        return Task.CompletedTask;
    }
}