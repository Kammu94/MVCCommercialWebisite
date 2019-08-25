using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileSiteBusinessEntities;
using MobileSiteBusinessEntities.ModelsEntities;
using MobileSiteDataLayer;


namespace MobileSiteDataLayer
{
    public class HomePageRepository
    {
        //this function is use to show the latest products in Latest Products blog on homepage
        public List<ProductDetailEntities> GetNewProductsList()

        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.ProcGetLatestProducts()
                            select new ProductDetailEntities
                            {
                                ProductId = o.ProductId,
                                ProductName = o.ProductName,
                                SellingPrice = (float)o.SellingPrice,

                                OperatingSystem = o.OperatingSystem,



                                SecondImage = o.SecondImage


                            }
                           ).ToList();
                return repo;
            }

        }
        public List<ProductDetailEntities> GetListOfProducts()
        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.ProcGetProductList()
                            select new ProductDetailEntities
                            {

                                ProductName = o.ProductName,
                                SellingPrice = (float)o.SellingPrice,

                                OperatingSystem = o.OperatingSystem,



                                SecondImage = o.SecondImage


                            }
                           ).ToList();
                return repo;
            }
        }
        public ProductDetailEntities DescriptionPage(Guid ProductId)
        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.ProcGetProductPageDetails(ProductId)
                            select new ProductDetailEntities
                            {
                                ProductId = o.ProductId,
                                ProductName = o.ProductName,
                                SellingPrice = (float)o.SellingPrice,
                                Color = o.Color,
                                OperatingSystem = o.OperatingSystem,
                                Rating = (int)o.Rating,

                                SecondImage = o.SecondImage,
                                Description = o.Description



                            }
                           ).FirstOrDefault();
                return repo;
            }

        }
        public bool Index(Guid UserId, string FirstName, string LastName, string Email, string Password, string Gender, string Country, string ContactNumber)
        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repos = ConStr.ProcInsertSiteUserCredentials(UserId, FirstName, LastName, Email, Password, Gender, Country, ContactNumber);
            }
            return true;
        }


        public List<ProductDetailEntities> GetProductsList()
        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.ProcGetProductListBulk()
                            select new ProductDetailEntities
                            {
                                ProductId = o.ProductId,
                                ProductName = o.ProductName,
                                SellingPrice = (float)o.SellingPrice,

                                OperatingSystem = o.OperatingSystem,
                                SecondImage = o.SecondImage,
                                //Rating = (int)o.Rating




                            }
                           ).ToList();
                return repo;
            }
        }
        //GetBlueColorFilteredProductsList
        public List<ProductDetailEntities> GetProductsByColor(string filters,string SelectedFilter)
        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.procGetProductsBycolor(filters, SelectedFilter)
                            select new ProductDetailEntities
                            {

                                ProductName = o.ProductName,
                                SellingPrice = (float)o.SellingPrice,

                                OperatingSystem = o.OperatingSystem,
                                SecondImage = o.SecondImage,
                                Rating = (int)o.Rating,
                                Color = o.Color


                            }
                               ).ToList();
                return repo;
            }
        }

        public List<FilterPropertiesEntities> GetSelectedFilter()
        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.procGetSelectedFilters()
                            select new FilterPropertiesEntities
                            {

                                FilterName = o.filtername,
                                Id = o.Id

                            }
                               ).ToList();
                return repo;
            }

        }
        public bool DeleteSelectedFilter(Guid id)
        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.procDeleteSelectedFilters(id)
                            select new FilterPropertiesEntities
                            {
                                IsValid=o.IsValid.GetValueOrDefault()
                            }
                               ).FirstOrDefault();
                return true;
            }

        }
    }
}


