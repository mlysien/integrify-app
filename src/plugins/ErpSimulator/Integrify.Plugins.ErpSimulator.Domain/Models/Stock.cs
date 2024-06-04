namespace Integrify.Plugins.ErpSimulator.Domain.Models;

public class Stock
{
    public Guid Id { get; set; }

    public required Product Product { get; set; }

    public double Amount { get; set; }

    public DateTime LastUpdated { get; set; }
}