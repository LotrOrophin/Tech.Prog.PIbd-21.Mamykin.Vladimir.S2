using AbstractPrintingHouseBusinessLogic.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.ViewModels
{
    /// <summary>
    /// Изделие, изготавливаемое в магазине
    /// </summary>
    /// 
    [DataContract]
    public class PrintingProductViewModel : BaseViewModel
    {
        [Column(title: "Название изделия", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string printingProductName { get; set; }

        [Column(title: "Цена", width: 50)]
        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public Dictionary<int, (string, int)> ProductComponents { get; set; }

        public override List<string> Properties() => new List<string>
        {
            "Id",
            "ProductName",
            "Price"
        };
    }
}
