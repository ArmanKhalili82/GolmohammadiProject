using Golmohammadi.Models.Models.Product;
using GolmohammadiProject.Data;
using Microsoft.EntityFrameworkCore;

namespace GolMohammadi.Business.ProductServices;

public class ProductService : IProductService
{
    private readonly ApplicationDbContext _context;
    public ProductService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Create(Products product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }

    public async Task CreateProductGroup(ProductGroup productGroup)
    {
        await _context.ProductGroups.AddAsync(productGroup);
        await _context.SaveChangesAsync();
    }

    public async Task CreateSubGroup(SubGroup subGroup)
    {
        await _context.SubGroups.AddAsync(subGroup);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int productId)
    {
        var obj = await _context.Products.FindAsync(productId);
        _context.Remove(obj);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductGroup(int productGroupId)
    {
        var obj = await _context.ProductGroups.FindAsync(productGroupId);
        _context.Remove(obj);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteSubGroup(int subGroupId)
    {
        var obj = await _context.SubGroups.FindAsync(subGroupId);
        _context.Remove(obj);
        await _context.SaveChangesAsync();
    }

    public async Task<List<ProductGroup>> GetAllProductGroup()
    {
        List<ProductGroup> productGroups = await _context.ProductGroups.ToListAsync();
        return productGroups;
    }

    public async Task<List<Products>> GetAllProducts()
    {
        List<Products> products = await _context.Products.ToListAsync();
        return products;
    }

    public async Task<List<SubGroup>> GetAllSubGroup()
    {
        List<SubGroup> subGroups = await _context.SubGroups.ToListAsync();
        return subGroups;
    }

    public async Task<Products> GetById(int id)
    {
        var product = await _context.Products.FindAsync(id);
        return product;
    }

    public async Task<ProductGroup> GetProductGroup(int id)
    {
        var productGroup = await _context.ProductGroups.FindAsync(id);
        return productGroup;
    }

    public async Task<SubGroup> GetSubGroup(int id)
    {
        var subGroup = await _context.SubGroups.FindAsync(id);
        return subGroup;
    }

    public async Task Update(Products product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductGroup(ProductGroup productGroup)
    {
        _context.ProductGroups.Update(productGroup);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateSubGroup(SubGroup subGroup)
    {
        _context.SubGroups.Update(subGroup);
        await _context.SaveChangesAsync();
    }
}
