namespace Plugins.Inbounds.Example.Service.Dtos;

public sealed class OrderDto
{
    public Guid OrderId { get; set; }

    public DateTime CreatedAt { get; set; }
}