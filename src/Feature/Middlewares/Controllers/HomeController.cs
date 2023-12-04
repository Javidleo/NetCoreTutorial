using Microsoft.AspNetCore.Mvc;

namespace Middlewares.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post()
    {
        throw new Exception();
    }
}
