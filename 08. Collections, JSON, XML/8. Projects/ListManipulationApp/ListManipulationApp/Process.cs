using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulationApp
{
    /// <summary>
    /// Process the list
    /// </summary>
    internal class Process
    {
        /// <summary>
        /// Create a list of integers and fill with random numbers 
        /// </summary>
        /// <returns></returns>
        public static List<int> CreatedList()
        {
            List<int> collection = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                collection.Add(random.Next(0, 100));
            }
            return collection;
        }

        /// <summary>
        /// Display the collection
        /// </summary>
        /// <param name="collection"></param>
        public static void PrintList(List<int> collection)
        {
            Console.WriteLine($"The list contains {collection.Count} integers. ");
            foreach (int item in collection)
            {
                Console.Write($"{item}, ");
            }
        }

        /// <summary>
        /// Remove from the list numbers that are greater than 25, but less than 50.
        /// </summary>
        /// <param name="collection"></param>
        public static void RemoveCondition(List<int> collection)
        {
            Console.WriteLine("\n\nRemove numbers greater than 25, but less than 50");
            collection.RemoveAll(e => e > 25 && e < 50);
        }
    }
}
