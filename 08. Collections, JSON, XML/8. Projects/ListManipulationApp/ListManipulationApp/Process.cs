using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulationApp
{
    internal class Process
    {
        /// <summary>
        /// Create a list of integers and fill it with random numbers.
        /// </summary>
        /// <returns>The generated list of integers.</returns>
        public static List<int> CreatedList()
        {
            List<int> collection = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                collection.Add(random.Next(0, 101));
            }
            return collection;
        }

        /// <summary>
        /// Display the elements of the collection.
        /// </summary>
        /// <param name="collection">The list of integers to be displayed.</param>
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
        /// <param name="collection">The list of integers to be modified.</param>
        public static void RemoveCondition(List<int> collection)
        {
            Console.WriteLine("\n\nRemove numbers greater than 25, but less than 50");
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] > 25 && collection[i] < 50)
                {
                    collection.RemoveAt(i);
                }
            }
        }

    }
}
