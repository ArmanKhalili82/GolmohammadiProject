using Golmohammadi.Models.Models.Customer;
using GolMohammadi.Business.CustomerServices;
using GolMohammadi.Business.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace GolmohammadiProject.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            List<Customers> customers = await _customerService.GetAllCustomers();
            return View(customers);
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customers customer)
        {
            await _customerService.Create(customer);
            return RedirectToAction("GetCustomers");
        }

        [HttpGet]
        public async Task<IActionResult> EditCustomer(int id)
        {
            var customer = await _customerService.GetById(id);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> EditCustomer(Customers customer)
        {
            await _customerService.Update(customer);
            return RedirectToAction("GetCustomers");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _customerService.GetById(id);
            return View(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _customerService.Delete(id);
            return RedirectToAction("GetCustomers");
        }
    }
}
