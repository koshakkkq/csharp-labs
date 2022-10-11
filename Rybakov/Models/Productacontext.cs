using Rybakov.Models;
using System.Data.Entity;
namespace Rybakov.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Rybakov")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
