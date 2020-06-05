using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.Interfaces;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using AbstractPrintingHouseDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace AbstractPrintingHouseDatabaseImplement.Implements
{
    public class OfficeComponentLogic : IOfficeComponentLogic
    {
        public void CreateOrUpdate(OfficeComponentBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                OfficeComponent element = context.Components.FirstOrDefault(rec =>
               rec.ComponentName == model.ComponentName && rec.Id != model.Id);
                if (element != null)
                {
                    throw new Exception("Уже есть компонент с таким названием");
                }
                if (model.Id.HasValue)
                {
                    element = context.Components.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    
                if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new OfficeComponent();
                    context.Components.Add(element);
                }
                element.ComponentName = model.ComponentName;
                context.SaveChanges();
            }
        }
        public void Delete(OfficeComponentBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                OfficeComponent element = context.Components.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Components.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<OfficeComponentViewModel> Read(OfficeComponentBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                return context.Components
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new OfficeComponentViewModel
                {
                    Id = rec.Id,
                    ComponentName = rec.ComponentName
                })
                .ToList();
            }
        }
    }
}
