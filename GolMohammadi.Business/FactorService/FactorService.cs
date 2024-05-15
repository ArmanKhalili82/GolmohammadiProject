using Golmohammadi.Models.Models.Customer;
using Golmohammadi.Models.Models.Factor;
using Golmohammadi.ViewModels;
using GolmohammadiProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business.FactorService
{
    public class FactorService
    {
        private readonly ApplicationDbContext _context;

        public FactorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SellForm>> GetAllFactors()
        {
            List<SellForm> factories = await _context.SellForms.ToListAsync();
            return factories;
        }

        public async Task<SellFactorViewModel> GetById(int id)
        {
            var form = await _context.SellForms.FirstOrDefaultAsync(x => x.Id == id);
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == form.CustomerId);
            var vm = new SellFactorViewModel()
            {
                Customer = new CustomerViewModel()
                {
                    Name = customer.Name
                }
            }
        }   
    }
}
