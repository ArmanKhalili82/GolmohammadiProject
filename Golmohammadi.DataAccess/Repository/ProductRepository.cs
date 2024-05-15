using Golmohammadi.Models.Models.Product;
using GolmohammadiProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Golmohammadi.DataAccess.Repository
{
    public class ProductRepository : Repository<Products>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Products product)
        {
            _db.Products.Update(product);
        }
    }
}
