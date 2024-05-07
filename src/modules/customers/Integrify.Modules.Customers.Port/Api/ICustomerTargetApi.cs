using Integrify.Modules.Customers.Port.Dto;

namespace Integrify.Modules.Customers.Port.Api;

public interface ICustomerTargetApi
{
    Task SaveCustomerAsync(CustomerDto customerDto);
}