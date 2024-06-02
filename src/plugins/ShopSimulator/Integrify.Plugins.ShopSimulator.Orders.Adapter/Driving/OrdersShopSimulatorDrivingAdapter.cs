using Integrify.Integrations.Orders.Model;
using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ShopSimulator.Orders.Adapter.Driving;

internal sealed class OrdersShopSimulatorDrivingAdapter : IOrdersIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<OrderIntegrationModel>> FetchCollectionAsync(IntegrationTimestamp timestamp)
    {
        return await Task.Run(() => new List<OrderIntegrationModel>()
        {
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                CreatedAt = DateTime.Now.AddDays(-2)
            },
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                CreatedAt = DateTime.Now.AddDays(-1)
            },
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                CreatedAt = DateTime.Now.AddDays(-4)
            },
            new()
            {
                Id = new IntegrationId(Guid.NewGuid()),
                CreatedAt = DateTime.Now.AddHours(-4)
            }
        });
    }

    public async Task<OrderIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        return await Task.Run(() => new OrderIntegrationModel
        {
            Id = new IntegrationId(Guid.NewGuid()),
            CreatedAt = DateTime.Now.AddDays(-2)   
        });
    }
}