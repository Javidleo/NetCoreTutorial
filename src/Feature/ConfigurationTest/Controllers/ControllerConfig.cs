using ConfigurationTest.Option;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConfigurationTest.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ControllerConfig : ControllerBase
{
    private readonly Configuration _configuration;

    public ControllerConfig(Configuration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult ConfigTest()
    {
        return Ok(_configuration.Name);
    }
}
