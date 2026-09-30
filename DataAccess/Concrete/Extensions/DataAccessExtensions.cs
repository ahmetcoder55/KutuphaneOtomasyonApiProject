using DataAccess.Abstract.Repositories;
using DataAccess.Abstract.UnitOfWorks;
using DataAccess.Concrete.Data;
using DataAccess.Concrete.Repositories;
using DataAccess.Concrete.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Extensions
{
    public static class DataAccessExtensions
    {
        public static void ConfigureDatabase(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<KutuphaneContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
