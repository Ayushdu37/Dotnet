using RepositoryLayerImplementation.Models;

namespace RepositoryLayerImplementation.Repositories.Interfaces
{
    public interface IBookRepository
    {
        List<Book> ListAllBooks();

        List<Book> ListByPrice(float price);

        int BookByName(string name);
    }
}
