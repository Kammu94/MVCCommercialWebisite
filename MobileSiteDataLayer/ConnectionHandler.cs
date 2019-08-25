using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MobileSiteDataLayer
{
    public class ConnectionHandler
    {
        private static readonly string connectionString = string.Empty;

        static ConnectionHandler()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MobileSiteDatabaseConnectionString"].ConnectionString;


        }
        public static LinqToSqlDataContext GetConString()
        {
            var ConStr = new LinqToSqlDataContext(connectionString);
            return ConStr;

        }
    }
}
