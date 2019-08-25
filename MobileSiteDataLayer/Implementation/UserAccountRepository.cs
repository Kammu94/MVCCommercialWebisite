using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileSiteBusinessEntities;

namespace MobileSiteDataLayer
{
   public  class UserAccountRepository
    {

        public Respnose Index(Guid UserId, string FirstName, string LastName, string Email, string Password, string Gender, string Country, string ContactNumber)
        {
            var resp = new Respnose { };
            using (var ConStr = ConnectionHandler.GetConString())
            {
                resp = (from o in ConStr.ProcInsertSiteUserCredentials(UserId, FirstName, LastName, Email, Password, Gender, Country, (string)ContactNumber)
                             select new Respnose
                             {
                                 Message = o.Message,
                                 isValid = o.isValid
                             })
                             .FirstOrDefault();
              
            }
            return resp;
        }
        public List<SiteUserEntities> GetLoginDetails(string Email,string Password)

        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.ProcGetLoginCredentials(Email, Password)
                            select new SiteUserEntities
                            {
                               
                                Message=o.Message,
                                isValid=(bool)o.IsValid,
                                UserId=(Guid)o.UserId

                            }
                           ).ToList();
                return repo;
            }

        }
        public Respnose AdminLogin(string Email, string Password)

        {
            using (var ConStr = ConnectionHandler.GetConString())
            {
                var repo = (from o in ConStr.procGetAdminCredentials(Email, Password)
                            select new Respnose
                            {

                                Message = o.Message,
                                isValid = (bool)o.isvalid,
                                

                            }
                           ).FirstOrDefault();
                return repo;
            }

        }

    }
}
