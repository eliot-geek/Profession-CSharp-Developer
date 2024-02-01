using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClientDataManagement.Models.Base
{
    /// <summary>
    /// Base class with INotifyPropertyChanged implementation
    /// </summary>
    public abstract class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Event for notification of a property change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method for calling a property change notification event
        /// </summary>
        /// <param name="propertyName">Changed property</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// A virtual method that determines changes in the value of a property value field
        /// </summary>
        /// <param name="fieldProperty">Reference to the property value field</param>
        /// <param name="newValue">New value</param>
        /// <param name="propertyName">Property's Name</param>
        protected virtual bool Set<T>(ref T fieldProperty, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (Equals(fieldProperty, newValue)) return false;
            fieldProperty = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
