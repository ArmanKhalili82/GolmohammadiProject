using Golmohammadi.Models.Models.Customer;

namespace GolMohammadi.Business.CustomerServices
{
    public interface ICustomerService
    {
        Task<List<Customers>> GetAllCustomers();
        Task<Customers> GetById(int id);
        Task Create(Customers customer);
        Task Update(Customers customer);
        Task Delete(int customerId);
    }
}
