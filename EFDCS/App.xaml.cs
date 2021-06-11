using EFDCS.Database;
using EFDCS.Models;
using System.Windows;

namespace EFDCS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ConnectionHelper ConnectionHelper { get; set; } = new ConnectionHelper();
        public static ConnectionString ConnectionString { get; set; } = ConnectionHelper.GetConnectionString(); //Creates a ConnectionString object with parameters from a file
        //public static EFContext DB { get; set; } = new EFContext(); //Uncoment after creating and configure config.json file
    }
}
