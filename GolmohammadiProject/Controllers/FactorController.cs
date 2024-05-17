using Golmohammadi.ViewModels;
using GolMohammadi.Business.FactorService;
using Microsoft.AspNetCore.Mvc;

namespace GolmohammadiProject.Controllers
{
    public class FactorController : Controller
    {
        private IFactorService _factorService;

        public FactorController(IFactorService factorService)
        {
            _factorService = factorService;
        }

        [HttpGet]
        public async Task<IActionResult> Factor()
        {
            var AllItem = await _factorService.GetAllFactors();
            return View(AllItem);
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await _factorService.GetById(id);
            return View(customer);
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _factorService.GetProduct(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(SellFactorViewModel sellFactorViewModel)
        {
            _factorService.Create(sellFactorViewModel);
            return Json("Factor Added");
        }
    }
}
