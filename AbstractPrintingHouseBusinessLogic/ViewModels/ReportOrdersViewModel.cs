using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using AbstractPrintingHouseBusinessLogic.Enums;

namespace AbstractPrintingHouseBusinessLogic.ViewModels
{
   public class ReportOrdersViewModel
    {
        [DisplayName("Дата создания")]
        public DateTime DateCreate { get; set; }

        [DisplayName("Изделие")]
        public string PrintingProductName { get; set; }

        [DisplayName("Количество")]
        public int Count { get; set; }

        [DisplayName("Сумма")]
        public decimal? Sum { get; set; }

        [DisplayName("Статус")]
        public OrderStatus Status { get; set; }

    }
}
