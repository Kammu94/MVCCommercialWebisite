using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileSiteDataLayer;
using MobileSiteBusinessEntities;

namespace MobileSiteBusinessLogic
{
    public class UserAccountServices
    {
        UserAccountRepository Add = new UserAccountRepository();

        public Respnose Index(Guid UserId, string FirstName, string LastName, string Email, string Password, string Gender, string Country, string ContactNumber)
        {
            return Add.Index(UserId, FirstName, LastName, Email, Password, Gender, Country,ContactNumber);
          
        }
        public List<SiteUserEntities> GetLoginDetails(string Email, string Password)
        {
            return Add.GetLoginDetails( Email,Password);
        }
        public Respnose AdminLogin(string Email, string Password)
        {
            return Add.AdminLogin(Email, Password);
        }

    }
}
