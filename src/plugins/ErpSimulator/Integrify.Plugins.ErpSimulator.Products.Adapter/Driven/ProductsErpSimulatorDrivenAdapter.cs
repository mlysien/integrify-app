using Integrify.Integrations.Products.Model;
using Integrify.Integrations.Products.Port.Driven;

namespace Integrify.Plugins.ErpSimulator.Products.Adapter.Driven;

public class ProductsErpSimulatorDrivenAdapter : IProductsIntegrationDrivenPort
{
    public Task PushAsync(ProductIntegrationModel integrationModel)
    {
        throw new NotImplementedException();
    }
}