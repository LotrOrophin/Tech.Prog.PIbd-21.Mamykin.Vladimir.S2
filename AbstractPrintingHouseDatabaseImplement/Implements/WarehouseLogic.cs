using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.Interfaces;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using AbstractPrintingHouseDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPrintingHouseDatabaseImplement.Implements
{
    public class WarehouseLogic : IWarehouseLogic
    {
        public void CreateOrUpdate(WarehouseBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                Warehouse element = context.Warehouses.FirstOrDefault(rec => rec.WarehouseName == model.WarehouseName && rec.Id != model.Id);

                if (element != null)
                {
                    throw new Exception("Уже есть склад с таким названием");
                }

                if (model.Id.HasValue)
                {
                    element = context.Warehouses.FirstOrDefault(rec => rec.Id == model.Id);

                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Warehouse();
                    context.Warehouses.Add(element);
                }

                element.WarehouseName = model.WarehouseName;

                context.SaveChanges();
            }
        }

        public void Delete(WarehouseBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.WarehouseComponents.RemoveRange(context.WarehouseComponents.Where(rec => rec.WarehouseId == model.Id));
                        Warehouse element = context.Warehouses.FirstOrDefault(rec => rec.Id == model.Id);

                        if (element != null)
                        {
                            context.Warehouses.Remove(element);
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

        public void AddComponent(WarehouseComponentBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                WarehouseComponent element =
                    context.WarehouseComponents.FirstOrDefault(rec => rec.WarehouseId == model.WarehouseId && rec.ComponentId == model.ComponentId);

                if (element != null)
                {
                    element.Count += model.Count;
                }
                else
                {

                    element = new WarehouseComponent();

                    context.WarehouseComponents.Add(element);
                }

                element.WarehouseId = model.WarehouseId;
                element.ComponentId = model.ComponentId;
                element.Count = model.Count;

                context.SaveChanges();
            }
        }

        public List<WarehouseViewModel> Read(WarehouseBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                return context.Warehouses
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
                .Select(rec => new WarehouseViewModel
                {
                    Id = rec.Id,
                    WarehouseName = rec.WarehouseName,
                    WarehouseComponents = context.WarehouseComponents
                                                .Include(recWC => recWC.Component)
                                                .Where(recWC => recWC.WarehouseId == rec.Id)
                                                .ToDictionary(recWC => recWC.ComponentId, recWC => (
                                                    recWC.Component?.ComponentName, recWC.Count
                                                ))
                })
                .ToList();
            }
        }

        public void WriteOffComponents(OrderViewModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var productComponents = context.ProductComponents.Where(rec => rec.ProductId == model.PrintProductId).ToList();

                        foreach (var pc in productComponents)
                        {
                            var warehouseComponent = context.WarehouseComponents.Where(rec => rec.ComponentId == pc.ComponentId);
                            int neededCount = pc.Count * model.Count;

                            foreach (var wc in warehouseComponent)
                            {
                                if (wc.Count >= neededCount)
                                {
                                    wc.Count -= neededCount;
                                    neededCount = 0;
                                    break;
                                }
                                else
                                {
                                    neededCount -= wc.Count;
                                    wc.Count = 0;
                                }
                            }

                            if (neededCount > 0)
                            {
                                throw new Exception("На складах недостаточно компонентов");
                            }

                        }

                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
