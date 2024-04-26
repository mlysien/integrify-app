using Integrify.Shared.Abstractions.Synchronizations;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Modules.Customers.Api;

public class CustomersModule : ISynchronizableModule
{
    private string _moduleName = string.Empty;
    private SynchronizationDirection _direction = null!;
    
    public string Name => _moduleName;
    
    public Version? Version => new(0, 0, 1);
    
    public SynchronizationDirection Direction => _direction;

    public void Register(IServiceCollection services)
    {
    }

    public void Use(IApplicationBuilder app)
    {
    }

    public void Configure(IConfigurationSection configuration)
    {
        var source = configuration.GetValue<SynchronizationSystems>("module:synchronization:source");
        var target = configuration.GetValue<SynchronizationSystems>("module:synchronization:target");
        
        _direction = new SynchronizationDirection(source, target);
        _moduleName = configuration["module:name"] ?? "Undefined";
    }
}