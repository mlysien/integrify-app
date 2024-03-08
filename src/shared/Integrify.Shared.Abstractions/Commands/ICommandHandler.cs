namespace Integrify.Shared.Abstractions.Commands;

/// <summary>
/// Interface for handling commands
/// </summary>
public interface ICommandHandler<in TCommand> where TCommand : class, ICommand
{
    /// <summary>
    /// Handling specified command
    /// </summary>
    /// <param name="command">Handling command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task HandleAsync(TCommand command, CancellationToken cancellationToken = default);
}