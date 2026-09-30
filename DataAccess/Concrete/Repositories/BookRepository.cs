using DataAccess.Abstract.Repositories;
using DataAccess.Concrete.Data;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Repositories
{
    public class BookRepository : GenericRepository<Book, KutuphaneContext>, IBookRepository
    {
        public BookRepository(KutuphaneContext context) : base(context)
        {
        }
    }
}
