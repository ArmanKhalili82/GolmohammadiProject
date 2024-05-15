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
}
