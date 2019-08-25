using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SmartMobilesStore.Models
{
    public class UserAccountLoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }
        public bool? isValid { get; set; }
     
    }
   
}