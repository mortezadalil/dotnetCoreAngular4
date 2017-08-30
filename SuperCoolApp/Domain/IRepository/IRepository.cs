
using System.Collections.Generic;

namespace SuperCoolApp.Domain.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Add(T entity);
        void Delete(T entity);
        //T GetById(int id);

    }
}
