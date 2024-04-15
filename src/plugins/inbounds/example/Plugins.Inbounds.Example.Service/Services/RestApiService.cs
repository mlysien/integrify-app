using Plugins.Inbounds.Example.Service.Dtos;
using Plugins.Inbounds.Example.Service.Services.Abstractions;

namespace Plugins.Inbounds.Example.Service.Services;

internal class RestApiService : IRestApiService
{
    public async Task<IReadOnlyCollection<OrderDto>> GetOrders()
    {
        var orders = new List<OrderDto>()
        {
            new()
            {
                OrderId = Guid.NewGuid(),
                CreatedAt = DateTime.Now
            },
            new()
            {
                OrderId = Guid.NewGuid(),
                CreatedAt = DateTime.Now.AddDays(-1)
            },
            new()
            {
                OrderId = Guid.NewGuid(),
                CreatedAt = DateTime.Now.AddDays(-4)
            }
        };

        return orders;
    }
}