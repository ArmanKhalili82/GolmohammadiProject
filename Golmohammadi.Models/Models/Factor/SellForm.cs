using Golmohammadi.Models.Models.Customer;
using Golmohammadi.Models.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golmohammadi.Models.Models.Factor
{
    public class SellForm
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public List<Products> Products { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customers customer { get; set; }
        public int Unit { get; set; }
        public int TotalPrice { get; set; }
        public int TransportationPrice { get; set; }
        public int Tax { get; set; }
    }
}
