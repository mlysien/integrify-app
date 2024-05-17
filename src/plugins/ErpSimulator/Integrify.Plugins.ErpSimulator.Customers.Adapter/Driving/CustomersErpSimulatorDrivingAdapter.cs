using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driving;

public class CustomersErpSimulatorDrivingAdapter : ICustomersIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<CustomerIntegrationModel>> FetchCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerIntegrationModel> GetSingleAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}