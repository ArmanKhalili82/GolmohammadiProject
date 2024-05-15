using Golmohammadi.Models.Models.Customer;
using Golmohammadi.Models.Models.Factor;
using Golmohammadi.Models.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace GolmohammadiProject.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ProductGroup> ProductGroups { get; set; }
    public DbSet<SubGroup> SubGroups { get; set; }
    public DbSet<Products> Products { get; set; }
    public DbSet<Customers> Customers { get; set; }
    public DbSet<SellForm> SellForms { get; set; }
}
