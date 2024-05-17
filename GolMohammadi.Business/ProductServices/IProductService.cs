using Golmohammadi.Models.Models.Product;
using System.Threading.Tasks;

namespace GolMohammadi.Business.ProductServices;

public interface IProductService
{
    Task<List<Products>> GetAllProducts();
    Task<Products> GetById(int id);
    Task Create(Products product);
    Task Update(Products product);
    Task Delete(int productId);

    Task<List<SubGroup>> GetAllSubGroup();
    Task<SubGroup> GetSubGroup(int id);
    Task CreateSubGroup(SubGroup subGroup);
    Task UpdateSubGroup(SubGroup subGroup);
    Task DeleteSubGroup(int subGroupId);

    Task<List<ProductGroup>> GetAllProductGroup();
    Task<ProductGroup> GetProductGroup(int id);
    Task CreateProductGroup(ProductGroup productGroup);
    Task UpdateProductGroup(ProductGroup productGroup);
    Task DeleteProductGroup(int productGroupId);
}
