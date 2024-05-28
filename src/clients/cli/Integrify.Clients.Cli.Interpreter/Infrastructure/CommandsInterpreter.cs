using Integrify.Clients.Cli.Interpreter.Abstractions;
using Integrify.Clients.Cli.Interpreter.Commands.Abstractions;

namespace Integrify.Clients.Cli.Interpreter.Infrastructure;

internal sealed class CommandsInterpreter(IInfoCommand infoCommand, ISyncCommand syncCommand) : IInterpreter
{
    public async Task Interpret(string commandLine)
    {
        var commands = new List<ICommand> { infoCommand, syncCommand };
        var keyword = commandLine.Split(" ").First();
        var options = commandLine.Split(" ").Skip(1).ToArray();
        var command = commands.FirstOrDefault(cmd => cmd.Keyword == keyword);

        if (command is not null)
        {
            await command.Execute(options);
        }
        
        if (keyword == "help")
        {
            PrintHelp(commands);
        }
    }

    private void PrintHelp(IList<ICommand> commands)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Integrify is an integration tool for synchronise data between ERP and e-commerce systems");
        Console.ResetColor();
        Console.WriteLine("For start working with it, use one of available commands:");
        Console.WriteLine();
        
        foreach (var command in commands)
        {            
            command.Help();
            Console.WriteLine();
        }
    }
}