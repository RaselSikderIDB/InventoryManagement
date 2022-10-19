using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryBeginners.Models
{
    public class PoDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("PoHeader")]
        public int PoId { get; set; }
        public virtual PoHeader PoHeader { get; private set; }
        [Required]
        [ForeignKey("Product")]
        [MaxLength(6)]
        public string ProductCode{ get; set; }
        public virtual Product Product { get; private set; }
        [Column(TypeName = "smallmoney")]
        [Required]
        [Range(1,1000,ErrorMessage ="Quantity must be greater than 0 and less than 1000")]
        public decimal Quantity { get; set; }
       
        [DisplayFormat(DataFormatString ="0:0.000",ApplyFormatInEditMode =true)]
        [Column(TypeName = "smallmoney")]
        [Required]
        [Range(1, 1000, ErrorMessage = "Quantity must be greater than 0 and less than 1000")]
        public decimal Fob { get; set; }
        
        [DisplayFormat(DataFormatString = "0:0.000", ApplyFormatInEditMode = true)]
        [Column(TypeName = "smallmoney")]
        [Required]
        [Range(1, 1000, ErrorMessage = "Quantity must be greater than 0 and less than 1000")]
        public decimal PrcInBaseCur { get; set; }
        [MaxLength(75)]
        [NotMapped]
        public string Description { get; set; } = "";
        [MaxLength(25)]
        [NotMapped]
        public string UnitName { get; set; } = "";
        [NotMapped]
        public bool IsDeleted { get; set; } = false;
        [NotMapped]
        public decimal Total { get; set; }

    }
}
