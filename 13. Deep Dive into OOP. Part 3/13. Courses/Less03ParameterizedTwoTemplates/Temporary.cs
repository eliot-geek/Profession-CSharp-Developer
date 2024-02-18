using System;

namespace Less03ParameterizedTwoTemplates
{
    /// <summary>
    /// Represents a generic class for storing two temporary values of different types.
    /// </summary>
    /// <typeparam name="Template1">The type of the first temporary property.</typeparam>
    /// <typeparam name="Template2">The type of the second temporary property.</typeparam>
    internal class Temporary<Template1, Template2>
    {
        /// <summary>
        /// Gets or sets the first temporary property.
        /// </summary>
        public Template1 Property1 { get; set; }

        /// <summary>
        /// Gets or sets the second temporary property.
        /// </summary>
        public Template2 Property2 { get; set; }

        /// <summary>
        /// Constructor to initialize both temporary properties.
        /// </summary>
        /// <param name="Value1">The value to set for the first temporary property.</param>
        /// <param name="Value2">The value to set for the second temporary property.</param>
        public Temporary(Template1 Value1, Template2 Value2)
        {
            Property1 = Value1;
            Property2 = Value2;
        }

        /// <summary>
        /// Displays information about the types and values of both temporary properties.
        /// </summary>
        public void GetPropertyInformation()
        {
            Console.WriteLine($"Type Property1: {Property1.GetType(),14} Value1: {Property1,7}");
            Console.WriteLine($"Type Property2: {Property2.GetType(),14} Value2: {Property2,7}");
        }
    }
}
