using Microsoft.AspNetCore.Mvc;
using NETCoreTutorial.Services;

namespace NETCoreTutorial.Controllers;

public class User
{
    public string Name { get; set; }
    public string Family { get; set; }
}

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly IBusServices _busService;
    private readonly IMotorService _motorService;
    public HomeController(IBusServices busService, IMotorService motorService)
    {
        _busService = busService;
        _motorService = motorService;
    }

    private readonly new List<User> _users = new()
    {
        new(){ Name = "reza", Family = "javid"},
        new(){ Name = "reza", Family = "javid"},
        new(){ Name = "reza", Family = "javid"},
        new(){ Name = "reza", Family = "javid"},
        new(){ Name = "mehdi", Family = "ehsan"},
        new(){ Name = "mehdi", Family = "ehsan"},
        new(){ Name = "mehdi", Family = "ehsan"},
        new(){ Name = "mehdi", Family = "ehsan"},
        new(){ Name = "ahmad", Family = "rezaie"},
        new(){ Name = "ahmad", Family = "rezaie"},
        new(){ Name = "ahmad", Family = "rezaie"},
        new(){ Name = "ahmad", Family = "rezaie"},
    };
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[]
        {
            new {
                id = 1,
                name = "reza",
                family = "ebrahimi",
                age = 20
            },
            new {
                id = 2,
                name = "javid",
                family = "hassani",
                age = 21
            }
        });
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"id number : {id} is deleted ");
    }
    [HttpGet("pagedList")]
    public IActionResult GetByPagedList([FromQuery] int pageSize, [FromQuery] int pagenumber)
    {
        int skip = (pagenumber - 1) * pageSize;

        return Ok(_users.Skip(skip).Take(pageSize).ToList());
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync()
    {
        var result = await _busService.Test();
        var result2 = await _busService.Test2();

        _motorService.Test();
        return Ok(result);
    }

    [HttpPost("Reza")]
    public IActionResult Post1()
    {
        return Ok("its reza post");
    }

    [HttpPut]
    public IActionResult Put([FromBody] string name)
    {
        return Ok($"the previous name is {name} and now its reza");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        return Ok($"the id {id} is now deleted");
    }
}
