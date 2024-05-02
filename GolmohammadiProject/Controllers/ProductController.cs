using GolMohammadi.Business;
using GolmohammadiProject.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace GolmohammadiProject.Controllers;

public class ProductController : Controller
{
    private IService _service;
    public ProductController(IService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        List<SubGroup> subGroups = await _service.SubGroups();
        return View(subGroups);
    }

    [HttpGet]
    public async Task<IActionResult> Products()
    {
        List<Product> products = await _service.products();
        return View(products);
    }



    //[HttpGet]
    //public async Task<IActionResult> GetAllProductGroup()
    //{
    //    List<ProductGroup> objProductGroup = await _service.GetAllProductGroup();
    //    return View(objProductGroup);
    //}

    //[HttpGet]
    //public async Task<IActionResult> GetAllSubGroup()
    //{
    //    List<SubGroup> objSubGroup = await _service.GetAllSubGroup();
    //    return View(objSubGroup);
    //}

    //[HttpGet]
    //public async Task<IActionResult> GetAllProduct()
    //{
    //    List<Product> objSubGroup = await _service.GetAllProduct();
    //    return View(objSubGroup);
    //}

    //[HttpPost]
    //public async Task<IActionResult> CreateProductGroup(ProductGroup productGroup)
    //{
    //    await _service.CreateProductGroup(productGroup);
    //    return View();
    //}

    //[HttpPost]
    //public async Task<IActionResult> CreateSubGroup(SubGroup subGroup)
    //{
    //    await _service.CreateSubGroup(subGroup);
    //    return View();
    //}

    //[HttpPost]
    //public async Task<IActionResult> CreateProduct(Product product)
    //{
    //    await _service.CreateProduct(product);
    //    return View();
    //}

    //[HttpPost]
    //public async Task<IActionResult> EditProductGroup(ProductGroup productGroup)
    //{
    //    await _service.EditProductGroup(productGroup);
    //    return Ok(productGroup);
    //}

    //[HttpPost]
    //public async Task<IActionResult> EditSubGroup(SubGroup subGroup)
    //{
    //    await _service.EditSubGroup(subGroup);
    //    return Ok(subGroup);
    //}

    //[HttpPost]
    //public async Task<IActionResult> EditProduct(Product product)
    //{
    //    await _service.EditProduct(product);
    //    return Ok(product);
    //}

    //[HttpPost]
    //public async Task<IActionResult> CallAllAddMethods(ProductGroup productGroup, SubGroup subGroup, Product product)
    //{
    //    await _service.CallAllAddMethods(productGroup, subGroup, product);
    //    return Ok(productGroup);
    //}

    //[HttpGet]
    //public IActionResult Create()
    //{
    //    return View();
    //}

    //[HttpPost]
    //public async Task<IActionResult> DeleteProductGroup(int id)
    //{
    //    await _service.DeleteEditProductGroup(id);
    //    return Ok();
    //}

    //[HttpPost]
    //public async Task<IActionResult> DeleteSubGroup(int id)
    //{
    //    await _service.DeleteSubGroup(id);
    //    return Ok();
    //}

    //[HttpPost]
    //public async Task<IActionResult> DeleteProduct(int id)
    //{
    //    await _service.DeleteProduct(id);
    //    return Ok();
    //}
}
