using Microsoft.EntityFrameworkCore;
using ProductSaleModel.Model;

namespace ProductSaleRepository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        DbSet<Customer> Customers { get; set; }
        DbSet<Product> Products { get; set; }

    }
}
