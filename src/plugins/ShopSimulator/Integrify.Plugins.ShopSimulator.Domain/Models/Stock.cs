namespace Integrify.Plugins.ShopSimulator.Domain.Models;

public class Stock
{
    public Guid Id { get; set; }

    public Product? Product { get; set; }

    public double Amount { get; set; }

    public DateTime LastUpdated { get; set; }
}