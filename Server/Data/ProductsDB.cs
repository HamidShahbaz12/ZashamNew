using Microsoft.EntityFrameworkCore;
using Zasham.Shared.Model;

namespace Zasham.Server.Data
{
    public class ProductsDB: DbContext
    {
        public ProductsDB(DbContextOptions<ProductsDB> options) : base(options) { }

  
        public DbSet<Customer> customers { get; set; }

  
        public DbSet<Zasham.Shared.Model.Product> Product { get; set; } = default!;

    }
}
