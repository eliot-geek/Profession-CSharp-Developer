using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDuplicates
{
    internal class Repetition
    {
        /// <summary>
        /// Adds a number to the HashSet.
        /// </summary>
        /// <param name="set">The HashSet collection.</param>
        /// <param name="number">The number to be added.</param>
        /// <returns>Returns true if the number was successfully added; otherwise, false if the number already exists in the HashSet.</returns>
        public static bool AddNumberToSet(HashSet<int> set, int number)
        {
            if (set.Contains(number))
            {
                return false;
            }

            set.Add(number);
            return true;
        }


        /// <summary>
        /// Displays the numbers in the HashSet.
        /// </summary>
        /// <param name="set">The HashSet collection.</param>
        public static void DisplayNumbersSet(HashSet<int> set)
        {
            Console.WriteLine("\nNumbers in the HashSet:");

            foreach (var number in set)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
