using Integrify.Shared.Abstractions.Plugins;

namespace Plugins.Inbounds.Example.Api.Contracts.Orders;

public abstract record ExampleOrderContract(Guid orderId, DateTime createdAt) : IOrderContract;