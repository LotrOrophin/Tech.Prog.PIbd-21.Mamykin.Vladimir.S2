﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPrintingHouseBusinessLogic.BindingModels
{
    /// <summary>
    /// Данные от клиента, для создания заказа
    /// </summary>
    /// 
    [DataContract]
    public class CreateOrderBindingModel
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public int ClientId { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public decimal Sum { get; set; }
    }
}
