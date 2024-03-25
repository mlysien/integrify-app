using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Dispatchers;
using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Queries;

namespace Integrify.Shared.Infrastructure.Dispatchers;

internal sealed class DefaultDispatcher(
    ICommandDispatcher commandDispatcher,
    IQueryDispatcher queryDispatcher,
    IEventPublisher eventPublisher)
    : IDispatcher
{

    public Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand
        => commandDispatcher.SendAsync(command, cancellationToken);

    public Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : class, IEvent
        => eventPublisher.PublishAsync(@event, cancellationToken);

    public Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default)
        => queryDispatcher.QueryAsync(query, cancellationToken);
}