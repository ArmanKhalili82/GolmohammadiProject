using Golmohammadi.Models.Models.Customer;
using GolmohammadiProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business.CustomerServices
{
    public class CustomerService: ICustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Create(Customers customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int customerId)
        {
            Customers obj = await _context.Customers.FindAsync(customerId);
            _context.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customers>> GetAllCustomers()
        {
            List<Customers> customers = await _context.Customers.ToListAsync();
            return customers;
        }

        public async Task<Customers> GetById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            return customer;
        }

        public async Task Update(Customers customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }
    }
}
