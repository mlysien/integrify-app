using Integrify.Integrations.Products.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Integrations.Products.Api.Controllers;

[ApiController]
[Tags("Products Integration")]
[Route("[controller]/[action]")]
public class ProductsIntegrationController(IProductsIntegration productsIntegration) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin products integration process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult> Synchronize()
    {
        await productsIntegration.RunIntegration();
        
        return Ok();
    }
}