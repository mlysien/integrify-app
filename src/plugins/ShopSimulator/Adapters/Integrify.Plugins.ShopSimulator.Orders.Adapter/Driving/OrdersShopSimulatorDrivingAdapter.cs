using Integrify.Integrations.Orders.Model;
using Integrify.Integrations.Orders.Model.Enums;
using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ShopSimulator.Orders.Adapter.Driving;

internal sealed class OrdersShopSimulatorDrivingAdapter(IOrderRepository repository) : IOrdersIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<OrderIntegrationModel>> FetchCollectionAsync(IntegrationTimestamp timestamp)
    {
        var models = new List<OrderIntegrationModel>();
        var ordersList = await repository.GetOrdersAsync();
        
        foreach (var order in ordersList)
        {
            if (order.UpdatedAt.Ticks >= timestamp.Ticks)
            {
                models.Add(new OrderIntegrationModel()
                {
                    Id = new IntegrationId(order.Id),
                    CreatedAt = order.CreatedAt,
                    Status = (OrderStatus)order.Status
                });
            }
        }

        return models;
    }

    public async Task<OrderIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        var order = await repository.GetOrderAsync(id.Value);

        return new OrderIntegrationModel()
        {
            Id = new IntegrationId(order.Id),
            CreatedAt = order.CreatedAt
        };
    }
}