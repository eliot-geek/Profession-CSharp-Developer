using System;
using System.Linq;

namespace ClientDataManagement.Models
{
    /// <summary>
    /// A static class containing extensions for working with attributes on Enum values.
    /// </summary>
    public static class AttributeExtensions
    {
        /// <summary>
        /// Retrieves the specified attribute associated with an Enum value.
        /// </summary>
        /// <typeparam name="TAttribute">The type of the attribute to retrieve.</typeparam>
        /// <param name="enumValue">The Enum value.</param>
        /// <returns>The specified attribute or null if not found.</returns>
        public static TAttribute GetAttribute<TAttribute>(this Enum enumValue) where TAttribute : Attribute
        {
            var memberInfo = enumValue.GetType()
                                .GetMember(enumValue.ToString())
                                .FirstOrDefault();

            if (memberInfo != null)
                return (TAttribute)memberInfo.GetCustomAttributes(typeof(TAttribute), false).FirstOrDefault();
            return null;
        }
    }
}
