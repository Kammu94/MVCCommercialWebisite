using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSiteBusinessEntities.ModelsEntities
{
    class OrderEntities
    {
        public class OrderModels : ProductDetailEntities
        {
            public Guid ItemId { get; set; }

            public int Quantity { get; set; }
            public Guid BasketId { get; set; }
            public int Total { get; set; }
            public string DateOfCreation { get; set; }
        }
    }
}
