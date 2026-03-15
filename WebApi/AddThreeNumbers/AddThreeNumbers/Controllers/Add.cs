using Microsoft.AspNetCore.Mvc;

namespace AddThreeNumbers.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class Add : Controller
    {
        [HttpPost]
        public IActionResult AddNum(int a, int b, int c)
        {
            int result = a + b + c;
            return Ok(result);
        }
    }
}
