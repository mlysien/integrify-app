using Integrify.Integrations.Customers.Model;
using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ErpSimulator.Customers.Adapter.Driving;

internal sealed class CustomersErpSimulatorDrivingAdapter : ICustomersIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<CustomerIntegrationModel>> FetchCollectionAsync(IntegrationTimestamp timestamp)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        throw new NotImplementedException();
    }
}