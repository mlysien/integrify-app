using Integrify.Modules.Synchronizer.Core.Integrations;
using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Synchronizer.Core.Commands.Handlers;

internal sealed class OrdersSynchronizationHandler : ICommandHandler<OrdersIntegration>
{
    public Task HandleAsync(OrdersIntegration command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}