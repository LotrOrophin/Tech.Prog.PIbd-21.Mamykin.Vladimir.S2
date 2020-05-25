using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.BindingModels
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    public class PrintingProductBindingModel
    {
        public int? Id { get; set; }
        public string PrintProductName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> ProductComponents { get; set; }
    }
}
