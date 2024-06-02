using Integrify.Integrations.Orders.Model;
using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ErpSimulator.Orders.Adapter.Driving;

internal sealed class OrdersErpSimulatorDrivingAdapter : IOrdersIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<OrderIntegrationModel>> FetchCollectionAsync(IntegrationTimestamp timestamp)
    {
        throw new NotImplementedException();
    }

    public Task<OrderIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        throw new NotImplementedException();
    }
}