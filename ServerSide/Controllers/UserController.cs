using Microsoft.AspNetCore.Mvc;
using ServerSide.Dto;
using ServerSide.Models;

namespace ServerSide.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly List<UserInfos> _users = new()
    {
        new (1,"Abraham",20,"male" ),
        new (2, "Atlas", 21 , "male"),
        new (3, "Reza" , 20 , "male"),
        new (4, "Javid", 21, "male"),
        new (5, "Ahmad", 30, "male")
    };

    [HttpPost]
    public IActionResult GetList()
    {
        return Ok(_users);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _users.FirstOrDefault(i => i.Id == id);
        if (user == null)
            NotFound();

        return Ok(user);
    }
    [HttpGet]
    public IActionResult SearchUser(int id)
    {
        var result = _users.Where(i => i.Id == id).ToList();
        return Ok(result);
    }

    [HttpPut]
    public IActionResult Put(int id, UserDto dto)
    {
        var user = _users.Find(i => i.Id == id);

        if (user is null)
            NotFound("Can't find a match row");

        user.UserName = dto.name;
        user.Age = dto.age;
        user.Gender = dto.gender;

        return Ok("Done");
    }
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var user = _users.Find(i => i.Id == id);

        if (user is null)
            return NotFound("Id not found");

        var removed = _users.Remove(user);
        if (removed == true)
            return Ok("User Remove Seccessfuly");
        else
            return BadRequest("Can't remove files");

    }
}
