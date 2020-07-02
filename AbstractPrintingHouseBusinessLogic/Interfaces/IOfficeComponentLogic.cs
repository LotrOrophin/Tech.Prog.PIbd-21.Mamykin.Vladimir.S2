using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.Interfaces
{
    public interface IOfficeComponentLogic
    {
        List<OfficeComponentViewModel> Read(OfficeComponentBindingModel model);
        void CreateOrUpdate(OfficeComponentBindingModel model);
        void Delete(OfficeComponentBindingModel model);
    }
}
