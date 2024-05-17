using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driven;

internal sealed class CustomersErpSimulatorDrivenAdapter : ICustomersIntegrationDrivenPort
{
    public Task PushAsync(CustomerIntegrationModel integrationModel)
    {
        return Task.CompletedTask;
    }
}