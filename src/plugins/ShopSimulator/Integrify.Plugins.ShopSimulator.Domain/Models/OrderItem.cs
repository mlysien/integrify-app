namespace Integrify.Plugins.ShopSimulator.Domain.Models;

public class OrderItem
{
    public Guid ProductId { get; init; }

    public double Amount { get; init; }

    public double Price { get; init; }
}