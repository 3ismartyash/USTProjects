using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "hi Hello";
        }

        [HttpGet]
        
        public string GetEmployee()
        {
            return "Hi I am yashuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu";
        }
    }
}
