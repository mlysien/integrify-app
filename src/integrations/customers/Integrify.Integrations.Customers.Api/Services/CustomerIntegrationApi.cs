using Integrify.Integrations.Customers.Api.Public;
using Integrify.Integrations.Customers.Core.Services;

namespace Integrify.Integrations.Customers.Api.Services;

internal sealed class CustomerIntegrationApi(ICustomersIntegration customersIntegration) : ICustomersIntegrationApi
{
    public async Task RunIntegration()
    {
        await customersIntegration.RunCustomersIntegration();
    }
}