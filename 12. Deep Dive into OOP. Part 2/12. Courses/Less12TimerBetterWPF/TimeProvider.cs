using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Less12TimerBetterWPF
{
    /// <summary>
    /// A class providing time-related functionality and implementing the INotifyPropertyChanged interface.
    /// </summary>
    internal class TimeProvider : INotifyPropertyChanged
    {
        private DispatcherTimer timer;
        private string sTime;

        /// <summary>
        /// Event triggered when a property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the formatted time string.
        /// Notifies subscribers when the Time property changes.
        /// </summary>
        public string Time
        {
            get { return sTime; }
            set
            {
                sTime = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Time)));
            }
        }

        /// <summary>
        /// Initializes a new instance of the TimeProvider class.
        /// Sets up a timer to update the time every second.
        /// </summary>
        public TimeProvider()
        {
            timer = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 0, 1)
            };

            sTime = String.Empty;

            timer.Tick += TimerTick;
            timer.Start();
        }

        /// <summary>
        /// Event handler for the timer tick, updating the Time property with the current time.
        /// </summary>
        private void TimerTick(object sender, EventArgs e)
        {
            Time = DateTime.Now.ToLongTimeString();
        }
    }
}
