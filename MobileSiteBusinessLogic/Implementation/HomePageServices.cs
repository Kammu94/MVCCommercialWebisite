using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileSiteDataLayer;
using MobileSiteBusinessEntities;
using MobileSiteBusinessEntities.ModelsEntities;

namespace MobileSiteBusinessLogic
{
    public  class HomePageServices
    {
        HomePageRepository Add = new HomePageRepository();

        public List<ProductDetailEntities> GetNewProductsList()
        {
            return Add.GetNewProductsList();
        }
        public List<ProductDetailEntities> GetListOfProducts()
        {
            return Add.GetListOfProducts();
        }
        public  ProductDetailEntities DescriptionPage(Guid ProductId)
        {
            return Add.DescriptionPage(ProductId);
        }
        //It will get the list of products on products page
        public List<ProductDetailEntities> GetProductsList()
        {
            return Add.GetProductsList();

        }
//        List<string> list = new List<string>(); // { "This ", "is ", "your ", "string!"};
//        list.Add("This ");
//list.Add("is ");
//list.Add("your ");
//list.Add("string!");

//string concat = String.Join(" ", list.ToArray());
        //GetColorFilteredProductsList
        public List<ProductDetailEntities> GetProductsByColor(List<FilterPropertiesEntities> filters)
        {
            var SelectedFilter = filters.Where(i => i.SelectedFilter!=null).ToArray();
            var SelectedFilter1 = "";
            if (SelectedFilter.Length == 0) { SelectedFilter1 = ""; } else { SelectedFilter1 = SelectedFilter[0].SelectedFilter.ToString(); }
            string filterColors = String.Join(",", filters.Select(i=>i.FilterName));
            //string filterColors = a.Trim('\'');
            
            return Add.GetProductsByColor(filterColors, SelectedFilter1);

        }
        //public BasketEntities AddToBasket(BasketEntities basket)
        //{


        //    return Add.AddToBasket(basket);
        //}
        public bool DeleteSelectedFilter(Guid id)
        { 
            return Add.DeleteSelectedFilter(id);

        }
        public List<FilterPropertiesEntities> GetSelectedFilter()
        {
            return Add.GetSelectedFilter();

        }

    }
}
