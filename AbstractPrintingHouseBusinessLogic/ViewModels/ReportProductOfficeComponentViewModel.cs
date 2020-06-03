using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.ViewModels
{
   public class ReportProductOfficeComponentViewModel
    {
        public string PrintingProductName { get; set; }
        public string ComponentName { get; set; }
        public int TotalCount { get; set; }
        //public List<Tuple<string, int>> Products { get; set; }
    }
}
