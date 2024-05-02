﻿using GolmohammadiProject.Data;
using GolmohammadiProject.Models.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business;

public class Service : IService
{
    private readonly ApplicationDbContext _context;
    public Service(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Create(Product product)
    {
        var subGroup = await _context.SubGroups.FindAsync(product.SubGroupId);
        if (subGroup != null)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        //return await GetSubGroups(product.SubGroupId);
        //var productGroupObject = await _context.ProductGroups.FindAsync(subGroup.ProductGroupId);
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SubGroup> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<SubGroup>> GetSubGroups(int productGroupId)
    {
        var products = await _context.SubGroups
            .Where(x => x.ProductGroupId == productGroupId)
            .Include(x => x.Products)
            .ToListAsync();
        return products;
    }

    public async Task Update(SubGroup subGroup)
    {
        _context.SubGroups.Update(subGroup);
        await _context.SaveChangesAsync();
    }

    //public async Task CreateProduct(Product product)
    //{
    //    await _context.Products.AddAsync(product);
    //    await _context.SaveChangesAsync();
    //}

    //public async Task CreateProductGroup(ProductGroup productGroup)
    //{
    //    await _context.ProductGroups.AddAsync(productGroup);
    //    await _context.SaveChangesAsync();
    //}

    //public async Task CreateSubGroup(SubGroup subGroup)
    //{
    //    await _context.SubGroups.AddAsync(subGroup);
    //    await _context.SaveChangesAsync();
    //}

    //public void Delete(int id)
    //{
    //    _context.Products.Find(id);
    //}

    //public async Task DeleteEditProductGroup(int id)
    //{
    //    ProductGroup obj = await _context.ProductGroups.FindAsync(id);
    //    _context.ProductGroups.Remove(obj);
    //    await _context.SaveChangesAsync();
    //}

    //public async Task DeleteProduct(int id)
    //{
    //    Product obj = await _context.Products.FindAsync(id);
    //    _context.Products.Remove(obj);
    //    await _context.SaveChangesAsync();
    //}

    //public async Task DeleteSubGroup(int id)
    //{
    //    SubGroup obj = await _context.SubGroups.FindAsync(id);
    //    _context.SubGroups.Remove(obj);
    //    await _context.SaveChangesAsync();
    //}

    //public void Edit(int id)
    //{
    //    _context.Products.Find(id);
    //}

    //public async Task EditProduct(Product product)
    //{
    //    _context.Products.Update(product);
    //    await _context.SaveChangesAsync();
    //}

    //public async Task EditProductGroup(ProductGroup productGroup)
    //{
    //    _context.ProductGroups.Update(productGroup);
    //    await _context.SaveChangesAsync();
    //}

    //public async Task EditSubGroup(SubGroup subGroup)
    //{
    //    _context.SubGroups.Update(subGroup);
    //    await _context.SaveChangesAsync();
    //}

    //public async Task<List<Product>> GetAllProduct()
    //{
    //    List<Product> objProduct = await _context.Products.ToListAsync();
    //    return objProduct;
    //}

    //public async Task<List<ProductGroup>> GetAllProductGroup()
    //{
    //    List<ProductGroup> objProductGroup = await _context.ProductGroups.Include(x => x.subGroups).ToListAsync();
    //    return objProductGroup;
    //}

    //public async Task<List<SubGroup>> GetAllSubGroup(int id)
    //{
    //    List<SubGroup> objSubGroup = await _context.SubGroups.Where(x => x.ProductGroupId = id).ToListAsync();
    //    return objSubGroup;
    //}

    //public async Task CallAllAddMethods(ProductGroup productGroup, SubGroup subGroup, Product product)
    //{
    //    await CreateProductGroup(productGroup);
    //    await CreateSubGroup(subGroup);
    //    await CreateProduct(product);
    //}
}
