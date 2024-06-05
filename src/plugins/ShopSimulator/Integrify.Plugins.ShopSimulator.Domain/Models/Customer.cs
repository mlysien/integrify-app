namespace Integrify.Plugins.ShopSimulator.Domain.Models;

public class Customer
{
    public Guid Id { get; init; }

    public required string Name { get; init; }

    public bool AccountActivated { get; init; }
    
    public DateTime LastUpdated { get; init; }

    public bool IsB2B { get; init; }
}