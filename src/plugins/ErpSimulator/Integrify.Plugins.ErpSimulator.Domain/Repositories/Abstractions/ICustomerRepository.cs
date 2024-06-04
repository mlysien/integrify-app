using Integrify.Plugins.ErpSimulator.Domain.Models;

namespace Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;

public interface ICustomerRepository
{
    Task SaveCustomerAsync(Customer customer);
}