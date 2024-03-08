namespace Integrify.Shared.Abstractions.Commands;

/// <summary>
/// Interface for dispatching commands
/// </summary>
public interface ICommandDispatcher
{
    /// <summary>
    /// Dispatching specified command
    /// </summary>
    /// <param name="command">Dispatching command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default) where TCommand : class, ICommand;
}