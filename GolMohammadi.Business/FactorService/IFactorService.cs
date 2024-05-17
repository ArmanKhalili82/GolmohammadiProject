using Golmohammadi.Models.Models.Factor;
using Golmohammadi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business.FactorService
{
    public interface IFactorService
    {
        Task<List<SellFactorViewModel>> GetAllFactors();
        Task<SellFactorViewModel> GetById(int id);
        Task<SellFactorViewModel> GetProduct(int id);
    }
}
