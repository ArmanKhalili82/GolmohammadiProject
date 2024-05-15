using Golmohammadi.Models.Models.Factor;
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
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubGroupId { get; set; }
        [JsonIgnore]
        public SubGroup SubGroup { get; set; }
        public List<SellForm> sellForms { get; set; }
    }
}
