using MobileSiteBusinessEntities.ModelsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSiteDataLayer.Implementation
{
    public class BasketRepository
    {
        public BasketEntities AddToCart(BasketEntities basket)
        {

            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.ProcInsertBasketItems(basket.ProductId, basket.Quantity, basket.UserId, Convert.ToInt32(basket.GrandTotal), basket.BasketId,
                                                                   basket.BasketHeaderId, Convert.ToInt32(basket.SellingPrice), basket.StockCode)
                            select new BasketEntities
                            {
                                BasketId = o.BasketId.GetValueOrDefault()

                            }
                               ).FirstOrDefault();
                return repo;
            }

        }
        public BasketEntities IsBasketexisted(BasketEntities basket)
        {

            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.procIsBasketExisted(basket.UserId)
                            select new BasketEntities
                            {
                                BasketHeaderId = o.Id.GetValueOrDefault(),
                                isValid = o.IsExisted

                            }
                               ).FirstOrDefault();
                return repo;
            }
        }
            public List<BasketEntities> GetUserBasket(Guid userId)
            {

                using (var ConStr = ConnectionHandler.GetConString())
                {
                    var repo = (from o in ConStr.procGetUserBasketItems(userId)
                                select new BasketEntities
                                {
                                    ProductName = o.ProductName,
                                    ProductId = o.ProductId.GetValueOrDefault(),
                                    Quantity = o.Quantity.GetValueOrDefault(),
                                    SellingPrice = o.Price.GetValueOrDefault(),
                                    Image = o.SecondImage,
                                    BasketHeaderId=o.BaketHeaderId.GetValueOrDefault(),
                                    Message=o.Description,
                                    LineTotal=o.Total.GetValueOrDefault(),
                                    BasketId=o.Id.GetValueOrDefault()
                                    
                                }
                                   ).ToList();
                    return repo;
                }

            }
        
         public BasketEntities DeleteUserBasket(BasketEntities basket)
        {

            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.procDeleteUserBasket(basket.UserId,basket.BasketHeaderId,basket.BasketId,basket.ProductId)
                            select new BasketEntities
                            {
                                
                                isValid = o.IsValid

                            }
                               ).FirstOrDefault();
                return repo;
            }
        }
    }
    }

