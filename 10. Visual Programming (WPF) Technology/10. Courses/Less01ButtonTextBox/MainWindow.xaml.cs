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

namespace Less01ButtonTextBox
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
            // Check if the TextBox is empty
            if (String.IsNullOrEmpty(TextName.Text))
            {
                // Show a message box with information about the empty TextBox
                MessageBox.Show(
                    "Empty",
                    this.Title,  // Window title
                    MessageBoxButton.YesNo,  // Button configuration
                    MessageBoxImage.Information  // Information icon
                );
            }
            else
            {
                // Show a personalized greeting in a message box
                MessageBox.Show(
                    $"Hello, {TextName.Text}!",
                    this.Title,  // Window title
                    MessageBoxButton.YesNo,  // Button configuration
                    MessageBoxImage.Information  // Information icon
                                                 //MessageBoxImage.Warning  // Icon (Stop - Exclamation - Question and others)
                );
            }
        }
    }
}
