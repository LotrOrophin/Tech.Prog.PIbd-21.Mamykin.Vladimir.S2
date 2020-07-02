using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.Interfaces;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using AbstractPrintingHouseDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
namespace AbstractPrintingHouseDatabaseImplement.Implements
{
    public class PrintingProductLogic : IPrintingProductLogic
    {
        public void CreateOrUpdate(PrintingProductBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        PrintingProduct element = context.Products.FirstOrDefault(rec =>
                       rec.PrintProductName == model.PrintProductName && rec.Id != model.Id);
                        if (element != null)
                        {
                            throw new Exception("Уже есть изделие с таким названием");
                        }
                        if (model.Id.HasValue)
                        {
                            element = context.Products.FirstOrDefault(rec => rec.Id ==
                           model.Id);
                            if (element == null)
                            {
                                throw new Exception("Элемент не найден");
                            }
                        }
                        else
                           
                    {
                            element = new PrintingProduct();
                            context.Products.Add(element);
                        }
                        element.PrintProductName = model.PrintProductName;
                        element.Price = model.Price;
                        context.SaveChanges();
                        if (model.Id.HasValue)
                        {
                            var productComponents = context.ProductComponents.Where(rec
                           => rec.ProductId == model.Id.Value).ToList();
                            // удалили те, которых нет в модели
                            context.ProductComponents.RemoveRange(productComponents.Where(rec =>
                            !model.ProductComponents.ContainsKey(rec.ComponentId)).ToList());
                            context.SaveChanges();
                            // обновили количество у существующих записей
                            foreach (var updateComponent in productComponents)
                            {
                                updateComponent.Count =
                               model.ProductComponents[updateComponent.ComponentId].Item2;

                                model.ProductComponents.Remove(updateComponent.ComponentId);
                            }
                            context.SaveChanges();
                        }
                        // добавили новые
                        foreach (var pc in model.ProductComponents)
                        {
                            context.ProductComponents.Add(new ProductOfficeComponent
                            {
                                ProductId = element.Id,
                                ComponentId = pc.Key,
                                Count = pc.Value.Item2
                            });
                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(PrintingProductBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // удаяем записи по компонентам при удалении изделия
                        context.ProductComponents.RemoveRange(context.ProductComponents.Where(rec =>
                        rec.ProductId == model.Id));
                        PrintingProduct element = context.Products.FirstOrDefault(rec => rec.Id
                       
                       == model.Id);
                        if (element != null)
                        {
                            context.Products.Remove(element);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Элемент не найден");
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<PrintingProductViewModel> Read(PrintingProductBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                return context.Products
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
               .Select(rec => new PrintingProductViewModel
               {
                   Id = rec.Id,
                   PrintProductName = rec.PrintProductName,
                   Price = rec.Price,
                   ProductComponents = context.ProductComponents
                .Include(recPC => recPC.Component)
               .Where(recPC => recPC.ProductId == rec.Id)
               .ToDictionary(recPC => recPC.ComponentId, recPC =>
                (recPC.Component?.ComponentName, recPC.Count))
               })
               .ToList();
            }
        }
    }
}
