using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Less09DynamicData
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Worker> db = new ObservableCollection<Worker>(); // It's better to use this
        //List<Worker> db = new List<Worker>();

        public MainWindow()
        {
            InitializeComponent();
            listDbView.ItemsSource = db;
        }

        int count = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            db.Add(new Worker()
            {
                Name = $"Name {++count}",
                Age = 20 + count,
                Salary = 1000 * count
            });

            this.Title = $"db.Count = {db.Count}"; // On the window's head
            listDbView.Items.Refresh(); // Delete all and reprint
        }
    }
}
