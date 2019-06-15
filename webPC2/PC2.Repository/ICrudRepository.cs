using System.Collections.Generic;
using System;

namespace PC2.Repository
{
    public interface ICrudRepository<T>
    {
        void Delete(T entity);
        void Save(T entity);
        void Update(T entity);
        T FindById(T entity);
        List<T> ListAll();
    }
}
