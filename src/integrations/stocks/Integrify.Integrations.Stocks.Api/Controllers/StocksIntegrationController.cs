using Integrify.Integrations.Stocks.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Integrations.Stocks.Api.Controllers;

[ApiController]
[Tags("Stocks Integration")]
[Route("[controller]/[action]")]
public class StocksIntegrationController(IStocksIntegration stocksIntegration) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin stocks integration process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult> Synchronize()
    {
        await stocksIntegration.RunIntegration();
        
        return Ok();
    }
}