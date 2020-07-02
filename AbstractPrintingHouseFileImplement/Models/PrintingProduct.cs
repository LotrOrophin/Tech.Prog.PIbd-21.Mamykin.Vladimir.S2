using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPrintingHouseFileImplement.Models
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    public class PrintingProduct
    {
        public int Id { get; set; }
        public string PrintProductName { get; set; }
        public decimal Price { get; set; }
    }
}
