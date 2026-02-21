using Microsoft.AspNetCore.Mvc;

namespace Controller2Controller.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            var a = (int)TempData["a"];
            var b = (int)TempData["b"];

            var result = a + b;
            return Content(result.ToString());
        }
        public IActionResult Square()
        {
            var a = (int)TempData["number"];

            var square = a * a;
            return Content(square.ToString());
        }
    }
}
