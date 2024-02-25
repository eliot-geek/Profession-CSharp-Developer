using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Less12CoinDataProvider
{
    /// <summary>
    /// Represents a data provider for coin values.
    /// </summary>
    internal class DataProvider
    {
        // Timer for updating coin values.
        DispatcherTimer timer;

        // Collection of coin data.
        public ObservableCollection<Coin> Data;

        Random r = new Random();

        /// <summary>
        /// Constructs a new instance of the DataProvider class.
        /// </summary>
        public DataProvider()
        {
            r = new Random();

            // Initialize the collection of coin data with some initial values
            Data = new ObservableCollection<Coin>()
            {
                new Coin(){ CoinName = "GBP", Value = 78},
                new Coin(){ CoinName = "USD", Value = 63},
                new Coin(){ CoinName = "EUR", Value = 70},
                new Coin(){ CoinName = "AUD", Value = 44},
                new Coin(){ CoinName = "JPY", Value = 58},
                new Coin(){ CoinName = "SEK", Value = 67},
            };

            // Set up and start the timer for updating coin values
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Event handler for the timer tick event.
        /// Updates the coin values and deltas.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Iterate over each coin data and update its value and delta
            for (int i = 0; i < this.Data.Count; i++)
            {
                double d = r.Next(-5, 6);
                Data[i].Value += d;
                Data[i].Delta = d;
            }

            foreach (var item in Data) Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}
