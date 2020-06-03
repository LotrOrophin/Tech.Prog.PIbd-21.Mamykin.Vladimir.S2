using System;
using System.Collections.Generic;
using System.Text;
using AbstractPrintingHouseBusinessLogic.ViewModels;

namespace AbstractPrintingHouseBusinessLogic.HelperModels
{
    public class WordInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<PrintingProductViewModel> PrintingProducts { get; set; }

    }
}
