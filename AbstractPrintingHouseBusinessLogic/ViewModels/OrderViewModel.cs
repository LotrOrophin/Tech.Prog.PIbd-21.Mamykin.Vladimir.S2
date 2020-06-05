﻿using AbstractPrintingHouseBusinessLogic.Attributes;
using AbstractPrintingHouseBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.ViewModels
{
    /// <summary>
    /// Заказ
    /// </summary>
    //
    [DataContract]
    public class OrderViewModel : BaseViewModel
    {
        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public int? ImplementerId { get; set; }

        [Column(title: "Клиент", width: 150)]
        [DataMember]
        public string ClientFIO { get; set; }

        [Column(title: "Изделие", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string PrintProductName { get; set; }

        [Column(title: "Исполнитель", width: 150)]
        [DataMember]
        public string ImplementerFIO { get; set; }

        [Column(title: "Количество", width: 100)]
        [DataMember]
        public int Count { get; set; }

        [Column(title: "Сумма", width: 50)]
        [DataMember]
        public decimal Sum { get; set; }

        [Column(title: "Статус", width: 100)]
        [DataMember]
        public OrderStatus Status { get; set; }

        [Column(title: "Дата создания", width: 100)]
        [DataMember]
        public DateTime DateCreate { get; set; }

        [Column(title: "Дата выполнения", width: 100)]
        [DataMember]
        public DateTime? DateImplement { get; set; }

        public override List<string> Properties() => new List<string>
        {
            "Id",
            "ClientFIO",
            "PrintProductName",
            "ImplementerFIO",
            "Count",
            "Sum",
            "Status",
            "DateCreate",
            "DateImplement"
        };

    }
}
