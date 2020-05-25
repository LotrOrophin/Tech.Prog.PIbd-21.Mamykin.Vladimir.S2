using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.ViewModels
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    public class PrintingProductViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название изделия")]
        public string PrintProductName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> ProductComponents { get; set; }
    }
}
