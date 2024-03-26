using System.Reflection;
using Integrify.Shared.Abstractions.Modules;
using Integrify.Shared.Infrastructure;
using Integrify.Shared.Infrastructure.Contracts;
using Integrify.Shared.Infrastructure.Modules;

namespace Integrify.Bootstrapper;

public class Startup
{
    private readonly IList<Assembly> _assemblies;
    private readonly IList<IModule> _modules;

    public Startup(IConfiguration configuration)
    {
        _assemblies = ModuleLoader.LoadAssemblies(configuration, "Integrify.Modules.");
        _modules = ModuleLoader.LoadModules(_assemblies);
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddModularInfrastructure(_assemblies, _modules);
        foreach (var module in _modules)
        {
            module.Register(services);
        }
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
    {
        logger.PrintBanner();
        logger.LogInformation($"Modules: {string.Join(", ", _modules.Select(x => $"{x.Name} ({x.Version})"))}");
        app.UseModularInfrastructure();
        foreach (var module in _modules)
        {
            module.Use(app);
        }

        app.ValidateContracts(_assemblies);
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapModuleInfo();
        });

        _assemblies.Clear();
        _modules.Clear();
    }
}