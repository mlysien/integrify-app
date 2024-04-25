using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Synchronizer.Core.Commands.Handlers;

internal sealed class OrdersSynchronizationHandler : ICommandHandler<OrdersSynchronization>
{
    public Task HandleAsync(OrdersSynchronization command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}