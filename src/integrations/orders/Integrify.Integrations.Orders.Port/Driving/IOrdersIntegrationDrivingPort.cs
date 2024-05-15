using Integrify.Integrations.Orders.Port.Models;

namespace Integrify.Integrations.Orders.Port.Driving;

public interface IOrdersIntegrationDrivingPort
{
    Task<IReadOnlyCollection<OrderModel>> GetOrdersCollectionAsync();

    Task<OrderModel> GetSingleOrderAsync(Guid id);
}