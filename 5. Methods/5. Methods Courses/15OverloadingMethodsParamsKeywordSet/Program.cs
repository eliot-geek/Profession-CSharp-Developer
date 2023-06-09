﻿using System;

namespace _15OverloadingMethodsParamsKeywordSet
{
    internal class Program
    {
        /// <summary>
        /// This method takes in a factor and a variable number of integer arguments
        /// </summary>
        /// <param name="Factor"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        static int Sum(int Factor, params int[] Args) // Keyword always stays after the factor
        {
            int result = 0;             // Initialize a variable to store the sum
            foreach (var e in Args)     // Loop through each integer argument
            {
                result += e;            // Add the current integer to the sum
            }
            return result * Factor;     // Multiply the sum by the factor and return the result
        }

        /// <summary>
        /// This method takes in an integer factor, a string message, and a variable number of integer arguments
        /// </summary>
        /// <param name="Factor"></param>
        /// <param name="Msg"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        static int Sum(int Factor, string Msg, params int[] Args) 
        {
            return 0; // Placeholder return statement  - Just an example
        }

        /// <summary>
        /// This method takes in a double factor, a string message, and a variable number of integer arguments
        /// </summary>
        /// <param name="Factor"></param>
        /// <param name="Msg"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        static int Sum(double Factor, string Msg, params int[] Args)
        {
            return 0; // Placeholder return statement - Just an example
        }

        /// <summary>
        /// This method takes in a double factor, a string message, and a variable number of double arguments
        /// </summary>
        /// <param name="Factor"></param>
        /// <param name="Msg"></param>
        /// <param name="Args"></param>
        /// <returns></returns>
        static int Sum(double Factor, string Msg, params double[] Args) 
        {
            return 0; // Placeholder return statement - Just an example
        }

        // the params keyword is used to allow a variable number of arguments to be passed in as an array.
        
        static void Main(string[] args)
        {
            var res = Sum(1);
            res = Sum(1, 9);
            res = Sum(1, 9, 9);
            res = Sum(1, 9, 9, 0);
            res = Sum(1, 9, 9, 0, 2);
            res = Sum(1, 9, 9, 0, 2, 8);

            int[] col = new int[] { 2, 8, 0, 9, 9, 0 };

            Console.WriteLine(res);

            res = Sum(13, col);
            res = Sum(13, new int[] { 2, 8, 0, 9, 9, 0, 0, 1, 3, 5 });      // Here, the Factor parameter is set to 13
            Console.WriteLine(res);

            res = Sum(8, 2, 8, 0, 9);               // Here, the Factor parameter is set to 8
            Console.WriteLine(res);

            res = Sum(5, new int[] { 2, 8 });       // Here, the Factor parameter is set to 5
            Console.WriteLine(res);

            res = Sum(3, new int[] { 2 });
            Console.WriteLine(res);


            int sum1 = Sum(2, 1, 2, 3);         // sum1 will be 12 (the sum of 1, 2, and 3 multiplied by 2)
            Console.WriteLine(sum1);            // Here, the Factor parameter is set to 2, so the final result is the sum of the integer arguments (1, 2, and 3), multiplied by 2.

        }
    }
}