using Golmohammadi.Models.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golmohammadi.DataAccess.Repository
{
    public interface IProductRepository: IRepository<Products>
    {
        void Update(Products product);
    }
}
