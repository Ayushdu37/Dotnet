using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services;

namespace ServiceLayer.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly CalculatorService _service;
        public CalculatorController(CalculatorService service) => _service = service;
        public IActionResult Add(int a, int b)
        {
            return Content("Result: " + _service.Add(a, b));
        }
        public IActionResult Subtract(int a, int b)
        {
            return Content("Result: " + _service.Subtract(a, b));
        }
        public IActionResult Multiply(int a, int b)
        {
            return Content("Result: " + _service.Multiply(a, b));
        }
        public IActionResult Divide(int a, int b)
        {
            return Content("Result: " + _service.Divide(a, b));
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
