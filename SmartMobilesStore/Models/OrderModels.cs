using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMobilesStore
{
    public class OrderModels:ProductDetailModel
    {
        public Guid ItemId { get; set; }

        public int Quantity { get; set; }
        public Guid BasketId { get; set; }
        public int Total { get; set; }
        public DateTime DateOfCreation { get; set; }
        public Guid UserId { get; set; }
        public string Email { get; set; }
    }
}