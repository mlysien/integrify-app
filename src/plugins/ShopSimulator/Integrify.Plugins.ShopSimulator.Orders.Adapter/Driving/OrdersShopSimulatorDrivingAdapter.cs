using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Integrations.Orders.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Orders.Adapter.Driving;

internal sealed class OrdersShopSimulatorDrivingAdapter : IOrdersIntegrationDrivingPort
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