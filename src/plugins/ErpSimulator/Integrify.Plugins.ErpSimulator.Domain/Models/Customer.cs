namespace Integrify.Plugins.ErpSimulator.Domain.Models;

public class Customer
{
    public Guid Id { get; init; }

    public required string Name { get; init; }
    
    public DateTime LastUpdated { get; set; }
}