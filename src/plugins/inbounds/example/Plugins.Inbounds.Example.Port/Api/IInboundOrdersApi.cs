using Plugins.Inbounds.Example.Port.Dto;

namespace Plugins.Inbounds.Example.Port.Api;

public interface IInboundOrdersApi
{
    Task<OrderDto> GetOrderAsync(Guid orderId);
}