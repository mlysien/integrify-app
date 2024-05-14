using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Abstractions.Integrations;

public interface IIntegration
{
    void Register(IServiceCollection serviceCollection);
}