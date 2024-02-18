using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less09LimitationsGenericsInterfaces
{
    /// <summary>
    /// Represents a storage class for objects that implement interface IInterface1.
    /// </summary>
    /// <typeparam name="T">The type of objects stored in the storage.</typeparam>
    class Storage1<T> where T : IInterface1
    {
        /// <summary>
        /// Gets or sets the list of objects stored in the storage.
        /// </summary>
        public List<T> DataBase { get; set; }

        /// <summary>
        /// Initializes a new instance of the Storage1 class.
        /// </summary>
        public Storage1()
        {
            DataBase = new List<T>();
        }

        /// <summary>
        /// Gets the value of the last property Property1 stored in the storage.
        /// </summary>
        /// <returns>The value of the last Property1 stored in the storage, or -1 if the storage is empty.</returns>
        public int GetLastProperty()
        {
            return this.DataBase.Count > 0 ? this.DataBase[this.DataBase.Count - 1].Property1 : -1;
        }

        /// <summary>
        /// Adds an item to the storage.
        /// </summary>
        /// <param name="Item">The item to add to the storage.</param>
        public void Add(T Item)
        {
            DataBase.Add(Item);
        }
    }

    /// <summary>
    /// Represents a storage class for objects that implement interface IInterface2.
    /// </summary>
    /// <typeparam name="T">The type of objects stored in the storage.</typeparam>
    class Storage2<T> where T : IInterface2
    {
        /// <summary>
        /// Gets or sets the list of objects stored in the storage.
        /// </summary>
        public List<T> DataBase { get; set; }

        /// <summary>
        /// Initializes a new instance of the Storage2 class.
        /// </summary>
        public Storage2()
        {
            DataBase = new List<T>();
        }

        /// <summary>
        /// Gets the value of the last property Property2 stored in the storage.
        /// </summary>
        /// <returns>The value of the last Property2 stored in the storage, or -1 if the storage is empty.</returns>
        public int GetLastProperty()
        {
            return this.DataBase.Count > 0 ? this.DataBase[this.DataBase.Count - 1].Property2 : -1;
        }

        /// <summary>
        /// Adds an item to the storage.
        /// </summary>
        /// <param name="Item">The item to add to the storage.</param>
        public void Add(T Item)
        {
            DataBase.Add(Item);
        }
    }

    /// <summary>
    /// Represents a storage class for objects that implement interface IInterface3 with a generic type of string.
    /// </summary>
    /// <typeparam name="T">The type of objects stored in the storage.</typeparam>
    class Storage3<T> where T : IInterface3<string>
    {
        /// <summary>
        /// Gets or sets the list of objects stored in the storage.
        /// </summary>
        public List<T> DataBase { get; set; }

        /// <summary>
        /// Initializes a new instance of the Storage3 class.
        /// </summary>
        public Storage3()
        {
            DataBase = new List<T>();
        }

        /// <summary>
        /// Gets the value of the Property3 property of the last added element in the storage.
        /// </summary>
        /// <returns>The value of the Property3 property of the last added element, or an empty string if the storage is empty.</returns>
        public string GetLastProperty()
        {
            return this.DataBase.Count > 0 ? this.DataBase[this.DataBase.Count - 1].Property3 : string.Empty;
        }

        /// <summary>
        /// Adds an item to the storage.
        /// </summary>
        /// <param name="Item">The item to add to the storage.</param>
        public void Add(T Item)
        {
            DataBase.Add(Item);
        }
    }


    /// <summary>
    /// Represents a storage class for objects that implement interface IInterface3 with a generic type of int.
    /// </summary>
    /// <typeparam name="T">The type of objects stored in the storage.</typeparam>
    class Storage4<T> where T : IInterface3<int>
    {
        /// <summary>
        /// Gets or sets the list of objects stored in the storage.
        /// </summary>
        public List<T> DataBase { get; set; }

        /// <summary>
        /// Initializes a new instance of the Storage4 class.
        /// </summary>
        public Storage4()
        {
            DataBase = new List<T>();
        }

        /// <summary>
        /// Gets the value of the Property3 property of the last added element in the storage.
        /// </summary>
        /// <returns>The value of the Property3 property of the last added element, or -1 if the storage is empty.</returns>
        public int GetLastProperty()
        {
            return this.DataBase.Count > 0 ? this.DataBase[this.DataBase.Count - 1].Property3 : -1;
        }

        /// <summary>
        /// Adds an item to the storage.
        /// </summary>
        /// <param name="Item">The item to add to the storage.</param>
        public void Add(T Item)
        {
            DataBase.Add(Item);
        }
    }


    /// <summary>
    /// Represents a storage class for objects that implement both interface IInterface1 and IInterface2.
    /// </summary>
    /// <typeparam name="T">The type of objects stored in the storage.</typeparam>
    class Storage5<T> where T : IInterface1, IInterface2
    {
        /// <summary>
        /// Gets or sets the list of objects stored in the storage.
        /// </summary>
        public List<T> DataBase { get; set; }

        /// <summary>
        /// Initializes a new instance of the Storage5 class.
        /// </summary>
        public Storage5()
        {
            DataBase = new List<T>();
        }

        /// <summary>
        /// Gets the sum of Property1 and Property2 of the last added element in the storage.
        /// </summary>
        /// <returns>The sum of Property1 and Property2 of the last added element, or -1 if the storage is empty.</returns>
        public int GetLastProperty()
        {
            return this.DataBase.Count > 0 ?
                this.DataBase[this.DataBase.Count - 1].Property1 + this.DataBase[this.DataBase.Count - 1].Property2
                : -1;
        }

        /// <summary>
        /// Adds an item to the storage.
        /// </summary>
        /// <param name="Item">The item to add to the storage.</param>
        public void Add(T Item)
        {
            DataBase.Add(Item);
        }
    }
}
