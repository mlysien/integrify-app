using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Integrations.Orders.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Orders.Adapter.Driving;

public class OrdersErpSimulatorDrivingAdapter : IOrdersIntegrationDrivingPort
{
    public Task<IReadOnlyCollection<OrderIntegrationModel>> GetOrdersCollectionAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OrderIntegrationModel> GetSingleOrderAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}