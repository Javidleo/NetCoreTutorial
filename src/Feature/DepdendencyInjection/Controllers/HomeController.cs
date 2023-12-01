using DepdendencyInjection.Dto;
using DepdendencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DepdendencyInjection.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly IUserService _userService;

    public HomeController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public IActionResult Post([FromBody] UserDto dto)
    {
        var result = _userService.AddUser(dto.name, dto.password);

        return Ok(result);
    }
}
