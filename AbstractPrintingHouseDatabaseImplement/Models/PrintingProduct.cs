
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractPrintingHouseDatabaseImplement.Models
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    public class PrintingProduct
    {
        public int Id { get; set; }
        [Required]
        public string PrintProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [ForeignKey("ProductId")]
        public virtual List<ProductOfficeComponent> ProductOfficeComponent { get; set; }
        [ForeignKey("PrintingProductId")]
        public virtual List<Order> Orders { get; set; }
    }   
}
    