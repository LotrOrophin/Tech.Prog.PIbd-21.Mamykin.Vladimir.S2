using AbstractPrintingHouseListImplement.Models;
using System.Collections.Generic;

namespace AbstractPrintingHouseListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<OfficeComponent> Components { get; set; }
        public List<Order> Orders { get; set; }
        public List<PrintingProduct> Products { get; set; }
        public List<ProductOfficeComponent> ProductComponents { get; set; }
        public List<Client> Clients { get; set; }
        public List<Implementer> Implementers { get; set; }
        public List<MessageInfo> MessageInfoes { get; set; }
        private DataListSingleton()
        {
        Components = new List<OfficeComponent>();
            Orders = new List<Order>();
            Products = new List<PrintingProduct>();
            ProductComponents = new List<ProductOfficeComponent>();
            Clients = new List<Client>();
            Implementers = new List<Implementer>();
            MessageInfoes = new List<MessageInfo>();
        }
        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}

