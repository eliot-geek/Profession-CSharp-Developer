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

namespace Less10WorkerRepository
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //Repository rep;
        //public MainWindow()
        //{
        //    InitializeComponent();

        //    rep = new Repository(50);
        //    listView.ItemsSource = rep.Workers;

        //    this.Title = $"All workers: {rep.Workers.Count}";
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    rep.DeleteWorkerBySalary(20000);
        //    this.Title = $"All workers: {rep.Workers.Count}";
        //    listView.Items.Refresh();
        //}
    }
}
