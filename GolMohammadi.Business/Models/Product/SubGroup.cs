using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolmohammadiProject.Models.Product;

public class SubGroup
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProductGroupId { get; set; }
    public ProductGroup ProductGroup { get; set; }
    public List<Product> Products { get; set;}
}
