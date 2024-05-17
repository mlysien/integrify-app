using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Integrations.Orders.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Orders.Adapter.Driving;

public class OrdersErpSimulatorDrivingAdapter : IOrdersIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<OrderModel>> GetOrdersCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OrderModel> GetSingleOrderAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}