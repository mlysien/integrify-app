using Integrify.Shared.Abstractions.Synchronizations;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Products.Api;

public class ProductsModule : ISynchronizableModule
{
    private string _moduleName = string.Empty;
    private SynchronizationDirection _direction = null!;
    
    public string Name => _moduleName;
    
    public SynchronizationDirection Direction => _direction;

    public void Register(IServiceCollection services)
    {
    }

    public void Use(IApplicationBuilder app)
    {
    }

    public void Configure(IConfigurationSection configuration)
    {
        var from = configuration.GetValue<SynchronizationSystems>("module:synchronization:from");
        var to = configuration.GetValue<SynchronizationSystems>("module:synchronization:to");
        
        _direction = new SynchronizationDirection(from, to);
        _moduleName = configuration["module:name"] ?? "Undefined";
    }
}