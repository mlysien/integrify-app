using Integrify.Clients.Cli.Interpreter.Commands.Abstractions;

namespace Integrify.Clients.Cli.Interpreter.Commands.Executors;

public class SyncCommandExecutor : ISyncCommand
{
    public string Keyword => "sync";
    
    public Task Execute(params string[] options)
    {
        if (!options.Any())
        {
            Help();
        }
        
        return Task.CompletedTask;
    }

    public void Help()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Keyword}");
        Console.ResetColor();
        Console.WriteLine(" - begin synchronization process of specified integration area.");
        Console.WriteLine("How to use:");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"{Keyword} [integration area]");
        Console.ResetColor();

    }
}