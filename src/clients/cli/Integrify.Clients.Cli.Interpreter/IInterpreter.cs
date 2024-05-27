namespace Integrify.Clients.Cli.Interpreter;

public interface IInterpreter
{
    Task Interpret(string commandLine);
}