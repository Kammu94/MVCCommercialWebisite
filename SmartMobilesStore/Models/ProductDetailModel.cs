using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMobilesStore             
{
    public class ProductDetailModel
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public float SellingPrice { get; set; }
        public float MarketPrice { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public DateTime DateOfInsert { get; set; }
        public int Rating { get; set; }
        public string OperatingSystem { get; set; }
        public string Color { get; set; }
        public bool IsAvailable { get; set; }
        public string FirstImage { get; set; }
        public string SecondImage { get; set; }
        public string ThirdImage { get; set; }








    }
}