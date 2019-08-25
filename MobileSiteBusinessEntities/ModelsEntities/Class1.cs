using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSiteBusinessEntities.ModelsEntities
{
    public class FilterPropertiesEntities
    {
        public string FilterName { get; set; }
        public Guid Id { get; set; }
        public string FilterType { get; set; }
        public bool IsValid { get; set; }
        public string SelectedFilter { get; set; }
        
    }
}
