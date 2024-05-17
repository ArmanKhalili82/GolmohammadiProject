using Golmohammadi.Models.Models.Factor;
using GolmohammadiProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business.SellFormService
{
    public class SellFormService : ISellFormService
    {
        private readonly ApplicationDbContext _context;

        public SellFormService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(SellForm sellForm)
        {
            await _context.SellForms.AddAsync(sellForm);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int sellFormId)
        {
            var obj = await _context.SellForms.FindAsync(sellFormId);
            _context.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SellForm>> GetAllSellForm()
        {
            List<SellForm> sellForms = await _context.SellForms.ToListAsync();
            return sellForms;
        }

        public async Task<SellForm> GetById(int id)
        {
            var sellForm = await _context.SellForms.FindAsync(id);
            return sellForm;
        }

        public async Task Update(SellForm sellForm)
        {
            _context.SellForms.Update(sellForm);
            await _context.SaveChangesAsync();
        }
    }
}
