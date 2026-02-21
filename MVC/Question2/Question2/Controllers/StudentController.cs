using Microsoft.AspNetCore.Mvc;
using Question2.Models;

namespace Question2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student
            {
                Name = "Ayush",
                Age = 5
            };
            return View(student);
        }
    }
}
