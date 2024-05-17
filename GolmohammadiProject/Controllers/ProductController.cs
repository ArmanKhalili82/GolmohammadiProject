using Golmohammadi.Models.Models.Product;
using GolMohammadi.Business.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace GolmohammadiProject.Controllers;

public class ProductController : Controller
{
    private IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        List<Products> products = await _productService.GetAllProducts();
        return View(products);
    }

    [HttpGet]
    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(Products product)
    {
        await _productService.Create(product);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> EditProduct(int id)
    {
        var product = await _productService.GetById(id);
        return View(product);
    }

    [HttpPost]
    public async Task<IActionResult> EditProduct(Products product)
    {
        await _productService.Update(product);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _productService.GetById(id);
        return View(product);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        await _productService.Delete(id);
        return RedirectToAction("Index");
    }


    [HttpGet]
    public async Task<IActionResult> GetSubGroups()
    {
        List<SubGroup> subGroups = await _productService.GetAllSubGroup();
        return View(subGroups);
    }

    [HttpGet]
    public IActionResult CreateSubGroup()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubGroup(SubGroup subGroup)
    {
        await _productService.CreateSubGroup(subGroup);
        return RedirectToAction("GetSubGroups");
    }

    [HttpGet]
    public async Task<IActionResult> EditSubGroup(int id)
    {
        var subGroup = await _productService.GetSubGroup(id);
        return View(subGroup);
    }

    [HttpPost]
    public async Task<IActionResult> EditSubGroup(SubGroup subGroup)
    {
        await _productService.UpdateSubGroup(subGroup);
        return RedirectToAction("GetSubGroups");
    }

    [HttpGet]
    public async Task<IActionResult> DeleteSubGroup(int id)
    {
        var subGroup = await _productService.GetSubGroup(id);
        return View(subGroup);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteSubGroups(int id)
    {
        await _productService.DeleteSubGroup(id);
        return RedirectToAction("GetSubGroups");
    }



    [HttpGet]
    public async Task<IActionResult> GetProductGroups()
    {
        List<ProductGroup> productGroups = await _productService.GetAllProductGroup();
        return View(productGroups);
    }

    [HttpGet]
    public IActionResult CreateProductGroup()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateProductGroup(ProductGroup productGroup)
    {
        await _productService.CreateProductGroup(productGroup);
        return RedirectToAction("GetProductGroups");
    }

    [HttpGet]
    public async Task<IActionResult> EditProductGroup(int id)
    {
        var productGroup = await _productService.GetProductGroup(id);
        return View(productGroup);
    }

    [HttpPost]
    public async Task<IActionResult> EditProductGroup(ProductGroup productGroup)
    {
        await _productService.UpdateProductGroup(productGroup);
        return RedirectToAction("GetProductGroups");
    }

    [HttpGet]
    public async Task<IActionResult> DeleteProductGroup(int id)
    {
        var productGroup = await _productService.GetProductGroup(id);
        return View(productGroup);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteProductGroups(int id)
    {
        await _productService.DeleteProductGroup(id);
        return RedirectToAction("GetProductGroups");
    }
}
