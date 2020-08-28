using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.HelperModels;
using AbstractPrintingHouseBusinessLogic.Interfaces;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AbstractPrintingHouseBusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IOfficeComponentLogic officeComponentLogic;

        private readonly IPrintingProductLogic productLogic;

        private readonly IOrderLogic orderLogic;
        public ReportLogic(IPrintingProductLogic productLogic, IOfficeComponentLogic officeComponentLogic, IOrderLogic orderLogic)
        {
            this.productLogic = productLogic;
            this.officeComponentLogic = officeComponentLogic;
            this.orderLogic = orderLogic;
        }

        /// <summary>
        /// Получение списка продуктов с расшифровкой по ингредиентам
        /// </summary>
        /// <returns></returns>
        public List<ReportProductOfficeComponentViewModel> GetProductOfficeComponent()
        {
            var products = productLogic.Read(null);
            var reportList = new List<ReportProductOfficeComponentViewModel>();
            foreach (var product in products)
            {
                reportList.Add(new ReportProductOfficeComponentViewModel
                {
                   PrintingProductName = product.PrintProductName,
                });
                foreach (var component in product.ProductComponents)
                    reportList.Add(new ReportProductOfficeComponentViewModel
                    {
                        ComponentName = component.Value.Item1,
                        TotalCount = component.Value.Item2
                    });
            }
            return reportList;
        }

        /// <summary>
        /// Получение списка заказов за определенный период
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<IGrouping<DateTime, OrderViewModel>> GetOrders(ReportBindingModel model)
        {
            var list = orderLogic
            .Read(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
            .GroupBy(rec => rec.DateCreate.Date)
            .OrderBy(recG => recG.Key)
            .ToList();

            return list;
        }
        /// <summary>
        /// Сохранение кондитерских изделий с ценой в файл-Word
        /// </summary>
        /// <param name="model"></param>
        public void SaveProductsToWord(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список изделий",
                PrintingProducts = productLogic.Read(null)
            });
        }

        /// <summary>
        /// Сохранение информации о заказах
        /// </summary>
        /// <param name="model"></param>
        public void SaveOrdersToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                DateFrom = model.DateFrom,
                DateTo = model.DateTo,
                Orders = GetOrders(model)
            });
        }

        /// <summary>
        /// Сохранение кондитерских изделий c расшифровкой в файл-Pdf
        /// </summary>
        /// <param name="model"></param>
        public void SaveProductComponentToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список изделий и продуктов",
                ProductOfficeComponent = GetProductOfficeComponent()
            });
        }
    }
}
