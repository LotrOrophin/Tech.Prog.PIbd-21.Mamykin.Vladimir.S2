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
        public List<Warehouse> Warehouses { get; set; }
        public List<WarehouseComponent> WarehouseComponents { get; set; }
        private DataListSingleton()
        {
        Components = new List<OfficeComponent>();
            Orders = new List<Order>();
            Products = new List<PrintingProduct>();
            ProductComponents = new List<ProductOfficeComponent>();
            Warehouses = new List<Warehouse>();
            WarehouseComponents = new List<WarehouseComponent>();
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

