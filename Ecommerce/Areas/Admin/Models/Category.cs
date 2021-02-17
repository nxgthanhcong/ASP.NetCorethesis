using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Admin.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(255)"),Required]
        public string Name { get; set; }
        public bool Status { get; set; }
        public ICollection<Product> products { get; set; }

    }
}
