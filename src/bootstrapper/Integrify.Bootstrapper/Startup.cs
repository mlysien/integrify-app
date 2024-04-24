using System.Reflection;
using Integrify.Shared.Abstractions.Modules;
using Integrify.Shared.Abstractions.Plugins;
using Integrify.Shared.Infrastructure;
using Integrify.Shared.Infrastructure.Contracts;
using Integrify.Shared.Infrastructure.Modules;

namespace Integrify.Bootstrapper;

public class Startup
{
    private readonly IList<Assembly> _modulesAssemblies;
    private readonly IList<Assembly> _pluginsAssemblies;
    private readonly IList<IModule> _modules;
    private readonly IList<IPlugin> _plugins;

    public Startup(IConfiguration configuration)
    {
        _modulesAssemblies = ModuleLoader.LoadModulesAssemblies(configuration, "Integrify.Modules.");
        _pluginsAssemblies = ModuleLoader.LoadPluginsAssemblies(configuration, "Integrify.Plugins.");
        _modules = ModuleLoader.LoadModules(_modulesAssemblies);
        _plugins = ModuleLoader.LoadPlugins(_pluginsAssemblies);
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddModularInfrastructure(_modulesAssemblies, _modules);
        
        foreach (var module in _modules)
        {
            module.Register(services);
        }
        
        foreach (var plugin in _plugins)
        {
            plugin.Register(services);
        }
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
    {
        logger.PrintBanner();
        logger.PrintHeader("Modules");
        
        foreach (var module in _modules)
        {
            logger.LogInformation("Module {0}, version: {1} loaded", module.Name, module.Version);
            module.Use(app);
        }
        
        logger.PrintHeader("Plugins");
        
        foreach (var plugin in _plugins)
        {
            logger.LogInformation($"Plugin '{plugin.Name}' attached as {plugin.Type.ToString().ToLower()} plugin");
            plugin.Use(app);
        }
        
        app.UseModularInfrastructure();
        app.ValidateContracts(_modulesAssemblies);
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapModuleInfo();
        });

        _modulesAssemblies.Clear();
        _pluginsAssemblies.Clear();
        _modules.Clear();
        _plugins.Clear();
    }
}