using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GolmohammadiProject.Models.Product;

public class SubGroup
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProductGroupId { get; set; }
    [JsonIgnore]
    public ProductGroup ProductGroup { get; set; }
    [JsonIgnore]
    public List<Product> Products { get; set;}
}
