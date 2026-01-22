using System.Collections.Generic;

namespace PettyCashManager.Generics
{
    public interface IRepository<T>
    {
        void Add(T item);
        T? GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T item);
        void Remove(int id);
    }
}