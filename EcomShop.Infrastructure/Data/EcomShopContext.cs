using EcomShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomShop.Infrastructure.Data
{
    public class EcomShopContext : DbContext
    {
        public EcomShopContext(DbContextOptions<EcomShopContext> options) : base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Cấu hình kết nối SQL Server trong options
            var connectionString = "Your_SQLServer_ConnectionString_here";

            services.AddDbContext<EcomShopContext>(options =>
                options.UseSqlServer(connectionString)
            );

            // Các cấu hình và dịch vụ khác
        }
    }
}
