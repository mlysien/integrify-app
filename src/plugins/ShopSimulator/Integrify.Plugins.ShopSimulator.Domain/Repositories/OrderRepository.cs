using Bogus;
using Integrify.Plugins.ShopSimulator.Domain.Models;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;

namespace Integrify.Plugins.ShopSimulator.Domain.Repositories;

public sealed class OrderRepository : Faker<Order>, IOrderRepository
{
    public OrderRepository()
    {
        var orderItemFaker = new Faker<OrderItem>()
            .RuleFor(o => o.ProductId, f => Guid.NewGuid())
            .RuleFor(o => o.Price, f => f.Random.Number(1, 50))
            .RuleFor(o => o.Amount, f => f.Random.Number(1, 10));
        
        RuleFor(d => d.Id, f => Guid.NewGuid());
        RuleFor(d => d.TotalAmmount, f => f.Random.Number(10, 200));
        RuleFor(d => d.CreatedAt, f => DateTime.UtcNow.AddMinutes(f.Random.Number(1, 20)));
        RuleFor(d => d.UpdatedAt, f => DateTime.UtcNow.AddHours(f.Random.Number(-5, 1)));
        RuleFor(d => d.Status, f => f.Random.Number(0, 5));
        RuleFor(d => d.Customer, f => new Customer()
        {
            Id = Guid.NewGuid(),
            Name = f.Person.FullName,
            LastUpdated = f.Date.Past(),
            AccountActivated = f.Random.Bool()
        });
        RuleFor(d => d.OrderItems, f => orderItemFaker.Generate(new Random().Next(1, 5)));
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