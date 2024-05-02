using GolmohammadiProject.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace GolmohammadiProject.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ProductGroup> ProductGroups { get; set; }
    public DbSet<SubGroup> SubGroups { get; set; }
    public DbSet<Product> Products { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<ProductGroup>().HasData(
    //        new ProductGroup {Id = 1, Name = "Meat" },
    //        new ProductGroup { Id = 2, Name = "Meat1" },
    //        new ProductGroup { Id = 3, Name = "Meat2" });

    //    modelBuilder.Entity<SubGroup>().HasData(
    //        new SubGroup { Id = 1, Name = "a", ProductGroupId = 1},
    //        new SubGroup { Id = 2, Name = "a1", ProductGroupId = 2 },
    //        new SubGroup { Id = 3, Name = "a2", ProductGroupId = 3 },
    //        new SubGroup { Id = 4, Name = "b", ProductGroupId = 1 },
    //        new SubGroup { Id = 5, Name = "b1", ProductGroupId = 2 },
    //        new SubGroup { Id = 4, Name = "b2", ProductGroupId = 3 });

    //    modelBuilder.Entity<Product>().HasData(
    //        new Product { Id = 1, Name = "aa", SubGroupId = 1},
    //        new Product { Id = 2, Name = "aa1", SubGroupId = 2 },
    //        new Product { Id = 3, Name = "aa2", SubGroupId = 3 },
    //        new Product { Id = 4, Name = "aa3", SubGroupId = 4 },
    //        new Product { Id = 5, Name = "aa4", SubGroupId = 5 },
    //        new Product { Id = 6, Name = "aa5", SubGroupId = 6 });
    //}
}
