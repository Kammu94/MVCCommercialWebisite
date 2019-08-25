using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileSiteBusinessEntities
{
    public class SiteUserEntities : Respnose
    {
        public Guid UserId { get; set; }
        
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
        
        public string Email { get; set; }
    
        public string Password { set; get; }
     
        public Decimal ContactNumber { get; set; }
      
        public string Gender { get; set; }
        
        public string Country { get; set; }




    }
}
