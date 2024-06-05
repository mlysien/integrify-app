namespace Integrify.Plugins.ShopSimulator.Domain.Models;

public class Product
{
    public Guid Id { get; init; }

    public required string Name { get; init; }
    
    public double Price { get; init; }

    public double Tax { get; init; }

    public DateTime LastUpdated { get; set; }
}