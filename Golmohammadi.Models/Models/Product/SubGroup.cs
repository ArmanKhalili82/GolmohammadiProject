using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Golmohammadi.Models.Models.Product
{
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
        public List<Products> Products { get; set; }
    }
}
