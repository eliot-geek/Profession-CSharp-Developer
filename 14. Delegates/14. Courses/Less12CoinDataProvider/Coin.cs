using System;
using System.Collections.Generic;
using System.ComponentModel;        // "Add this for direct updates (no need to click 'update')."
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less12CoinDataProvider
{
    //class Coin        "Using this, there is a need to click on 'update'."
    //{
    //    public string CoinName { get; set; }
    //    public double Delta { get; set; }
    //    public double Value { get; set; }
    //}

    #region ToDo  - Add this for direct updates (no need to click 'update')

    /// <summary>
    /// Represents a coin with its name, value, and delta.
    /// </summary>
    internal class Coin : INotifyPropertyChanged
    {
        /// <summary>
        /// Event triggered when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public string coinName;

        /// <summary>
        /// Gets or sets the name of the coin.
        /// </summary>
        public string CoinName
        {
            //get => this.coinName;

            get { return this.coinName; }
            set
            {
                this.coinName = value;

                // Notify subscribers that the CoinName property has changed.
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.CoinName)));
            }
        }

        public double delta;

        /// <summary>
        /// Gets or sets the change in value of the coin.
        /// </summary>
        public double Delta
        {
            get { return this.delta; }
            set
            {
                this.delta = value;

                // Notify subscribers that the Delta property has changed.
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Delta)));
            }
        }

        public double value;

        /// <summary>
        /// Gets or sets the value of the coin.
        /// </summary>
        public double Value
        {
            get { return this.value; }
            set
            {
                this.value = value;

                // Notify subscribers that the Value property has changed.
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Value)));
            }
        }
    }

    #endregion
}

