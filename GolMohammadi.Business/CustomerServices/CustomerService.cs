using Golmohammadi.Models.Models.Customer;
using GolmohammadiProject.Data;
using GolmohammadiProject.Models.Product;
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

        public async Task Create(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int customerId)
        {
            Customer obj = await _context.Customers.FindAsync(customerId);
            _context.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllCustomers()
        {
            List<Customer> customers = await _context.Customers.ToListAsync();
            return customers;
        }

        public async Task<Customer> GetById(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            return customer;
        }

        public async Task Update(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }
    }
}
