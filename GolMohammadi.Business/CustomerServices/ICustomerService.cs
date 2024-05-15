using Golmohammadi.Models.Models.Customer;
using GolmohammadiProject.Models.Product;

namespace GolMohammadi.Business.CustomerServices
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomers();
        Task<Customer> GetById(int id);
        Task Create(Customer customer);
        Task Update(Customer customer);
        Task Delete(int customerId);
    }
}
