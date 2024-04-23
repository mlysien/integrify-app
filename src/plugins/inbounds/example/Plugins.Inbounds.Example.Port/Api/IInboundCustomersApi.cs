using Plugins.Inbounds.Example.Port.Dto;

namespace Plugins.Inbounds.Example.Port.Api;

public interface IInboundCustomersApi
{
    Task<CustomerDto> GetCustomerAsync(Guid customerId);

    Task<IReadOnlyCollection<CustomerDto>> GetCustomersCollectionAsync();
}