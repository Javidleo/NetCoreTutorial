using DepdendencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DepdendencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestControllerForDI : ControllerBase
    {

        private readonly IDependency _depdendency;
        public TestControllerForDI(IDependency depdendency)
        {
            _depdendency = depdendency;
        }

        [HttpGet]
        public IActionResult Name()
        {
            var test = _depdendency.Test("Javid");
            return Ok(test);
        }
    }
}
