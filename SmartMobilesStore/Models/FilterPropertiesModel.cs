using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartMobilesStore.Models
{
    public class FilterPropertiesModel
    {
        public string FilterName { get; set; }
        public Guid Id { get; set; }
        public string FilterType { get; set; }
        public bool IsValid { get; set; }
    }
}