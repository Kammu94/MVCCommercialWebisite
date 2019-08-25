using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileSiteBusinessLogic;
using MobileSiteDataLayer;
using MobileSiteBusinessEntities;
using System.Configuration;
using System.IO;
namespace SmartMobilesStore.Controllers
{
    public class AdminController : Controller { 

     MobileSiteServices service = new MobileSiteServices();

    ProductDetailModel prodmodel = new ProductDetailModel();
    
        // GET: Admin
        public ActionResult AddProduct()
        {
            return View();
        }
        public ActionResult Submit(ProductDetailModel promodel)
        {
          
            service.Submit(promodel.ProductId, promodel.ProductName, (Decimal)promodel.SellingPrice , (Decimal)promodel.MarketPrice, 
                      promodel.Stock, promodel.Description,
                      promodel.DateOfInsert, promodel.Rating, promodel.OperatingSystem, promodel.Color,promodel.IsAvailable,promodel.FirstImage,promodel.SecondImage,promodel.ThirdImage);
            return View("AddProduct");
        }

        public JsonResult GetProducts()
        {
            var users = service.GetProducts();
            
            return Json(users);


        }
        public ActionResult DeleteUser(Guid ProductId)//ProductDetailsModel ProductId
        {
            var del = new MobileSiteServices();
            del.DeleteUser(ProductId);

            return View("AddProduct");
        }
        //To edit the product table
        public JsonResult EditProduct(Guid ProductId)
        {
            var edit = service.EditProduct(ProductId);
           


            return Json(edit);
        }



        public JsonResult ImageUploader()
        {

            var filePath = Server.MapPath("~" + ConfigurationManager.AppSettings["ImageUploader"] + "/");
            var Filename = "";
            if (Request != null)
            {
                if (Request.Files != null)
                {
                    if (Request.Files.Count > 0)
                    {
                        //  var guidFileName = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
                        var httpPostedFileBase = Request.Files[0];
                        Filename = httpPostedFileBase.FileName;

                        var Url = filePath + httpPostedFileBase.FileName;

                        var FileType = Path.GetExtension(httpPostedFileBase.FileName);


                        if (!Directory.Exists(filePath))
                        {
                            Directory.CreateDirectory(filePath);
                        }
                        httpPostedFileBase.SaveAs(filePath + Filename); //Path.GetFileName(httpPostedFileBase.FileName));

                    }
                }
            }
            return Json(Filename);
        }
        public ActionResult Login (){ return View("Login");}
    }

}