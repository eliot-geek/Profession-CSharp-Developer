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
using System.Windows.Threading;

namespace Less11TimerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Represents the current time as a string.
        /// </summary>
        private string sTime;

        /// <summary>
        /// Gets or sets the string representation of the current time.
        /// </summary>
        public string Time
        {
            get { return sTime; }
            set { sTime = value; }
        }

        /// <summary>
        /// DispatcherTimer for updating the time display at regular intervals.
        /// </summary>
        private DispatcherTimer timer;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // Initialize the DispatcherTimer with a one-second interval.
            timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 0, 1)
            };

            // Set the initial time string to empty.
            sTime = String.Empty;

            // Attach the TimerTick method to the Tick event of the timer.
            timer.Tick += TimerTick;

            // Start the timer.
            timer.Start();
        }

        /// <summary>
        /// Event handler for the timer Tick event.
        /// Updates the Time property and the text block displaying the time.
        /// </summary>
        private void TimerTick(object sender, EventArgs e)
        {
            Time = DateTime.Now.ToLongTimeString();
            tbTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
