using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driving;

public class CustomersErpSimulatorDrivingAdapter : ICustomersIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<CustomerModel>> GetCustomersCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerModel> GetSingleCustomerAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}