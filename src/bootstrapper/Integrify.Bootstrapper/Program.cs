using System.Reflection;
using Integrify.Shared.Infrastructure;
using Integrify.Shared.Infrastructure.Modules;

var builder = WebApplication.CreateBuilder(args);
var assemblies = ModuleLoader.LoadAssemblies(builder.Configuration, "Integrify.Modules.");
builder.Services.AddModularInfrastructure(assemblies);

var app = builder.Build();
PrintBanner();


app.UseModularInfrastructure();
app.MapGet("/", () => "Integrify is running!");
app.Run();
return;

void PrintBanner()
{
    Console.WriteLine("""
                       _____ _   _ _______ ______ _____ _____  _____ ________     __
                      |_   _| \ | |__   __|  ____/ ____|  __ \|_   _|  ____\ \   / /
                        | | |  \| |  | |  | |__ | |  __| |__) | | | | |__   \ \_/ / 
                        | | | . ` |  | |  |  __|| | |_ |  _  /  | | |  __|   \   /  
                       _| |_| |\  |  | |  | |___| |__| | | \ \ _| |_| |       | |   
                      |_____|_| \_|  |_|  |______\_____|_|  \_\_____|_|       |_|   
                                                                                    
                      """);
}