using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileSiteBusinessLogic;
using MobileSiteDataLayer;
using MobileSiteBusinessEntities;
namespace MobileSiteBusinessLogic
{
    
    public class OrderServices
    {
        OrderRepository repos = new OrderRepository();

        public bool AddToCart(string Email,Guid ProductId,int Quantity,Guid UserId,int Total,Guid BasketId,float SellingPrice,Guid ItemId)
        {
             repos.AddToCart(Email, ProductId, Quantity, UserId, Total,BasketId, SellingPrice,ItemId);
            return true;
            
        }
    }
}
