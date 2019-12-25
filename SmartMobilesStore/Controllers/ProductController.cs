using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileSiteBusinessLogic;
using MobileSiteDataLayer;
using MobileSiteBusinessEntities;
using SmartMobilesStore.Models;
using MobileSiteBusinessEntities.ModelsEntities;

namespace SmartMobilesStore.Controllers
{
    public class ProductController : Controller
    {
        HomePageRepository product = new HomePageRepository();
        HomePageServices service = new HomePageServices();
        // GET: Product
  
        public JsonResult GetNewProductsList()
        {
            var ProductsList = service.GetNewProductsList();
            return Json(ProductsList);


        }
        //it will get the related Products list
        public JsonResult GetListOfProducts()
        {
            var ProductsListHome = service.GetListOfProducts();
            return Json(ProductsListHome);

            
        }
        //it will get the list of products on list page
        public JsonResult GetProductsList()
        {
            var data = service.GetProductsList();
       
            return Json(data);


        }
        //GetColorFilteredProductsList
        public JsonResult GetProductsByColor(List<FilterPropertiesEntities> filters)
        {
            var data = service.GetProductsByColor(filters);
           
            return Json(data);


        }
        //added basket to item
        //public JsonResult AddToBasket(BasketEntities basket)
        //{
        //    var data = service.AddToBasket(basket);

        //    return Json(data);
        //}

        public JsonResult GetSelectedFilter(List<FilterPropertiesModel> filters)
        {
            var data = service.GetSelectedFilter();

            return Json(data);
        }
        //
        public JsonResult DeleteSelectedFilter(string id)
        {
            var filterId = Guid.Parse(id);
            var data = service.DeleteSelectedFilter(filterId);

            return Json(data);
        }

        //GetColorFilteredProductsList




        public ActionResult DescriptionPage(Guid id)
        {
            var data = service.DescriptionPage(id);
            var productdetail = new ProductDetailModel
            {
                ProductId=data.ProductId,
                ProductName=data.ProductName,
                SellingPrice=data.SellingPrice,
                MarketPrice=data.MarketPrice,
                Stock=data.Stock,
                Description=data.Description,
               
                Rating=data.Rating,
                OperatingSystem=data.OperatingSystem,
                Color=data.Color,
                IsAvailable=data.IsAvailable,
                FirstImage=data.FirstImage,
                SecondImage=data.SecondImage,
                ThirdImage=data.ThirdImage
               
            };


          return  RedirectToAction("DescriptionPage", data);

        }
        public ActionResult DescriptionPage() { return View(); }
        public ActionResult ProductListPage()
        {
            return View();
        }

    }
}