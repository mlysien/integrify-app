using Integrify.Clients.Cli.Interpreter.Commands.Abstractions;

namespace Integrify.Clients.Cli.Interpreter;

public class CommandsInterpreter(IInfoCommand infoCommand) : IInterpreter
{
    public async Task Interpret(string commandLine)
    {
        var commands = new List<ICommand> { infoCommand };
        var keyword = commandLine.Split(" ").First();
        var options = commandLine.Split(" ").Skip(1).ToArray();
        var command = commands.FirstOrDefault(cmd => cmd.Keyword == keyword);

        if (command is not null)
        {
            await command.Execute(options);
        }
    }
}