using Plugins.Inbounds.Example.Service.Dtos;

namespace Plugins.Inbounds.Example.Service.Services.Abstractions;

public interface IRestApiService
{
    Task<IReadOnlyCollection<OrderDto>> GetOrders();
}