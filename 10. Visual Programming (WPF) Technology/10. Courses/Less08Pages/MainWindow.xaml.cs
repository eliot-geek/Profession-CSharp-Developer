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

namespace Less08Pages
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Page1 p1 = new Page1();
        Page2 p2 = new Page2();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnPage1Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = new Page1();
            MainFrame.Content = p1;
        }

        private void BtnPage2Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = new Page2();
            MainFrame.Content = p2; 
        }

    }
}
