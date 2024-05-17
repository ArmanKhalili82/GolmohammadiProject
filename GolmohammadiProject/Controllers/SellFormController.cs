using Golmohammadi.Models.Models.Factor;
using GolMohammadi.Business.SellFormService;
using Microsoft.AspNetCore.Mvc;

namespace GolmohammadiProject.Controllers
{
    public class SellFormController : Controller
    {
        private ISellFormService _sellFormService;

        public SellFormController(ISellFormService sellFormService)
        {
            _sellFormService = sellFormService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSellForms()
        {
            List<SellForm> sellForms = await _sellFormService.GetAllSellForm();
            return View(sellForms);
        }

        [HttpGet]
        public IActionResult CreateSellForm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSellForms(SellForm sellForm)
        {
            await _sellFormService.Create(sellForm);
            return RedirectToAction("GetSellForms");
        }

        [HttpGet]
        public async Task<IActionResult> EditSellForm(int id)
        {
            var sellForm = await _sellFormService.GetById(id);
            return View(sellForm);
        }

        [HttpPost]
        public async Task<IActionResult> EditSellForm(SellForm sellForm)
        {
            await _sellFormService.Update(sellForm);
            return RedirectToAction("GetSellForms");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteSellForm(int id)
        {
            var sellForm = await _sellFormService.GetById(id);
            return View(sellForm);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSellForms(int id)
        {
            await _sellFormService.Delete(id);
            return RedirectToAction("GetSellForms");
        }
    }
}
