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
        /// Creation of structure array
        /// </summary>
        /// <param name="SizeArray"></param>
        public MyArray(int SizeArray)
        {
            this.data = new int[SizeArray];
            this.index = 0;
        }

        /// <summary>
        /// Add (Not ideal)
        /// </summary>
        /// <param name="Element"></param>
        public void Add(int Element)
        {
            if (index >= this.data.Length)
            {
                Array.Resize(ref this.data, this.data.Length * 3 / 2); //100 >> 150 >> 225 >> 337 >> 505 and so on
            }
            this.data[index++] = Element;
        }

        /// <summary>
        /// Delete element in position
        /// </summary>
        /// <param name="Position"></param>
        public void RemoveAt(int Position)
        {
            for (int i = Position; i < this.index; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.index--;
        }

        /// <summary>
        /// Print on Console
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public string Print(string Text = "")
        {
            string output = string.Empty;
            for (int i = 0; i < this.index; i++)
            {
                output += $"{this.data[i]}";
            }
            return $"{Text} {output}".Trim();
        }

        /// <summary>
        /// Permission to array's elements
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
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
        /// Element's quantity
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
