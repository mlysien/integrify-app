using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Synchronizations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Synchronizations;

internal sealed class SynchronizationDispatcher(IServiceProvider serviceProvider) : ISynchronizationDispatcher
{
    public async Task SendAsync<TSynchronization>(TSynchronization command, CancellationToken cancellationToken = default) 
        where TSynchronization : class, ICommand
    {
        using var scope = serviceProvider.CreateScope();
        var handler = scope.ServiceProvider.GetRequiredService<ISynchronizationHandler<TSynchronization>>();
        await handler.HandleAsync(command, cancellationToken);
    }
}
