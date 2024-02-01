using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDataManagement.Change
{
    /// <summary>
    /// Represents a record of data change.
    /// </summary>
    public class ChangeType
    {
        /// <summary>
        /// Gets or sets the date and time of the record change.
        /// </summary>
        public string DateTimeChanged { get; set; }

        /// <summary>
        /// Gets or sets the field that was changed.
        /// </summary>
        public EnumTypeField DataChanged { get; set; }

        /// <summary>
        /// Gets or sets the type of change.
        /// </summary>
        public string TypeChanged { get; set; }

        /// <summary>
        /// Gets or sets the type of user who changed the data.
        /// </summary>
        public EnumTypeUser UserType { get; set; }
    }

}
