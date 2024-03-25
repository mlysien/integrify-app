using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Queries;

namespace Integrify.Shared.Abstractions.Dispatchers;

public interface IDispatcher
{
    Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand;
    Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : class, IEvent;
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
}