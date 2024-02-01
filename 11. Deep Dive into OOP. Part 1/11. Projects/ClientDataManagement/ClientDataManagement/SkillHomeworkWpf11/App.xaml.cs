using System.Diagnostics;
using System.Windows;

namespace ClientDataManagement
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Exit(object sender, ExitEventArgs e)
        {
            this.Startup += new StartupEventHandler(App_Startup);
        }
        private void App_Startup(object sender, StartupEventArgs e)
        {
            Debug.WriteLine("------> Startup");
        }
    }
}
