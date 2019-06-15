using System.Collections.Generic;

namespace PC2.Service
{
    public interface ICrudService<T>
    {
        void Delete(T entity);
        void Save(T entity);
        void Update(T entity);
        T FindById(T entity);
        List<T> ListAll();
    }
}