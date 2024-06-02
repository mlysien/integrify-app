using Integrify.Integrations.Orders.Api.Public;
using Integrify.Integrations.Orders.Core.Abstractions;

namespace Integrify.Integrations.Orders.Api;

internal sealed class OrdersIntegrationApi(IOrdersIntegrationProcess ordersIntegrationProcess) : IOrdersIntegrationApi
{
    public async Task RunIntegration()
    {
        await ordersIntegrationProcess.ExecuteIntegrationProcess();
    }
}