using Bogus;
using Integrify.Plugins.ShopSimulator.Domain.Models;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories;

internal sealed class CustomerRepository : Faker<Customer>, ICustomerRepository
{
    public CustomerRepository()
    {
        RuleFor(d => d.Id, f => Guid.NewGuid());
        RuleFor(d => d.Name, f => f.Person.FullName);
        RuleFor(d => d.AccountActivated, f => f.Random.Bool());
        RuleFor(d => d.IsB2B, f => f.Random.Bool());
        RuleFor(d => d.LastUpdated, f => DateTime.UtcNow.AddHours(f.Random.Number(-5, 1)));
    }
    
    public Task<List<Customer>> GetCustomersAsync()
    {
        return Task.Run(() => Generate(20));
    }

    public Task<Customer> GetCustomerAsync(Guid id)
    {
        return Task.Run(() => Generate());
    }
}