using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Admin.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [StringLength(maximumLength:30,ErrorMessage ="UserName không dưới 5 ký tự và nhiều hơn 30 ký tự", MinimumLength =5),Required]
        [Column(TypeName ="varchar(30)")]
     
        public string Password { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public bool Status { get; set; }
        [Required]
        public string Gmail { get; set; }

        public int Rule { get; set; }

        public ICollection<Oder> oders { get; set; }

    }
}
