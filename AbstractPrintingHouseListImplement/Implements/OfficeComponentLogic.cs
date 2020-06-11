using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.Interfaces;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using AbstractPrintingHouseListImplement.Models;
using System;
using System.Collections.Generic;


namespace AbstractPrintingHouseListImplement.Implements
{
    public class OfficeComponentLogic : IOfficeComponentLogic
    {
        private readonly DataListSingleton source;
        public OfficeComponentLogic()
        {
            source = DataListSingleton.GetInstance();
        }
        public void CreateOrUpdate(OfficeComponentBindingModel model)
        {
            OfficeComponent tempComponent = model.Id.HasValue ? null : new OfficeComponent
            {
                Id = 1
            };
            foreach (var component in source.Components)
            {
                if (component.ComponentName == model.ComponentName && component.Id !=
               model.Id)
                {
                    throw new Exception("Уже есть компонент с таким названием");
                }
                if (!model.Id.HasValue && component.Id >= tempComponent.Id)
                {
                    tempComponent.Id = component.Id + 1;
                }
                else if (model.Id.HasValue && component.Id == model.Id)
                {
                    tempComponent = component;
                }
            }
            if (model.Id.HasValue)
            {
                if (tempComponent == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, tempComponent);
            }
            else
            {
                source.Components.Add(CreateModel(model, tempComponent));
            }
        }
        public List<OfficeComponentViewModel> GetList()
        {
            List<OfficeComponentViewModel> result = new List<OfficeComponentViewModel>();

            for (int i = 0; i < source.Components.Count; ++i)
            {
                result.Add(new OfficeComponentViewModel
                {
                    Id = source.Components[i].Id,
                    ComponentName = source.Components[i].ComponentName
                });
            }

            return result;
        }

        public OfficeComponentViewModel GetElement(int id)
        {
            for (int i = 0; i < source.Components.Count; ++i)
            {
                if (source.Components[i].Id == id)
                {
                    return new OfficeComponentViewModel
                    {
                        Id = source.Components[i].Id,
                        ComponentName = source.Components[i].ComponentName
                    };
                }
            }

            throw new Exception("Элемент не найден");
        }

        public void Delete(OfficeComponentBindingModel model)
        {
            for (int i = 0; i < source.Components.Count; ++i)
            {
                if (source.Components[i].Id == model.Id.Value)
                {
                    source.Components.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private OfficeComponent CreateModel(OfficeComponentBindingModel model, OfficeComponent component)
        {
            component.ComponentName = model.ComponentName;
            return component;
        }
        private OfficeComponentViewModel CreateViewModel(OfficeComponent component)
        {
            return new OfficeComponentViewModel
            {
                Id = component.Id,
                ComponentName = component.ComponentName
            };
        }
    }
}     
