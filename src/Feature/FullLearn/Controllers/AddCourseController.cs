using FullLearn.Dto;
using FullLearn.Models;
using FullLearn.Option;
using FullLearn.Prestence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FullLearn.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddCourseController : ControllerBase
{
    private readonly Context _context;
    private readonly Config _config;

    public AddCourseController(IOptions<Config>config, Context context)
    {
        _context = context;
        _config = config.Value;
    }
    [HttpPost]
    public IActionResult TakeCourse([FromBody] CourseDto dto)
    {
        var result = new Courses
        {
            Name = dto.Name ,
            Description = dto.Description ??= _config.DefaultValue ,
        };
        _context.Courses.Add(result);
        _context.SaveChanges();

        return Ok(result);
    }
}
