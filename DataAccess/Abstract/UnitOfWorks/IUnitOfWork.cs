using DataAccess.Abstract.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.UnitOfWorks
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        public IBookRepository Book { get; }

        Task<int> SaveChangesAsync();
    }
}
