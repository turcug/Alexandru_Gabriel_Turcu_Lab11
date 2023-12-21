using Turcu_Alexandru_Gabriel_Lab11.Data;
using Turcu_Alexandru_Gabriel_Lab11.Models;

namespace Turcu_Alexandru_Gabriel_Lab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
