using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Synchronizer.Core.Commands.Handlers;

internal sealed class ProductsSynchronizationHandler : ICommandHandler<ProductsSynchronization>
{
    public Task HandleAsync(ProductsSynchronization command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}