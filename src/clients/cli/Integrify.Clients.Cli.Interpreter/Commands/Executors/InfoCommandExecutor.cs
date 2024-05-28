using Integrify.Clients.Cli.Interpreter.Commands.Abstractions;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.Plugins;

namespace Integrify.Clients.Cli.Interpreter.Commands.Executors;

public class InfoCommandExecutor(IList<IPlugin> plugins, IList<IIntegration> integrations) : IInfoCommand
{
    public string Keyword => "info";

    public async Task Execute(params string[] options)
    {
        var option = options.FirstOrDefault()?.ToLower();
        
        if (option != null && option.Contains("--areas"))
        {
            PrintAvailableIntegrationAreas();
            return;
        }

        if (option != null && option.Contains("--plugins"))
        {
            PrintLoadedPlugins();
            return;
        }

        Help();
    }

    public void Help()
    { 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Keyword}");
        Console.ResetColor();
        Console.WriteLine(" - prints loaded plugins or available integration areas.");
        Console.Write("How to use: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"{Keyword} --plugins or --areas");
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
    
    private void PrintAvailableIntegrationAreas()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Available integration areas:");
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