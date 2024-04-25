using Integrify.Modules.Synchronizer.Core.Integrations;
using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Synchronizer.Core.Commands.Handlers;

internal sealed class ProductsSynchronizationHandler : ICommandHandler<ProductsIntegrations>
{
    public Task HandleAsync(ProductsIntegrations command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}