using Integrify.Modules.Customers.Port.Dto;

namespace Integrify.Modules.Customers.Port.Api;

public interface ICustomerSourceApi
{
    Task<IReadOnlyCollection<CustomerDto>> GetCustomersCollectionAsync();

    Task<CustomerDto> GetSingleCustomer(Guid id);
}