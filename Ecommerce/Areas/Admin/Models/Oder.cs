using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Admin.Models
{
    public class Oder
    {
        [Key]
        public int Id { get; set; }
       
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "0:{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OderDate { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public bool Status { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OderDetail> oderDetails { get; set; }

    }
}
