using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.Interfaces
{
    public interface IPrintingProductLogic
    {
        List<PrintingProductViewModel> Read(PrintingProductBindingModel model);
        void CreateOrUpdate(PrintingProductBindingModel model);
        void Delete(PrintingProductBindingModel model);
    }

}
