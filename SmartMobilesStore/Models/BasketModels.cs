using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMobilesStore.Models
{
    public class BasketModels:ProductDetailModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal Price { get; set; }
        public Guid ItemId { get; set; }
        public Guid BasketHeaderId { get; set; }
        public string StockCode { get; set; }
    }
}