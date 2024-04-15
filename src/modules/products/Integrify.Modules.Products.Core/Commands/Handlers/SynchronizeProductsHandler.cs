using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Products.Core.Commands.Handlers;

public class SynchronizeProductsHandler : ICommandHandler<SynchronizeProducts>
{
    public Task HandleAsync(SynchronizeProducts command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}