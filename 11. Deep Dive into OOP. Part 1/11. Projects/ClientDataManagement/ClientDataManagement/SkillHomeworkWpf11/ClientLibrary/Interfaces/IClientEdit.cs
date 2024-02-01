using ClientDataManagement.ClientLibrary.Model;

namespace ClientDataManagement.Interfaces
{
    /// <summary>
    /// Represents an interface for editing customer information.
    /// </summary>
    public interface IClientEdit
    {
        /// <summary>
        /// Gets or sets the selected customer.
        /// </summary>
        Client SelectedClient { get; set; }

        /// <summary>
        /// Gets the edited customer.
        /// </summary>
        Client EditClient { get; }

        /// <summary>
        /// Gets a value indicating whether the mode is set to edit customer information.
        /// </summary>
        bool IsModeEdit { get; }
    }
}
