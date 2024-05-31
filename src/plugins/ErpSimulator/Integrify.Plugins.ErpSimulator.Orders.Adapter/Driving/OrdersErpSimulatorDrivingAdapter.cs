using Integrify.Integrations.Orders.Model;
using Integrify.Integrations.Orders.Port.Driving;

namespace Integrify.Plugins.ErpSimulator.Orders.Adapter.Driving;

public class OrdersErpSimulatorDrivingAdapter : IOrdersIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<OrderIntegrationModel>> FetchCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OrderIntegrationModel> GetSingleAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}