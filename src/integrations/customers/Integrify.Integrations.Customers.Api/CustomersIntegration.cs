using Integrify.Integrations.Customers.Core;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Customers.Api;

internal sealed class CustomersIntegration : IIntegration
{
    public void AddIntegrationDependencies(IServiceCollection serviceCollection)
    {
        serviceCollection.AddIntegrationCoreLayer();
    }
}