using Bogus;
using Integrify.Plugins.ShopSimulator.Domain.Models;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories;

public sealed class OrderRepository : Faker<Order>, IOrderRepository
{
    public OrderRepository()
    {
        RuleFor(d => d.Id, f => Guid.NewGuid());
        RuleFor(d => d.TotalAmmount, f => f.Random.Number(10, 200));
        RuleFor(d => d.CreatedAt, f => DateTime.UtcNow.AddMinutes(f.Random.Number(1, 20)));
        RuleFor(d => d.UpdatedAt, f => DateTime.UtcNow.AddHours(f.Random.Number(-5, 1)));
        RuleFor(d => d.Customer, f => new Customer()
        {
            Id = Guid.NewGuid(),
            Name = f.Person.FullName,
            LastUpdated = f.Date.Past(),
            AccountActivated = f.Random.Bool()
        });
        RuleFor(d => d.Products, f =>
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = f.Commerce.ProductName(),
                Category = f.Commerce.Categories(1).First(),
                Description = f.Commerce.ProductDescription(),
                Price = f.Random.Number(10, 50),
                Tax = 0.23,
                LastUpdated = f.Date.Past()
            }
        ]);

    }
    
    public Task<List<Order>> GetOrdersAsync()
    {
        return Task.Run(() => Generate(20));
    }

    public Task<Order> GetOrderAsync(Guid id)
    {
        return Task.Run(() => Generate());
    }
}