using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperationsPlatform
{
    /// <summary>
    /// Represents a log for storing messages.
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Collection to store log messages.
        /// </summary>
        public ObservableCollection<string> logFile = new ObservableCollection<string>();

        /// <summary>
        /// Adds a message to the log.
        /// </summary>
        /// <param name="msg">The message to add to the log.</param>
        public void AddToLog(string msg)
        {
            logFile.Add(msg);
        }
    }
}
