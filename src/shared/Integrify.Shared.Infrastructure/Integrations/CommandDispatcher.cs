using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Integrations;

internal sealed class IntegrationDispatcher(IServiceProvider serviceProvider) : IIntegrationDispatcher
{
    public async Task SendAsync<TIntegration>(TIntegration command, CancellationToken cancellationToken = default) 
        where TIntegration : class, ICommand
    {
        using var scope = serviceProvider.CreateScope();
        var handler = scope.ServiceProvider.GetRequiredService<IIntegrationHandler<TIntegration>>();
        await handler.HandleAsync(command, cancellationToken);
    }
}
