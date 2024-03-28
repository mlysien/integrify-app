using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Contracts;

public static class Extensions
{
    public static void AddContracts(this IServiceCollection services)
    {
        services.AddSingleton<IContractRegistry, ContractRegistry>();
    }
        
    public static IApplicationBuilder ValidateContracts(this IApplicationBuilder app, IEnumerable<Assembly> assemblies)
    {
        var contractRegistry = app.ApplicationServices.GetRequiredService<IContractRegistry>();
        contractRegistry.Validate(assemblies);
            
        return app;
    }
        
    public static IContractRegistry UseContracts(this IApplicationBuilder app)
        => app.ApplicationServices.GetRequiredService<IContractRegistry>();
}