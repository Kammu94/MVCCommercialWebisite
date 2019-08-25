using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileSiteDataLayer;
using MobileSiteBusinessEntities;


namespace MobileSiteBusinessLogic
{
    public class MobileSiteServices
    {
        MobileSiteRepository Add = new MobileSiteRepository();

        public bool Submit(Guid ProductId, string ProductName, Decimal SellingPrice, Decimal MarketPrice, int Stock,
           string Description, DateTime DateOfInsert, int Rating, string OperatingSystem, string Color, bool IsAvailable,
           string FirstImage, string SecondImage, string ThirdImage)
        {
            Add.Submit(ProductId, ProductName, SellingPrice, MarketPrice, Stock, Description, DateOfInsert, Rating,
                OperatingSystem, Color, IsAvailable, FirstImage, SecondImage, ThirdImage);

            return true;
        }
        public List<ProductDetailEntities> GetProducts()
        {
            return Add.GetProducts();
        }
        public bool DeleteUser(Guid ProductId)
        {
            Add.DeleteUser(ProductId);
            return true;


        }
        //EditProduct service method
        public bool  EditProduct(Guid ProductId)
        {
           return Add.EditProduct(ProductId);
            

        }

    }
}
