using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly List<UserInfo> _users = new()
    {
        new(1,"ali","rezaie"),
        new(2,"ali","mohaammaid"),
        new(3,"ali","navidi"),
        new(4,"ali","ahmadi"),
        new(5,"ali","hasani"),
    };

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(_users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _users.Where(i => i.Id == id).FirstOrDefault();
        if (user is null)
            return NotFound();

        return Ok(user);
    }
}
