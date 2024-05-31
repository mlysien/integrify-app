using Integrify.Integrations.Customers.Model;
using Integrify.Integrations.Customers.Port.Driving;

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