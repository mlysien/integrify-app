using Integrify.Modules.Synchronizer.Core;
using Integrify.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Synchronizer.Api;

public class SynchronizerModule : IModule
{
    private string _moduleName = string.Empty;
    
    public string Name => _moduleName;
    
    public void Register(IServiceCollection servicesCollection)
    {
    }

    public void Use(IApplicationBuilder applicationBuilder)
    {
        applicationBuilder.UseCoreLayer();
    }

    public void Configure(IConfigurationSection configurationSection)
    {
        _moduleName = configurationSection["module:name"] ?? "Undefined";
    }
}