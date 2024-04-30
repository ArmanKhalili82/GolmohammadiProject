using GolmohammadiProject.Data;
using GolmohammadiProject.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business;

public class Service
{
    private readonly ApplicationDbContext _context;
    public Service(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task CreateGroupPost()
    {
        var productGroupItem = new ProductGroup { Id = 1, Name = "Meat" };
        await _context.ProductGroups.AddAsync(productGroupItem);
    }

    public async Task CreateSubGroup()
    {
        var subGroupItem = new SubGroup { Id = 1, Name = "a", ProductGroupId = 1 };
        await _context.SubGroups.AddAsync(subGroupItem);
    }

    public async Task CreateProduct()
    {
        var productItem = new Product { Id = 1, Name = "b", SubGroupId = 1 };
        await _context.Products.AddAsync(productItem);
    }
}
