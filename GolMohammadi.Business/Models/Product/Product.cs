using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GolmohammadiProject.Models.Product;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public int SubGroupId { get; set; }
    [JsonIgnore]
    public SubGroup SubGroup { get; set; }
}
