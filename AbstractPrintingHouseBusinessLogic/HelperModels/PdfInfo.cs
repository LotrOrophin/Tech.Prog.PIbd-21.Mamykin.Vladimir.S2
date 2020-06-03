using System;
using System.Collections.Generic;
using System.Text;
using AbstractPrintingHouseBusinessLogic.ViewModels;


namespace AbstractPrintingHouseBusinessLogic.HelperModels
{
   public  class PdfInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<ReportProductOfficeComponentViewModel> ProductOfficeComponent { get; set; }
    }
}
