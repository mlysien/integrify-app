using Integrify.Shared.Abstractions.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Commands;

internal sealed class CommandDispatcher(IServiceProvider serviceProvider) : ICommandDispatcher
{
    public async Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand
    {
        using var scope = serviceProvider.CreateScope();
        var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();
        await handler.HandleAsync(command, cancellationToken);
    }
}
