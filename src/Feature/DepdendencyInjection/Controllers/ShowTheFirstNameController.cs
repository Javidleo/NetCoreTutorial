using DepdendencyInjection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DepdendencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTheFirstNameController : ControllerBase
    {
        private readonly IShowFamilyName _showFamilyName;

        public ShowTheFirstNameController(IShowFamilyName showFamilyName)
        {
            _showFamilyName = showFamilyName;
        }
           
         
         
         


        [HttpGet]
        public IActionResult FName(string fitstName)
        {
            var result = _showFamilyName.Id(fitstName);
            return Ok(result);
        }
    }

    
}
