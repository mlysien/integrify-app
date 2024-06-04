using Integrify.Plugins.ErpSimulator.Domain.Models;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ErpSimulator.Domain.Repositories;

internal sealed class CustomerRepository : ICustomerRepository
{
    public async Task SaveCustomerAsync(Customer customer)
    {
        await Task.Delay(new Random().Next(100, 1000));
    }
}