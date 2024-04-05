using Integrify.Shared.Abstractions.Plugins;

namespace Integrify.Modules.Orders.Core.Contracts;

public class OrderSourceData : IPluginContract
{
    public Guid Id { get; set; }

    public DateTime CreatedAt { get; set; }
}