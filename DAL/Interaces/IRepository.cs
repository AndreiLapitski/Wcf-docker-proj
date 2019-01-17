using System.Collections.Generic;

namespace DAL.Interaces
{
    public interface IRepository<T>
    {
        int Create(T obj);
        void Delete(int id);
        void Update(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
