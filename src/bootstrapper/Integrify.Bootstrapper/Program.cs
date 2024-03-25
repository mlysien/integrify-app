using Integrify.Shared.Abstractions.Modules;
using Integrify.Shared.Infrastructure;
using Integrify.Shared.Infrastructure.Logging;
using Integrify.Shared.Infrastructure.Modules;

var builder = WebApplication.CreateBuilder(args);
builder.Host
    .ConfigureModules()
    .UseLogging();

var assemblies = ModuleLoader.LoadAssemblies(builder.Configuration, "Integrify.Modules.");
var modules = ModuleLoader.LoadModules(assemblies);


builder.Services.AddModularInfrastructure(assemblies, modules);

foreach (var module in modules)
{
    module.Register(builder.Services);
}

var app = builder.Build();
PrintBanner();

foreach (var module in modules)
{
    app.Logger.LogInformation($"Module {module.Name} [v.{module.Version}] has been loaded");
}

app.UseModularInfrastructure();
app.Run();

return;

void PrintBanner()
{
    app.Logger.LogInformation("""
                              
                               _____ _   _ _______ ______ _____ _____  _____ ________     __
                              |_   _| \ | |__   __|  ____/ ____|  __ \|_   _|  ____\ \   / /
                                | | |  \| |  | |  | |__ | |  __| |__) | | | | |__   \ \_/ /
                                | | | . ` |  | |  |  __|| | |_ |  _  /  | | |  __|   \   /
                               _| |_| |\  |  | |  | |___| |__| | | \ \ _| |_| |       | |
                              |_____|_| \_|  |_|  |______\_____|_|  \_\_____|_|       |_|
                                                                                            
                              """);
}