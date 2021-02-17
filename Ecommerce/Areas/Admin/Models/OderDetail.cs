using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Admin.Models
{
    public class OderDetail
    {
       
        public int Id { get; set; }
        
       
        public int Quantity { get; set; }
        public decimal price { get; set; }
        public int OderId { get; set; }
        [ForeignKey("OderId")]
        public Oder oder { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product product { get; set; }
    }
}
