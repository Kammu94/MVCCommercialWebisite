using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartMobilesStore.Models;
using MobileSiteBusinessLogic;
using MobileSiteDataLayer;
using System.Web.SessionState;
using MobileSiteBusinessEntities;

namespace SmartMobilesStore.Controllers
{
    public class AccountController : Controller
    {
        UserAccountServices services = new UserAccountServices();
        //UserAccountLoginModel loginmodel = new UserAccountLoginModel();

        public ActionResult Index(UserAccountModel MyFormValues)
        {
            if (!ModelState.IsValid)
            {
                return View("UserRegistrationForm");
            }
            var GetSiteUserData = new UserAccountServices();

            var data = GetSiteUserData.Index(MyFormValues.UserId,MyFormValues.FirstName,MyFormValues.LastName,MyFormValues.Email,MyFormValues.Password,MyFormValues.Gender,MyFormValues.Country,(string)MyFormValues.ContactNumber);

            if (data.isValid==true)
                
            {
                ViewBag.ErrorMessage = data.Message;
                
                return View("UserRegistrationForm");

               
            }
            else
            {
                return RedirectToAction("Login", "Account", "");
            }
            
        }
        public ActionResult UserRegistrationForm()
        {
            return View();
        }
        public JsonResult GetLoginDetails(string Email,string Password)
        {
            
            var users = services.GetLoginDetails(Email,Password);
              
            
            
            if(users!=null&& users[0].isValid==true)
            {
                 HttpContext.Session["UserId"] = users[0].UserId;
                 HttpContext.Session["Email"] = users[0].Email;
                 HttpContext.Session["FirstName"] = users[0].FirstName;


            }
            return Json(users);

        }
        public ActionResult Login()
        {
            
            return View();
        }
        //It is use to redirect from Login to homepage
        public ActionResult Homepage()
        {
            return View("~/Views/Home/Index.cshtml");


        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index","Home");
        }
        public JsonResult AdminLogin(string Email, string password)
        {
            var resp = services.AdminLogin(Email, password);
           
                return Json(resp);
          
        }
    }
}