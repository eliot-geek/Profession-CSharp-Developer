using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeInformationSystem
{
    internal class Storage
    {
        /// <summary>
        /// List's creation of workers
        /// </summary>
        public List<Worker> workers;
        
        /// <summary>
        /// index
        /// </summary>
        public int index;

        /// <summary>
        /// Storage (index)
        /// </summary>
        /// <param name="index"></param>
        public Storage(int index)
        {
            workers = new List<Worker>();
            this.index = index + 1;
        }

        /// <summary>
        /// Creating employees in the department
        /// </summary>
        /// <param name="Count"></param>
        /// <returns></returns>
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
        /// Displays of all employees in the department
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
