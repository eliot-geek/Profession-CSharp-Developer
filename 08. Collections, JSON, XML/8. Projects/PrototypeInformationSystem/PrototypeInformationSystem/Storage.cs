using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeInformationSystem
{
    /// <summary>
    /// Storage class responsible for managing the creation and storage of workers.
    /// </summary>
    internal class Storage
    {
        /// <summary>
        /// List to store workers.
        /// </summary>
        public List<Worker> workers;

        /// <summary>
        /// Index representing the count of workers.
        /// </summary>
        public int index;

        /// <summary>
        /// Initializes a new instance of the Storage class with the specified index.
        /// </summary>
        /// <param name="index">The index representing the count of workers.</param>
        public Storage(int index)
        {
            workers = new List<Worker>();
            this.index = index + 1;
        }

        /// <summary>
        /// Creates and adds a specified number of workers to the storage.
        /// </summary>
        /// <param name="Count">The number of workers to be added.</param>
        /// <returns>A list of created workers.</returns>
        public List<Worker> Add(int Count)
        {
            Random random = new Random();

            for (int i = 1; i < index; i++)
            {
                workers.Add(new Worker(i, $"Name_{i}", $"LastName_{i}", Count, random.Next(20, 40),
                    random.Next(5000 * 100, 10000 * 100), random.Next(3, 6)));
            }

            return workers;
        }

        /// <summary>
        /// Displays information for all employees in the department.
        /// </summary>
        public void Print()
        {
            foreach (var item in workers)
            {
                item.Print();
            }
        }
    }
}
