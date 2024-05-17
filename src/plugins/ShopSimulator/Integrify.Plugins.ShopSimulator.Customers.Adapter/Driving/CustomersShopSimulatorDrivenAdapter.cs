using Integrify.Integrations.Customers.Port.Driven;
using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Customers.Adapter.Driving;

public class CustomersShopSimulatorDrivingAdapter : ICustomersIntegrationDrivingPort
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