using Integrify.Integrations.Customers.Api.Public;
using Integrify.Integrations.Customers.Core.Abstractions;

namespace Integrify.Integrations.Customers.Api;

internal sealed class CustomerIntegrationApi(ICustomersIntegrationProcess customersIntegration) : ICustomersIntegrationApi
{
    public async Task RunIntegration()
    {
        await customersIntegration.ExecuteIntegrationProcess();
    }
}