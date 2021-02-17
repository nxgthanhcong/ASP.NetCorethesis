using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Admin.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(255)"), Required]
        public string Name { get; set; }
        [RegularExpression(@"^[0-9]{3}-[0-9]{3}-[0-9]{3}$")]
        public string SerialNumber { get; set; }
        [StringLength(255)]
        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }
        [StringLength(255)]
        [Column(TypeName = "nvarchar(255)")]
        public string Content { get; set; }
        [Required]
        public string Color { get; set; }
        [Range(1000, 1000000000000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public string Imgage { get; set; }
        public ICollection<OderDetail> oderDetails { get; set; }
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public int BrandID { get; set; }
        [ForeignKey("BrandID")]
        public Brand Brand { get; set; }
        [Display(Name="Năm Sản Xuất")]
        public int Namsx { get; set; }
        [Display(Name = "Ngày Nhập Khẩu")]
        public DateTime NgayNhapKhau { get; set; }
        [Display(Name = "Tình Trạng")]
        public string TinhTrang { get; set; }
        [Display(Name = "Động Cơ")]
        public string DongCo { get; set; }

    }
}
