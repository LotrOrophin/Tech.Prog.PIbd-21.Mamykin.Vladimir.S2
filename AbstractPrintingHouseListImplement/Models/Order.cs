﻿using AbstractPrintingHouseBusinessLogic.Enums;
using System;
using System.Runtime.Serialization;

namespace AbstractPrintingHouseListImplement.Models
{
    /// <summary>
    /// Заказ
    /// </summary>

    public class Order

    { 
        public int ClientId { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
    }
}
