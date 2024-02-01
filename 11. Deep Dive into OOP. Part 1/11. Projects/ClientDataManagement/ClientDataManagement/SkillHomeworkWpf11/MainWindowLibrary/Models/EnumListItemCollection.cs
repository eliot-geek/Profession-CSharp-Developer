using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Resources;

namespace ClientDataManagement.Models
{
    /// <summary>
    /// Represents a collection of EnumListItem associated with a specified Enum type.
    /// </summary>
    /// <typeparam name="T">The Enum type.</typeparam>
    public class EnumListItemCollection<T> : ObservableCollection<EnumListItem> where T : struct
    {
        readonly ResourceManager resourceManager;
        readonly CultureInfo cultureInfo;
        readonly Type enumType;
        readonly Type resourceType;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumListItemCollection{T}"/> class using the current UI culture.
        /// </summary>
        public EnumListItemCollection() : this(CultureInfo.CurrentUICulture)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumListItemCollection{T}"/> class using the specified culture.
        /// </summary>
        /// <param name="cultureInfo">The culture for resource localization.</param>
        public EnumListItemCollection(CultureInfo cultureInfo)
        {
            if (!typeof(T).IsEnum)
                throw new NotSupportedException(String.Format("{0} is not Enum!", typeof(T).Name));

            enumType = typeof(T);
            this.cultureInfo = cultureInfo;

            resourceType = GetResourceTypeFromEnumType();
            if (resourceType != null)
                resourceManager = new ResourceManager(resourceType.FullName, resourceType.Assembly);

            foreach (T item in Enum.GetValues(enumType))
                Add(new EnumListItem() { Value = item, DisplayValue = GetEnumDisplayValue(item) });
        }

        /// <summary>
        /// Retrieves the resource type associated with the Enum type.
        /// </summary>
        /// <returns>The resource type or null if not found.</returns>
        Type GetResourceTypeFromEnumType()
        {
            var manifestResourceName =
            this.enumType.Assembly.GetManifestResourceNames().FirstOrDefault
                (t => t.Contains(this.enumType.Name));

            if (!String.IsNullOrEmpty(manifestResourceName))
                return Type.GetType(manifestResourceName.Replace(".resources",
                    String.Empty), (a) => this.enumType.Assembly,
                    (a, n, i) => this.enumType.Assembly.GetType(n, false, i));
            return null;
        }

        /// <summary>
        /// Retrieves the display value for the specified Enum item.
        /// </summary>
        /// <param name="item">The Enum item.</param>
        /// <returns>The display value.</returns>
        String GetEnumDisplayValue(T item)
        {
            var value = default(String);

            if (resourceManager != null)
                value = resourceManager.GetString(item.ToString(), cultureInfo);

            if (value == null)
            {
                var descriptionAttribute = (item as Enum).GetAttribute<DescriptionAttribute>();
                if (descriptionAttribute == null)
                    return item.ToString();
                return descriptionAttribute.Description;
            }
            return value;
        }
    }
}
