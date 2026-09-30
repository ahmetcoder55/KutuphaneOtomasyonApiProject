using DataAccess.Abstract.Repositories;
using DataAccess.Abstract.UnitOfWorks;
using DataAccess.Concrete.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KutuphaneContext _context;

        private readonly IBookRepository _bookRepository;

        public UnitOfWork(KutuphaneContext context, IBookRepository bookRepository)
        {
            _context = context;
            _bookRepository = bookRepository;
        }

        public IBookRepository Book => _bookRepository;

        public async ValueTask DisposeAsync() => await _context.DisposeAsync();
      

        public async Task<int> SaveChangesAsync()
        {
           return await _context.SaveChangesAsync();
        }
      
    }
}
