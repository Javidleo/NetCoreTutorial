using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullLearn.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ErrorController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> post()
    {
        throw new Exception();
    }
}
