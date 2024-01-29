using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace TelegramBotUserInterface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyTelegramBot bot;

        [Obsolete]
        public MainWindow()
        {
            InitializeComponent();
            StartBot();
        }

        private void StartBot()
        {
            try
            {
                var tokenFilePath = "token";
                if (File.Exists(tokenFilePath))
                {
                    bot = new MyTelegramBot(this, File.ReadAllText(tokenFilePath));
                    if (bot.Start())
                        Debug.WriteLine($"Launch the bot {bot.Name}");
                    LogList.ItemsSource = bot.UserList;
                    UserList.ItemsSource = bot.UserList;
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
            Console.ReadLine();
        }

        private void btnMsgSendClick(object sender, RoutedEventArgs e)
        {
            if (bot != null)
                bot.SendMessage(txtMsgSend.Text);

        }

        private void SaveHistory_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JavaScript Object Notation(*.json)|*.json",
                RestoreDirectory = true
            };
            saveFileDialog.ShowDialog();
            var file = saveFileDialog.FileName;

            string json = JsonConvert.SerializeObject(bot);
            LogList.ItemsSource = bot.UserList;
            UserList.ItemsSource = bot.UserList;
            System.IO.File.WriteAllText(file, json);
        }
    }
}
