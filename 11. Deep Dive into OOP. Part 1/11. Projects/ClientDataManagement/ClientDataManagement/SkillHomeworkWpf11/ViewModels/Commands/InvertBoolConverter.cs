using System;
using System.Globalization;
using System.Windows.Data;

namespace ClientDataManagement.ViewModels.Commands
{
    /// <summary>
    /// Converter class for inverting boolean values, implementing IValueConverter.
    /// </summary>
    public class InvertBoolConverter : IValueConverter
    {
        /// <summary>
        /// Converts a boolean value to its inverse.
        /// </summary>
        /// <param name="value">The boolean value to convert.</param>
        /// <param name="targetType">The type of the target property.</param>
        /// <param name="parameter">An optional parameter for additional logic.</param>
        /// <param name="culture">The culture to use for the conversion.</param>
        /// <returns>The inverted boolean value.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool val = (bool)value;
            return !val;
        }

        /// <summary>
        /// Converts an inverted boolean value back to its original state.
        /// </summary>
        /// <param name="value">The inverted boolean value to convert back.</param>
        /// <param name="targetType">The type of the target property.</param>
        /// <param name="parameter">An optional parameter for additional logic.</param>
        /// <param name="culture">The culture to use for the conversion.</param>
        /// <returns>The original boolean value.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool val = (bool)value;
            return !val;
        }
    }
}
