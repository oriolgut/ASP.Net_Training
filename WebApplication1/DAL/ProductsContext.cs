using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}