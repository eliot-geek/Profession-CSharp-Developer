using ClientDataManagement.ClientLibrary.Model;

namespace ClientDataManagement.Interfaces
{
    /// <summary>
    /// Represents an interface for viewing customer information.
    /// </summary>
    internal interface IClientVew
    {
        /// <summary>
        /// Gets or sets the selected customer.
        /// </summary>
        Client SelectedClient { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the mode is set to view customer information.
        /// </summary>
        bool IsModeView { get; set; }
    }

}
