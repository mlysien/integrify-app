namespace Integrify.Clients.Cli.Interpreter.Commands.Abstractions;

public interface ICommand
{
    string Keyword { get; }
    
    Task Execute(params string[] options);
}