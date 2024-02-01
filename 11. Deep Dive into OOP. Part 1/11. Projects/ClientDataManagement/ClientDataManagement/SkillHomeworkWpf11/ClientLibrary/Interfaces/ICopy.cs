
namespace ClientDataManagement.Interfaces
{
    /// <summary>
    /// Represents an interface for creating a copy of an instance of the same type
    /// and copying values to or from another instance.
    /// </summary>
    /// <typeparam name="T">The type of the instance.</typeparam>
    public interface ICopy<T>
    {
        /// <summary>
        /// Creates a copy of the instance.
        /// </summary>
        /// <returns>A new instance of the same type.</returns>
        T Copy();

        /// <summary>
        /// Copies instance values to another instance.
        /// </summary>
        /// <param name="other">Another instance to copy the values to.</param>
        void CopyTo(T other);

        /// <summary>
        /// Copies instance values from another instance.
        /// </summary>
        /// <param name="other">Another instance from which to copy the values.</param>
        void CopyFrom(T other);
    }
}
