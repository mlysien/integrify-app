using Integrify.Integrations.Orders.Port.Models;

namespace Integrify.Integrations.Orders.Port.Driving;

public interface IOrdersIntegrationDrivingPort
{
    Task<IReadOnlyCollection<OrderIntegrationModel>> GetOrdersCollectionAsync();

    Task<OrderIntegrationModel> GetSingleOrderAsync(Guid id);
}