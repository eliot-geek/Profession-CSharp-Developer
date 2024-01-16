using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less01MyCollections
{
    /// <summary>
    /// Structure for work with data
    /// </summary>
    internal struct MyArray
    {
        private int[] data;
        private int index;

        /// <summary>
        /// Constructor for creating a structured array.
        /// </summary>
        /// <param name="SizeArray">The size of the array to be created.</param>
        public MyArray(int SizeArray)
        {
            this.data = new int[SizeArray];     // Initialize the data array with the specified size
            this.index = 0;                     // Initialize the index to 0, indicating the start position
        }

        /// <summary>
        /// Adds an element to the structured array.
        /// </summary>
        /// <param name="Element">The element to be added.</param>
        public void Add(int Element)
        {
            if (index >= this.data.Length)
            {
                // If the current index is >= to the arr length, resize the arr to add more elements (increasing by 50% each time).
                // 100 >> 150 >> 225 >> 337 >> 505 and so on
                Array.Resize(ref this.data, this.data.Length * 3 / 2); 
            }

            this.data[index++] = Element;
        }


        /// <summary>
        /// Deletes an element at the specified position in the structured array.
        /// </summary>
        /// <param name="Position">The position of the element to be removed.</param>
        public void RemoveAt(int Position)
        {
            for (int i = Position; i < this.index; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            this.index--;
        }


        /// <summary>
        /// Prints the elements of the structured array to the console.
        /// </summary>
        /// <param name="Text">Optional text to be displayed before the array elements.</param>
        /// <returns>A string representation of the array elements.</returns>
        public string Print(string Text = "")
        {
            string output = string.Empty;

            for (int i = 0; i < this.index; i++)
            {
                output += $"{this.data[i]} ";
            }

            // Combine the optional text with the array elements and trim any extra spaces.
            return $"{Text} {output}".Trim();
        }


        /// <summary>
        /// Provides access to the elements of the structured array using an indexer.
        /// </summary>
        /// <param name="i">The index of the element to get or set.</param>
        /// <returns>The value of the array element at the specified index.</returns>
        public int this[int i]
        {
            get
            {
                return this.data[i];
            }
            set
            {
                this.data[i] = value;
            }
        }

        /// <summary>
        /// Gets the quantity of elements in the structured array.
        /// </summary>
        public int Count
        {
            get
            {
                return this.index;
            }
        }

    }
}
