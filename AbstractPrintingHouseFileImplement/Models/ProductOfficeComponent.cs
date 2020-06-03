using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPrintingHouseFileImplement.Models
{
    public class ProductOfficeComponent
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int ComponentId { get; set; }

        public int Count { get; set; }
    }
}
