using LazyLoadingThroughPagination.Data;
using Microsoft.AspNetCore.Mvc;

namespace LazyLoadingThroughPagination.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            int pageSize = 50;

            var students = _context.Students
                .OrderBy(s => s.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.Page = page;

            return View(students);
        }
    }
}