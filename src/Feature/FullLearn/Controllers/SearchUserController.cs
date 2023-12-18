using FullLearn.Option;
using FullLearn.Prestence;
using FullLearn.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullLearn.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SearchUserController : ControllerBase
{
    private readonly Context _context;
    private readonly IDiServeses _serveses;
    public SearchUserController(Context context , IDiServeses serveses)
    {
        _context = context;
        _serveses = serveses;
    }

    [HttpGet("nameSearch")]
    public IActionResult GetByName(string name)
    {
        var result = _context.Persons
            .Where(x => x.Name == name)
            .ToList();
        if(result is null)
            return Ok ("No record FOUND");

        return Ok (result);
    }

    [HttpGet("GetByNameAndAge")]
    public IActionResult GetNameAndAge (string name , int age)
    {
        var result2 = _context.Persons
            .Where (x => x.Name == name && x.Age == age)
            .FirstOrDefault();
        if (result2 is null)
            return Ok("No record FOUND");

        return Ok(_serveses.ShowUser(result2.Name,result2.Age));
    }
}
