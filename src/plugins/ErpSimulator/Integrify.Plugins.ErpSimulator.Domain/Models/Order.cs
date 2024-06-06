namespace Integrify.Plugins.ErpSimulator.Domain.Models;

public class Order
{
    public Guid Id { get; init; }
    
    public DateTime CreatedAt { get; init; }
    
    public DateTime UpdatedAt { get; init; }
    
    public int OrderStateId { get; init; }
}