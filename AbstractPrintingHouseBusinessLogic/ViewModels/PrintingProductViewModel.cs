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
    public class PrintingProductViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DisplayName("Название изделия")]
        [DataMember]

        public string printingProductName { get; set; }
        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> ProductComponents { get; set; }
    }
}
