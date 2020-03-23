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
        private DataListSingleton()
        {
        Components = new List<OfficeComponent>();
            Orders = new List<Order>();
            Products = new List<PrintingProduct>();
            ProductComponents = new List<ProductOfficeComponent>();
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

