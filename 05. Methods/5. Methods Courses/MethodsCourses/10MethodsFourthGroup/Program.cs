using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace _10MethodsFourthGroup
{
    internal class Program
    {
        /// <summary>
        /// Method for generating a string from a set of random characters
        /// </summary>
        /// <param name="Count">Number of characters</param>
        /// <returns>Random string</returns>
        static string GetRandomString(int Count)
        {
            return Guid.NewGuid().ToString().Substring(0, Count);
        }

        /// <summary>
        /// Method that returns the full path to the current application
        /// </summary>
        /// <returns>Full path to the current application</returns>
        static string GetCurrentApplicationPath(bool FileName)
        {
            // If "FileName" is true, the method returns the full path of the currently executing assembly, including the file name itself
            // If "FileName" is false, the method returns the path of the directory that contains the calling assembly 
            return FileName ? Assembly.GetExecutingAssembly().Location : Assembly.GetCallingAssembly().Location;
        }

        /// <summary>
        /// A method that returns the maximum of two numbers
        /// </summary>
        /// <param name="Value1">First number</param>
        /// <param name="Value2">Second number</param>
        /// <returns>Maximum number</returns>
        static int Max(int Value1, int Value2)
        {
            return Value1 > Value2 ? Value1 : Value2;
        }

        /// <summary>
        /// This method takes an array of integers as input and returns a new array containing the negation of each element in the input array.
        /// </summary>
        /// <param name="Args">Input array</param>
        /// <returns>Converted array</returns>
        static int[] Inverse(int[] Args)
        {
            // Create a new array of the same length as the input array.
            int[] t = new int[Args.Length];
            // Loop over each element in the input array and negate it.
            for (int i = 0; i < Args.Length; i++)
            {
                t[i] = -Args[i];
            }
            // Return the new array containing the negated elements.
            return t;
        }

        static void Main(string[] args)
        {
            #region 04. Fourth Group
            //// 
            ////
            ////    │  Something    │
            ////    │     takes     │
            ////    │  arguments    │
            //// ┌──┘               └────────────────────────┐
            //// │                                           └──────
            //// │              Doing something                     >>> gives out the result of his work
            //// │                                           ┌──────
            //// └───────────────────────────────────────────┘
            //
            // 
            //   static DataType MethodName(Formal Parameters)
            //   {
            //      
            //   }

            #endregion

            Console.WriteLine(GetRandomString(10));    // Calling the method GetRandomString
            Console.WriteLine(GetRandomString(15));   // Calling the method GetRandomString
            Console.WriteLine(GetRandomString(25));   // Calling the method GetRandomString
            Console.WriteLine();

            Console.WriteLine(GetCurrentApplicationPath(true));         // Calling the method GetCurrentApplicationPath
            Console.WriteLine(GetCurrentApplicationPath(false));        // Calling the method GetCurrentApplicationPath
            Console.WriteLine();


            int[] col = { 1, 3, 5, 7, 9 };
            foreach (var e in col) 
                Console.Write($"+{e} ");
            Console.WriteLine();

            int[] inverseCol = Inverse(col);                            // Calling the method Inverse
            foreach (var e in inverseCol) 
                Console.Write($"{e} ");
            Console.WriteLine();

            #region NOT WORKING
            //static string GetPath(bool FileName)
            //{
            //    return FileName ? Application.ExecutablePath : Application.StartupPath;
            //}

            //Console.WriteLine(GetPath(true));         
            //Console.WriteLine(GetPath(false));       
            #endregion
        }
    }
}