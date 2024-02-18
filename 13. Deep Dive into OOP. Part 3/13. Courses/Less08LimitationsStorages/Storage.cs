using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less08LimitationsStorages
{
    /// <summary>
    /// Represents a storage class with a generic type parameter constrained to type A or its derived types.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the storage, constrained to type A or its derived types.</typeparam>
    internal class Storage<T> where T : A
    {
        /// <summary>
        /// Database to store items of type T.
        /// </summary>
        public List<T> DataBase { get; set; }

        /// <summary>
        /// Initializes a new instance of the Storage class.
        /// </summary>
        public Storage()
        {
            DataBase = new List<T>();
        }

        /// <summary>
        /// Gets the value of the last property stored in the database.
        /// </summary>
        /// <returns>The value of the last property, or -1 if the database is empty.</returns>
        public int GetLastProperty()
        {
            return this.DataBase.Count > 0 ? this.DataBase[this.DataBase.Count - 1].Property : -1;
        }

        /// <summary>
        /// Adds an item to the database.
        /// </summary>
        /// <param name="Item">The item to add to the database.</param>
        public void Add(T Item)
        {
            DataBase.Add(Item);
        }
    }
}
