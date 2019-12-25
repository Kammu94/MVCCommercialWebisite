using MobileSiteBusinessEntities.ModelsEntities;
using MobileSiteDataLayer.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.SessionState;
using System.Threading.Tasks;
using System.Web;

namespace MobileSiteBusinessLogic.Implementation
{
    public class BasketService
    {
        BasketRepository _basketRepository = new BasketRepository();
        BasketEntities basketEntities = new BasketEntities();

        public BasketEntities AddToCart(BasketEntities basket)  
        {          

            HttpContext context = HttpContext.Current;
            //context.Session["UserId"] = firstName;
            basket.UserId = (Guid)context.Session["UserId"];
            var IsBasketExisted = _basketRepository.IsBasketexisted(basket);
            basket.BasketHeaderId = IsBasketExisted.BasketHeaderId;
            var data = _basketRepository.AddToCart(basket);

            return data;
 
        }
        //GetUserBasket
        public List<BasketEntities> GetUserBasket()
        {
            HttpContext context = HttpContext.Current;
            //context.Session["UserId"] = firstName;
            Guid userId = (Guid)context.Session["UserId"];
            var data = _basketRepository.GetUserBasket(userId);
            return data;

        }
        
      public BasketEntities DeleteUserBasket(BasketEntities basket)
        {
            HttpContext context = HttpContext.Current;
            basket.UserId = (Guid)context.Session["UserId"];
            var data = _basketRepository.DeleteUserBasket(basket);
            return data;

        }
        //all the data we need to see the informtion about the detailed page.
      
    }
}
