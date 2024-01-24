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

namespace Less02MoveCursorColor
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

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Change the fill color to blue when the mouse button is pressed down
            Rectangle.Fill = Brushes.Blue;
        }

        private void Rectangle_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Rectangle.Fill = Brushes.Yellow;
        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            Rectangle.Fill = Brushes.Black;
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle.Fill = Brushes.Aqua;
        }
    }
}
