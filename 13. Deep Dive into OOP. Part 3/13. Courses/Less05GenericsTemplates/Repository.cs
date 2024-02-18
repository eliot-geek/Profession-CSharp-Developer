using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less05GenericsTemplates
{
    /// <summary>
    /// Represents a generic interface for a repository.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the repository.</typeparam>
    interface IRepository<T>
    {
        /// <summary>
        /// Pushes a value onto the repository.
        /// </summary>
        /// <param name="Value">The value to push onto the repository.</param>
        void Push(T Value);

        /// <summary>
        /// Pops a value from the repository.
        /// </summary>
        /// <returns>The value popped from the repository.</returns>
        T Pop();

        /// <summary>
        /// Gets or sets the value at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the value to get or set.</param>
        /// <returns>The value at the specified index.</returns>
        T this[int index] 
        { 
            get; set; 
        }
    }

    /// <summary>
    /// Represents a generic class implementing the IRepository interface.
    /// </summary>
    /// <typeparam name="T">The type of elements stored in the repository.</typeparam>
    internal class Repository<T> : IRepository<T>
    {
        T[] items;
        int size;

        /// <summary>
        /// Initializes a new instance of the Repository class.
        /// </summary>
        public Repository()
        {
            this.items = new T[0];
            this.size = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Repository class with the specified initial items.
        /// </summary>
        /// <param name="Args">The initial items to populate the repository.</param>
        public Repository(params T[] Args)
        {
            this.items = Args;
            this.size = Args.Length - 1;
        }

        /// <summary>
        /// Pushes a value onto the repository.
        /// </summary>
        /// <param name="Value">The value to push onto the repository.</param>
        public void Push(T Value)
        {
            if (this.size == this.items.Length)
            {
                Array.Resize(ref this.items, this.size == 0 ? 4 : this.items.Length * 2);
            }

            this.items[this.size++] = Value;
        }

        /// <summary>
        /// Pops a value from the repository.
        /// </summary>
        /// <returns>The value popped from the repository.</returns>
        public T Pop()
        {
            T temp = this.items[--this.size];

            this.items[this.size] = default(T);

            return temp;
        }

        /// <summary>
        /// Gets or sets the value at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the value to get or set.</param>
        /// <returns>The value at the specified index.</returns>
        public T this[int index]
        {
            get 
            { 
                return this.items[index]; 
            }
            
            set 
            { 
                this.items[index] = value; 
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the repository.
        /// </summary>
        public int Count 
        { 
            get 
            { 
                return this.size; 
            } 
        }
    }
}
