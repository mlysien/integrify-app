using Integrify.Shared.Abstractions.Time;
using Plugins.Inbounds.Example.Port.Api;
using Plugins.Inbounds.Example.Port.Dto;

namespace Plugins.Inbounds.Example.Core.Services;

internal class InboundOrdersApi(IClock clock) : IInboundOrdersApi
{
    public async Task<OrderDto> GetOrderAsync(Guid orderId)
    {
        return await Task.Run(() => new OrderDto(Guid.NewGuid(), clock.CurrentDate()));
    }
}