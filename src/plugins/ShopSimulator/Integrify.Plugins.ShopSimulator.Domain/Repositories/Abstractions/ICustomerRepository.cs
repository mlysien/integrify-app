using Integrify.Plugins.ShopSimulator.Domain.Models;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

public interface ICustomerRepository
{
    Task<List<Customer>> GetCustomersAsync();

    Task<Customer> GetCustomerAsync(Guid id);
}