
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AbstractPrintingHouseDatabaseImplement.Models
{
 /// <summary>
 /// Сколько компонентов, требуется при изготовлении изделия
 /// </summary>
 public class ProductOfficeComponent
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ComponentId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual OfficeComponent Component { get; set; }
        public virtual PrintingProduct PrintingProduct { get; set; }

    }
}   
