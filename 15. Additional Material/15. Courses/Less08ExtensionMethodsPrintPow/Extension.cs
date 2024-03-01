using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less08ExtensionMethodsPrintPow
{
    /// <summary>
    /// A static class containing extension methods for various types.
    /// </summary>
    public static class Extension
    {
        /// <summary>
        /// Prints the value of a double to the console.
        /// </summary>
        /// <param name="item">The double value to print.</param>
        public static void Print(this double item)
        {
            Console.WriteLine(item);
        }

        /// <summary>
        /// Prints the elements of a list to the console.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="O">The list to print.</param>
        public static void Print<T>(this List<T> O)
        {
            foreach (var e in O)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Raises an integer to the power of another integer.
        /// </summary>
        /// <param name="Base">The base integer.</param>
        /// <param name="Indicator">The exponent integer.</param>
        /// <returns>The result of raising the base to the power of the indicator.</returns>
        public static double Pow(this int Base, int Indicator)
        {
            return Math.Pow(Base, Indicator);
        }

        /// <summary>
        /// Adds an integer to a list of integers.
        /// </summary>
        /// <param name="item">The integer to add to the list.</param>
        /// <param name="col">The list to which the integer is added.</param>
        public static void AddToList(this int item, List<int> col)
        {
            col.Add(item);
        }
    }
}
