using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kinvey;

namespace DotNET_Starter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string app_key = "";
        string app_secret = "";
        string username = "";
        string password = "";

        public MainWindow()
        {
            InitializeComponent();
            initClient();
        }

        public override void EndInit()
        {
            base.EndInit();
        }

        public async Task<Client> initClient()
        {
            Client kinveyClient = null;

            string filePath = System.IO.Directory.GetCurrentDirectory();
            Client.Builder builder = new Client.Builder(app_key, app_secret)
             .setFilePath(filePath)
             .setOfflinePlatform(new SQLite.Net.Platform.Win32.SQLitePlatformWin32())
             .setLogger(delegate (string msg) { Console.WriteLine(msg); });

            try
            {
                kinveyClient = await builder.Build();
            }
            catch (Exception e)
            {
                string msg = e.Message;
            }

            PingResponse pr = await kinveyClient.PingAsync();

            // Login
            try
            {
                if (!kinveyClient.IsUserLoggedIn())
                {
                    User u = await User.LoginAsync(username, password);
                }
            }
            catch (Exception e)
            {
                string msg = e.Message;
            }

            // DataStore access
            List<Book> books = null;
            try
            {
                var store = DataStore<Book>.Collection("books", DataStoreType.NETWORK, kinveyClient);
                books = await store.FindAsync();
            }
            catch (KinveyException ke)
            {
                string msg = ke.Message;
            }
            catch (Exception e)
            {
                string msg = e.Message;
            }

            return kinveyClient;
        }
    }
}