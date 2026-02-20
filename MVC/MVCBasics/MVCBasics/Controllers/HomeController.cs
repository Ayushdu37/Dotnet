using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using System.Diagnostics;

namespace MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Student()
        {
            var s = new { Name = "Ravi", Marks = 90 };
            return Json(s);
        }

        public IActionResult Square(int? number)
        {
            if (number == null) return Content("Please provide a number");
            return View(number.Value);
        }
        public IActionResult SumOfStudent(int m1, int m2, int m3)
        {
            int ans = m1 + m2 + m3;
            return View(ans);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
