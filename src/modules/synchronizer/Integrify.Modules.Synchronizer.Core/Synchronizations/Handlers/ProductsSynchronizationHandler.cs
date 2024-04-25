using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Synchronizer.Core.Synchronizations.Handlers;

internal sealed class ProductsSynchronizationHandler : ICommandHandler<ProductsSynchronizations>
{
    public Task HandleAsync(ProductsSynchronizations command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}