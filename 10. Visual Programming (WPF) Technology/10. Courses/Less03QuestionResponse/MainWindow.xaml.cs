using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Less03QuestionResponse
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

        // Event handler for the "Yes" TextBlock's MouseDown event
        private void Yes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Display a MessageBox with a response
            MessageBox.Show($"Of course! I am familiar with C#");
        }

        // Event handler for the "No" TextBlock's MouseDown event
        private void No_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Retrieve the current positions of "Yes" and "No" TextBlocks
            var positionLeftYes = Canvas.GetLeft(Yes);
            var positionLeftNo = Canvas.GetLeft(No);

            // Swap the positions of "Yes" and "No" TextBlocks
            Canvas.SetLeft(Yes, positionLeftNo);
            Canvas.SetLeft(No, positionLeftYes);

            // Play a system sound (hand icon) to indicate the action
            SystemSounds.Hand.Play();
        }

    }
}
