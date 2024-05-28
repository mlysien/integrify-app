namespace Integrify.Clients.Cli.Interpreter.Abstractions;

public interface IInterpreter
{
    Task Interpret(string commandLine);
}