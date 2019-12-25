using MobileSiteBusinessEntities.ModelsEntities;
using MobileSiteBusinessLogic.Implementation;
using SmartMobilesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartMobilesStore.Controllers
{
    public class BasketController : Controller
    {
        // GET: Basket
        BasketService _basketService = new BasketService();
        //OrderModels order = new OrderModels();
        // GET: Order
        public JsonResult AddToCart(BasketEntities basket)
        {
            //var basketEntities = new BasketEntities();
            var data = _basketService.AddToCart(basket);
            return Json(data);
        }
        public JsonResult GetUserBasket()
        {
            //var basketEntities = new BasketEntities();
            var data = _basketService.GetUserBasket();
            return Json(data);
        }
        public JsonResult DeleteUserBasket(BasketEntities basket)
        {
            //var basketEntities = new BasketEntities();
            var data = _basketService.DeleteUserBasket(basket);
            return Json(data);
        }
    }
}