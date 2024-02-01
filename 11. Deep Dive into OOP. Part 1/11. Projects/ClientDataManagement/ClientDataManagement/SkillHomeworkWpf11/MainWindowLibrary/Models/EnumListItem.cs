
namespace ClientDataManagement.Models
{
    /// <summary>
    /// Represents an item in a list associated with an Enum, containing both a value and a display text.
    /// </summary>
    public class EnumListItem
    {
        /// <summary>
        /// Gets or sets the value associated with the EnumListItem.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets the display text associated with the EnumListItem.
        /// </summary>
        public string DisplayValue { get; set; }
    }
}
