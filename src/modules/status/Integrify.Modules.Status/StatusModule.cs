using System.Reflection;
using Integrify.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Status;

public class StatusModule: IModule
{
    public string Name => "Status";

    public Version? Version => new(0, 0, 1);

    public void Register(IServiceCollection services)
    {
        
    }

    public void Use(IApplicationBuilder app)
    {
        throw new NotImplementedException();
    }
}