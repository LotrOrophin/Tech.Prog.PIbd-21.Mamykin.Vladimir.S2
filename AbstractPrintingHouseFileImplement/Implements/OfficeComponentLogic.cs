using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.Interfaces;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using AbstractPrintingHouseFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AbstractPrintingHouseFileImplement.Implements
{
    public class OfficeComponentLogic : IOfficeComponentLogic
    {
        private readonly FileDataListSingleton source;
        public OfficeComponentLogic()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public void CreateOrUpdate(OfficeComponentBindingModel model)
        {
            OfficeComponent element = source.Components.FirstOrDefault(rec => rec.ComponentName
           == model.ComponentName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть компонент с таким названием");
            }
            if (model.Id.HasValue)
            {

                element = source.Components.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
            }
            else
            {
                int maxId = source.Components.Count > 0 ? source.Components.Max(rec =>
               rec.Id) : 0;
                element = new OfficeComponent { Id = maxId + 1 };
                source.Components.Add(element);
            }
            element.ComponentName = model.ComponentName;
        }
        public void Delete(OfficeComponentBindingModel model)
        {
            OfficeComponent element = source.Components.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                source.Components.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public List<OfficeComponentViewModel> Read(OfficeComponentBindingModel model)
        {
            return source.Components
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
