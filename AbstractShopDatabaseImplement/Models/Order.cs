using AbstractPrintingHouseBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace AbstractPrintingHouseDatabaseImplement.Models
{
    /// <summary>
    /// Заказ
    /// </summary>
    ///     
    public class Order

    {   
        public int ClientId { get; set; }
        public int? ImplementerId { get; set; }
        public int Id { get; set; }
        public int PrintingProductId { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public decimal Sum { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
        [Required]
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }        

        public PrintingProduct PrintingProduct { get; set; }
        public Client Client { get; set; }
        public Implementer Implementer { get; set; }
    }
}
