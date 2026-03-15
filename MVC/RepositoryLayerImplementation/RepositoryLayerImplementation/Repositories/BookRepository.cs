using RepositoryLayerImplementation.Data;
using RepositoryLayerImplementation.Models;
using RepositoryLayerImplementation.Repositories.Interfaces;
using RepositoryLayerImplementation.Data;
using RepositoryLayerImplementation.Models;
using RepositoryLayerImplementation.Repositories.Interfaces;

namespace RepositoryLayerImplementation.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext context;

        public BookRepository(AppDbContext db)
        {
            context = db;
        }

        public List<Book> ListAllBooks()
        {
            return context.Books.ToList();
        }

        public List<Book> ListByPrice(float price)
        {
            return context.Books
                          .Where(b => b.Price < price)
                          .ToList();
        }

        public int BookByName(string name)
        {
            return context.Books
                          .Count(b => b.FullName == name);
        }
    }
}