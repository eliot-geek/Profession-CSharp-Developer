using System;

namespace Less03DelegateAPIService
{
    /// <summary>
    /// Represents a class responsible for processing data.
    /// </summary>
    internal class DataProcessing
    {
        private string currentData;

        private OptionDataProcessing process;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataProcessing"/> class with the specified current data.
        /// </summary>
        /// <param name="CurrentData">The current data to be processed.</param>
        public DataProcessing(string CurrentData)
        {
            this.currentData = CurrentData;
        }

        /// <summary>
        /// Sets the processing option for the data.
        /// </summary>
        /// <param name="Option">The processing option to be set.</param>
        public void SetProcess(OptionDataProcessing Option)
        {
            this.process = Option;
        }

        /// <summary>
        /// Executes the data processing action based on the set processing option.
        /// </summary>
        public void ActionProcessing()
        {
            process(this.currentData);
        }
    }
}
