namespace GolmohammadiProject.Models.Product;

public class SubGroup
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProductGroupId { get; set; }
    public ProductGroup ProductGroup { get; set; }
    public List<Product> Products { get; set;}
}
