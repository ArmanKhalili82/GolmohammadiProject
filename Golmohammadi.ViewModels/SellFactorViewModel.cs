using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golmohammadi.ViewModels
{
    public class SellFactorViewModel
    {
        public CustomerViewModel Customer { get; set; }
        public ProductViewModel Product { get; set; }
        public int PriceUnit { get; set; }
        public int Unit { get; set; }
        public int TotalPrice { get; set; }
    }
}
