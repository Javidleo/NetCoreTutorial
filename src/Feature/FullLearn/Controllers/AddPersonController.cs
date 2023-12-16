﻿using FullLearn.Dto;
using FullLearn.Models;
using FullLearn.Option;
using FullLearn.Prestence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FullLearn.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AddPersonController : ControllerBase
{
    private readonly Context _context;
    private readonly Config _config;

    public AddPersonController(Context context,IOptions<Config> config)
    {
        _context = context;
        _config = config.Value;
    }
    [HttpPost]
    public IActionResult TakePerson([FromBody] PersonDto dto)
    {
        var person = new Person
        {
            Name = dto.Name,
            Age = dto.Age,
            Gender = dto.Gender,
            PhoneNumber = dto.Phone ??= _config.DefaultValue
        };
        _context.Persons.Add(person);
        _context.SaveChanges();

        return Ok(person);
    }
}
