using MySql.Data.EntityFramework;
using System.Data.Entity;
using System.Globalization;

namespace EFDCS.Database
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EFContext : DbContext
    {
        public EFContext() : base(App.ConnectionString.FormedConnectionString) //Using a connection string from a static object
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            Database.CreateIfNotExists();
        }
    }
}
