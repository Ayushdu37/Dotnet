using Controller2Controller.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Controller2Controller.Controllers
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
        public IActionResult Send()
        {
            // TempData =  Controller <-> Controller
            TempData["a"] = 10;
            TempData["b"] = 10;

            return RedirectToAction("Add", "Student");
        }
        public IActionResult SendSquare(int? number)
        {
            TempData["number"] = number;

            return RedirectToAction("Square", "Student");
        }
        public IActionResult MyName()
        {
            ViewBag.Name = "Ayush";
            ViewData["College"] = "LPU";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
