using Integrify.Integrations.Customers.Model;
using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Plugins.ErpSimulator.Domain.Models;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;
using Integrify.Shared.Abstractions.Time;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driven;

internal sealed class CustomersErpSimulatorDrivenAdapter(
    IClock clock,
    ICustomerRepository repository) 
    : ICustomersIntegrationDrivenPort
{
    public async Task PushAsync(CustomerIntegrationModel integrationModel)
    {
        var customer = new Customer()
        {
            Id = integrationModel.Id.Value,
            Name = integrationModel.Name,
            LastUpdated = clock.NowDateTime()
        };

        await repository.SaveCustomerAsync(customer);
    }
}