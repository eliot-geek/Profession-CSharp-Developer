using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less09IndexersHistory
{
    /// <summary>
    /// SomethingC class implementing the IEnumerator interface.
    /// </summary>
    internal class SomethingС : IEnumerator
    {
        /// <summary>
        /// Gets the current element in the collection.
        /// </summary>
        public object Current { get; }

        /// <summary>
        /// Advances the enumerator to the next element in the collection.
        /// </summary>
        /// <returns>True if the enumerator was successfully advanced to the next element; 
        /// false if the enumerator has passed the end of the collection.</returns>
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the enumerator to its initial position, 
        /// which is before the first element in the collection.
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
