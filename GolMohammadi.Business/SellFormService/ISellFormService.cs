using Golmohammadi.Models.Models.Factor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business.SellFormService
{
    public interface ISellFormService
    {
        Task<List<SellForm>> GetAllSellForm();
        Task<SellForm> GetById(int id);
        Task Create(SellForm sellForm);
        Task Update(SellForm sellForm);
        Task Delete(int sellFormId);
    }
}
