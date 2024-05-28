using Integrify.Clients.Cli.Interpreter.Commands.Abstractions;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.Plugins;

namespace Integrify.Clients.Cli.Interpreter.Commands.Executors;

public class InfoCommand(IList<IPlugin> plugins, IList<IIntegration> integrations) : IInfoCommand
{
    public string Keyword => "info";

    public Task Execute(params string[] options)
    {
        if (options.Contains("--areas"))
        {
            PrintAvailableIntegrations();
            return Task.CompletedTask;
        }

        if (options.Contains("--plugins"))
        {
            PrintLoadedPlugins();
            return Task.CompletedTask;
        }
        
        return Task.CompletedTask;
    }

    public void Help()
    { 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Keyword}");
        Console.ResetColor();
        Console.WriteLine(" - prints loaded plugins and available integration areas.");
        Console.WriteLine("How to use:");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"{Keyword} --areas");
        Console.WriteLine($"{Keyword} --plugins");
        Console.ResetColor();
    }

    private void PrintLoadedPlugins()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Loaded plugins:");
        Console.ResetColor();
        foreach (var plugin in plugins)
        {          
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("* ");
            Console.ResetColor();
            Console.WriteLine(plugin.Name);
        }
    }
    
    private void PrintAvailableIntegrations()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Available integrations:");
        Console.ResetColor();
        foreach (var integration in integrations)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("* ");
            Console.ResetColor();
            Console.WriteLine(integration.Name);
        }
    }
}