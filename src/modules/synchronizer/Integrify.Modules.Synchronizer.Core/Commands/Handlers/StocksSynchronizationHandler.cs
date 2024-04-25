using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Synchronizer.Core.Commands.Handlers;

internal sealed class StocksSynchronizationHandler : ICommandHandler<StocksSynchronization>
{
    public Task HandleAsync(StocksSynchronization command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}