using Integrify.Modules.Customers.Port.Dto;

namespace Integrify.Modules.Customers.Port.Api;

public interface ICustomerSourceApi
{
    Task<IReadOnlyCollection<CustomerSourceDto>> GetCustomersCollectionAsync();
}