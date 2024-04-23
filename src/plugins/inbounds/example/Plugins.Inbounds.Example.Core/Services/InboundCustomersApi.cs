using Plugins.Inbounds.Example.Port.Api;
using Plugins.Inbounds.Example.Port.Dto;

namespace Plugins.Inbounds.Example.Core.Services;

internal class InboundCustomersApi : IInboundCustomersApi
{
    public async Task<CustomerDto> GetCustomerAsync(Guid customerId)
    {
        return await Task.Run(() => new CustomerDto(Guid.NewGuid(), "Cezary Blachowski"));
    }

    public async Task<IReadOnlyCollection<CustomerDto>> GetCustomersCollectionAsync()
    {
        return await Task.Run(() =>
        {
            return new List<CustomerDto>()
            {
                new(Guid.NewGuid(), "Nikodem Wojdat"),
                new(Guid.NewGuid(), "Marcin Maniecki"),
                new(Guid.NewGuid(), "Bohdan Smal"),
                new(Guid.NewGuid(), "Nataliia Kalicka"),
                new(Guid.NewGuid(), "Cezary Blachowski"),
            };
        });
    }
}