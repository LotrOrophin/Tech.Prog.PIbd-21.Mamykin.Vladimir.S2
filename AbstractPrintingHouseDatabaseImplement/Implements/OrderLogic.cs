using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.Enums;
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
    public class OrderLogic : IOrderLogic
    {

        public void CreateOrUpdate(OrderBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase()) {
                Order element;

                if (model.Id.HasValue)
                {

                    element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }

                }
                else
                {
                    element = new Order();
                    context.Orders.Add(element);
                }
                element.PrintingProductId = model.ProductId == 0 ? element.PrintingProductId : model.ProductId ;
                element.ClientId = model.ClientId == null ? element.ClientId : (int)model.ClientId;
                element.ImplementerId = model.ImplementerId;
                element.Count = model.Count;
                element.DateCreate = model.DateCreate;
                element.DateImplement = model.DateImplement;
                element.Status = model.Status;
                element.Sum = model.Sum;
                context.SaveChanges();
            }      
        }

        public void Delete(OrderBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
               
        }

        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            using (var context = new AbstractPrintingHouseDatabase())
            {
                return context.Orders
                .Where(rec => model == null
                    || rec.Id == model.Id && model.Id.HasValue
                    || model.DateFrom.HasValue && model.DateTo.HasValue && rec.DateCreate >= model.DateFrom && rec.DateCreate <= model.DateTo
                    || model.ClientId.HasValue && rec.ClientId == model.ClientId
                    || model.FreeOrders.HasValue && model.FreeOrders.Value && !rec.ImplementerId.HasValue
                    || model.ImplementerId.HasValue && rec.ImplementerId == model.ImplementerId && rec.Status == OrderStatus.Выполняется)
                .Include(rec => rec.Client)
                .Include(rec => rec.PrintingProduct)
                .Include(rec => rec.Implementer)
                .Select(rec => new OrderViewModel
                {
                    Id = rec.Id,
                    ClientId = rec.ClientId,
                    ImplementerId = rec.ImplementerId,
                    ProductId = rec.PrintingProductId,               
                    Count = rec.Count,
                    Sum = rec.Sum,
                    PrintProductName = context.Products.FirstOrDefault(mod => mod.Id == rec.PrintingProductId).PrintProductName,
                    Status = rec.Status,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,

                    ImplementerFIO = rec.ImplementerId.HasValue ? rec.Implementer.ImplementerFIO : string.Empty,
                    ClientFIO = rec.Client.FIO
                })
                .ToList();
            }
            
        }

    }
}
