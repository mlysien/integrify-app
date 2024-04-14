using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Orders.Core.Commands;

/// <summary>
/// Command for begin synchronization of orders.
/// </summary>
public record SynchronizeOrders : ICommand;