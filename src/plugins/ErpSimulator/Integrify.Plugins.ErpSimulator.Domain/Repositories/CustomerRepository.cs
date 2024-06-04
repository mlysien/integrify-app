using Bogus;
using Integrify.Plugins.ErpSimulator.Domain.Models;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ErpSimulator.Domain.Repositories;

internal sealed class CustomerRepository : Faker<Customer>, ICustomerRepository
{
    public CustomerRepository()
    {
        RuleFor(d => d.Id, f => Guid.NewGuid());
        RuleFor(d => d.Name, f => f.Person.FullName);
        RuleFor(d => d.LastUpdated, f => DateTime.UtcNow.AddSeconds(f.Random.Number(-10, 1)));
    }
    
    public Task<List<Customer>> GetCustomersAsync()
    {
        return Task.Run(() => Generate(20));
    }

    public async Task SaveCustomerAsync(Customer customer)
    {
        await Task.Delay(1000);
    }
}