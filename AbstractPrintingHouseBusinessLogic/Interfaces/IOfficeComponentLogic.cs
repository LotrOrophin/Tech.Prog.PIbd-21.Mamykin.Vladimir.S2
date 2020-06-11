using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPrintingHouseBusinessLogic.Interfaces
{
    public interface IOfficeComponentLogic
    {
        List<OfficeComponentViewModel> GetList();
        OfficeComponentViewModel GetElement(int id);
        void CreateOrUpdate(OfficeComponentBindingModel model);
        void Delete(OfficeComponentBindingModel model);
    }
}
