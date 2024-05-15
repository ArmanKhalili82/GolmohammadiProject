using GolmohammadiProject.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golmohammadi.Models.Models.Factor
{
    public class SellForm
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public List<Product> Products { get; set; }
        public int Unit { get; set; }
        public int TotalPrice { get; set; }
        public int TransportationPrice { get; set; }
        public int Tax { get; set; }
    }
}
