using Golmohammadi.Models.Models.Customer;
using Golmohammadi.Models.Models.Factor;
using GolmohammadiProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business.FactorService
{
    public class FactorService: IFactorService
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

        public async Task<SellForm> GetById(int id)
        {
            var customer = await _context.SellForms.FirstOrDefaultAsync(x => x.CustomerId == id);
            return customer;
        }
    }
}
