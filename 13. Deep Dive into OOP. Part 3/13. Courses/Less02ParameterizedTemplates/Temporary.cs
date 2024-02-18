using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less02ParameterizedTemplates
{
    /// <summary>
    /// Represents a generic class for storing a temporary value of any type.
    /// </summary>
    /// <typeparam name="Template">The type of the temporary value.</typeparam>
    internal class Temporary<Template>
    {
        /// <summary>
        /// Gets or sets the temporary property.
        /// </summary>
        public Template Property { get; set; }

        /// <summary>
        /// Constructor to initialize the temporary property.
        /// </summary>
        /// <param name="Value">The value to set for the temporary property.</param>
        public Temporary(Template Value)
        {
            Property = Value;
        }

        /// <summary>
        /// Displays information about the type and value of the temporary property.
        /// </summary>
        public void GetPropertyInformation()
        {
            Console.WriteLine($"Type: {Property.GetType(),14} Value: {Property,7}");
        }
    }
}
