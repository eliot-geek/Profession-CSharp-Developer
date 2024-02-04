namespace Less20IEnumerator
{
    /// <summary>
    /// IEnumerable Interface
    /// </summary>
    public interface IEnumerable
    {
        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An IEnumerator object that can be used to iterate through the collection.</returns>
        IEnumerator GetEnumerator();
    }

    /// <summary>
    /// Custom Collection class implementing IEnumerable
    /// </summary>
    public class MyCollection : IEnumerable
    {
        private object[] data = { 1, 2, 3, 4, 5 };

        /// <summary>
        /// Implementation of IEnumerable, returning an iterator
        /// </summary>
        /// <returns>An IEnumerator object for the collection.</returns>
        public IEnumerator GetEnumerator()
        {
            // Create and return a new iterator for the collection
            return new MyIterator(data); 
        }
    }

    /// <summary>
    /// IEnumerator Interface
    /// </summary>
    public interface IEnumerator
    {
        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>True if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.</returns>
        bool MoveNext();

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first element in the collection.
        /// </summary>
        void Reset();

        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        object Current { get; }
    }

    /// <summary>
    /// Custom Iterator class implementing IEnumerator
    /// </summary>
    public class MyIterator : IEnumerator
    {
        private object[] data;          // Array to hold the collection data
        private int position = -1;      // Current position in the collection

        /// <summary>
        /// Constructor to initialize the iterator with data
        /// </summary>
        /// <param name="data">The data to iterate over.</param>
        public MyIterator(object[] data)
        {
            this.data = data;
        }

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>True if the enumerator was successfully advanced to the next element; 
        /// false if the enumerator has passed the end of the collection.</returns>
        public bool MoveNext()
        {
            position++;                     // Move to the next position
            return position < data.Length;  // Return true if there are more elements
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first element in the collection.
        /// </summary>
        public void Reset()
        {
            // Reset the position to -1 (before the first element)
            position = -1; 
        }

        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        public object Current
        {
            get
            {
                if (position < 0 || position >= data.Length)
                    throw new InvalidOperationException();      // Throw an exception if the position is out of bounds
                return data[position];                          // Return the current element
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyCollection collection = new MyCollection();

            foreach (var item in collection)
            {
                Console.WriteLine(item); 
            }
        }
    }
}
