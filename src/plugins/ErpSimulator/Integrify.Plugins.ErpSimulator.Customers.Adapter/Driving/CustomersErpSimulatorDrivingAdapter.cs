using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driving;

public class CustomersErpSimulatorDrivingAdapter : ICustomersIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<CustomerIntegrationModel>> GetCustomersCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerIntegrationModel> GetSingleCustomerAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}