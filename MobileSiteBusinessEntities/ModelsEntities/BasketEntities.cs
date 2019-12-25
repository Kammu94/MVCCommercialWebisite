using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSiteBusinessEntities.ModelsEntities
{
   public  class BasketEntities:SiteUserEntities
    {
        public Guid BasketId { get; set; }
        public Guid ProductId{get;set;}
        public int Quantity { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal SellingPrice { get; set; }
        public Guid ItemId { get; set; }
        public Guid BasketHeaderId { get; set; }
        public string StockCode { get; set; }
        public string ProductName { get; set; }
        public string operatingSystem { get; set; }
        public string Image { get; set; }
        public decimal LineTotal { get; set; }
        


    }
}
