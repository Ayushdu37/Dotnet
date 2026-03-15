using RepositoryLayerImplementation.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayerImplementation.Repositories.Interfaces;

namespace RepositoryLayerImplementation.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository repo;

        public BookController(IBookRepository repository)
        {
            repo = repository;
        }

        public IActionResult ListAllBooks()
        {
            var books = repo.ListAllBooks();

            List<string> result = new List<string>();

            foreach (var b in books)
            {
                result.Add($"{b.FullName} | {b.Author} | {b.Genre} | {b.Price}");
            }

            return Content(string.Join("\n", result));
        }

        public IActionResult ListByPrice(float price)
        {
            var books = repo.ListByPrice(price);

            List<string> result = new List<string>();

            foreach (var b in books)
            {
                result.Add($"{b.FullName} - {b.Price}");
            }

            return Content(string.Join("\n", result));
        }

        public IActionResult BookByName(string name)
        {
            int count = repo.BookByName(name);

            return Content($"Books with name '{name}' = {count}");
        }
    }
}