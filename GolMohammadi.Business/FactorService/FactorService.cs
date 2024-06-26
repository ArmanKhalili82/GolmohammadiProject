﻿using Golmohammadi.Models.Models.Customer;
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
    public class FactorService: IFactorService
    {
        private readonly ApplicationDbContext _context;

        public FactorService(ApplicationDbContext context)
        {
            _context = context;
        }
        List<SellFactorViewModel> sellFactors = new List<SellFactorViewModel>();

        public void Create(SellFactorViewModel sellFactorViewModel)
        {
            sellFactors.Add(sellFactorViewModel);
        }

        public async Task<List<SellFactorViewModel>> GetAllFactors()
        {
            List<SellForm> factories = await _context.SellForms.ToListAsync();
            List<SellFactorViewModel> vm = new List<SellFactorViewModel>();
            foreach (var fact in factories)
            {
                vm.Add(new SellFactorViewModel()
                {
                    Unit = fact.Unit,
                    TotalPrice = fact.TotalPrice,
                    Product = new ProductViewModel()
                    {
                        Name = fact.Products[0].Name,
                    },
                    Customer = new CustomerViewModel()
                    {
                        Name = fact.customer.Name,
                        Address = fact.customer.Address,
                        Email = fact.customer.Email,
                        City = fact.customer.City,
                        Region = fact.customer.Region,
                        PostalCode = fact.customer.PostalCode,
                        NationalCode = fact.customer.NationalCode
                    },
                });
            }
            return vm;
        }

        public async Task<SellFactorViewModel> GetById(int id)
        {
            var form = await _context.SellForms.FirstOrDefaultAsync(x => x.Id == id);
            var customer = await _context.Customers.FirstOrDefaultAsync(x => x.Id == form.CustomerId);
            var vm = new SellFactorViewModel()
            {
                Customer = new CustomerViewModel()
                {
                    Name = customer.Name,
                    Address = customer.Address,
                    Email = customer.Email,
                    City = customer.City,
                    Region = customer.Region,
                    PostalCode = customer.PostalCode,
                    NationalCode = customer.NationalCode
                }
            };
            return vm;
        }
        
        public async Task<SellFactorViewModel> GetProduct(int id)
        {
            var form = await _context.SellForms.FirstOrDefaultAsync(x => x.Id == id);
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == form.ProductId);
            var vm = new SellFactorViewModel()
            {
                Product = new ProductViewModel()
                {
                    Name = product.Name
                }
            };
            return vm;
        }
    }
}
