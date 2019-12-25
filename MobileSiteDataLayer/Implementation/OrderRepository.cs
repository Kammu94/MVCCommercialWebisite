using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSiteDataLayer
{
    public class OrderRepository
    {
        public bool AddToCart(string Email, Guid ProductId, int Quantity, Guid UserId, int Total, Guid BasketId,
                             float SellingPrice, Guid ItemId)
        {
            //using (var ConStr = ConnectionHandler.GetConString())
            //{
            //    var repos = ConStr.ProcInsertBasketItems(Email, ProductId, Quantity, UserId, Total, BasketId, (int)SellingPrice,
            //                                             ItemId);
            //}
            return true;
        }
    }
}
