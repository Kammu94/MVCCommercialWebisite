using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileSiteBusinessEntities;
using MobileSiteBusinessLogic;
using MobileSiteDataLayer;

namespace SmartMobilesStore.Controllers
{
    public class OrderController : Controller
    {
        OrderServices services = new OrderServices();
        OrderModels order = new OrderModels();
        // GET: Order
        public JsonResult AddToCart(string Email, Guid ProductId, int Quantity, Guid UserId, int Total, Guid BasketId,
                             float SellingPrice, Guid ItemId)
        {
            var data = services.AddToCart(order.Email,order.ProductId,order.Quantity,order.UserId,order.Total,order.BasketId,order.SellingPrice,order.ItemId);
            return Json(data);
            
        }
        //public JsonResult AddToCart()
        //{
        //    return Json();
        //}
    }
}