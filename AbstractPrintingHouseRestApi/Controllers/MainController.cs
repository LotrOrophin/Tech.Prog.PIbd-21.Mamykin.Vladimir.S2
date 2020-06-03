using AbstractPrintingHouseBusinessLogic.BindingModels;
using AbstractPrintingHouseBusinessLogic.BusinessLogics;
using AbstractPrintingHouseBusinessLogic.Interfaces;
using AbstractPrintingHouseBusinessLogic.ViewModels;
using AbstractPrintingHouseRestApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;



namespace AbstractPrintingHouseRestApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOrderLogic _order;
        private readonly IPrintingProductLogic _product;
        private readonly MainLogic _main;
        public MainController(IOrderLogic order, IPrintingProductLogic product, MainLogic main)
        {
            _order = order;
            _product = product;
            _main = main;
        } [HttpGet]
        public List<PrintingProductModel> GetProductList() => _product.Read(null)?.Select(rec =>
       Convert(rec)).ToList();
        [HttpGet]
        public PrintingProductModel GetProduct(int productId) => Convert(_product.Read(new
       PrintingProductBindingModel
        { Id = productId })?[0]);
        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new
       OrderBindingModel
        { ClientId = clientId });
        [HttpPost]  
        public void CreateOrder(CreateOrderBindingModel model) =>
       _main.CreateOrder(model);
        private PrintingProductModel Convert(PrintingProductViewModel model)
        {
            if (model == null) return null;
            return new PrintingProductModel
            {
                Id = model.Id,
                PrintingProductName = model.printingProductName,
                Price = model.Price
            };
        }
    }
}
