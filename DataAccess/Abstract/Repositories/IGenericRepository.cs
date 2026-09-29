using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.Repositories
{
    public interface IGenericRepository<T> where T:class,IEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);

        // Delegate (Predicate) içeren async metod
        Task<List<T>> FindAsync(Predicate<T> match);

    }
}
