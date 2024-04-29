namespace GolmohammadiProject.Models.Product;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int SubGroupId { get; set; }
    public SubGroup SubGroup { get; set; }
}
