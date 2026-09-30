using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Data
{
    public class KutuphaneContext:DbContext
    {
        public KutuphaneContext(DbContextOptions<KutuphaneContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Book> Books { get; set; }
    }
}
