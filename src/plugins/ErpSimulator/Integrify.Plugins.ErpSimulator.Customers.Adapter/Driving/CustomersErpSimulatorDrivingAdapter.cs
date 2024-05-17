using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driving;

public class CustomersErpSimulatorDrivingAdapter : ICustomersIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<CustomerModel>> GetCustomersCollection()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerModel> GetSingleCustomer(Guid id)
    {
        throw new NotImplementedException();
    }
}