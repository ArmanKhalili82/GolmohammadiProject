using GolmohammadiProject.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolMohammadi.Business;

public interface IService
{
    Task<List<SubGroup>> GetSubGroups(int productGroupId);
    Task Create(Product product);
    Task<SubGroup> GetById(int id);
    Task Update(SubGroup subGroup);
    Task Delete(int id);
    Task<List<Product>> products();
    Task<List<SubGroup>> SubGroups();
    //Task<List<ProductGroup>> GetAllProductGroup();
    //Task<List<SubGroup>> GetAllSubGroup(int id);
    //Task<List<Product>> GetAllProduct();
    //Task CreateProductGroup (ProductGroup productGroup);
    //Task CreateSubGroup (SubGroup subGroup);
    //Task CreateProduct(Product product);
    //Task EditProductGroup(ProductGroup productGroup);
    //Task EditSubGroup(SubGroup subGroup);
    //Task EditProduct(Product product);
    //void Edit(int id);
    //void Delete(int id);
    //Task DeleteEditProductGroup(int id);
    //Task DeleteSubGroup(int id);
    //Task DeleteProduct(int id);
    //Task CallAllAddMethods(ProductGroup productGroup, SubGroup subGroup, Product product);
}
