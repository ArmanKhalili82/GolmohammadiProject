using Golmohammadi.Models.Models.Factor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business.FactorService
{
    public interface IFactorService
    {
        Task<List<SellForm>> GetAllFactors();
        Task<SellForm> GetById(int id);
    }
}
