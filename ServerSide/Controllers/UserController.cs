using Microsoft.AspNetCore.Mvc;
using ServerSide.Models;

namespace ServerSide.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly List<UserInfos> _user = new()
    {
        new (1,"Abraham",20,"male" ),
        new (2, "Atlas", 21 , "male"),
        new (3, "Reza" , 20 , "male"),
        new (4, "Javid", 21, "male"),
        new (5, "Ahmad", 30, "male")
    };

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(_user);
    }

    [HttpGet("SearchUser")]
    public IActionResult GetById(int id)
    {
        var user = _user.Where(i => i.Id == id)
            .ToList();
        if (user == null)
            NotFound();

        return Ok(user);
    }
}
