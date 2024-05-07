using Integrify.Modules.Customers.Port.Api;
using Integrify.Modules.Customers.Port.Dto;

namespace Integrify.Plugins.Shops.TemplateShop.Adapter.Customers;

internal class CustomerSourceApi : ICustomerSourceApi
{
    public async Task<IReadOnlyCollection<CustomerDto>> GetCustomersCollectionAsync()
    {
        return await Task.Run(() => new List<CustomerDto>()
        {
            new()
            {
                Id = Guid.NewGuid()
            }
        });
    }

    public async Task<CustomerDto> GetSingleCustomer(Guid id)
    {
        return await Task.Run(() =>
            new CustomerDto()
            {
                Id = Guid.NewGuid()
            }
        );
    }
}