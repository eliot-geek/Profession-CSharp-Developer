using System.Collections.Generic;
using System.Xml.Linq;

namespace _01IntroductionMinMaxOfArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5.1 Separating Logic: Using Methods

            // There are two arrays containing at least 10 and at most 20 elements.
            // Organize the filling and displaying of each of them. Find the maximum and minimum elements in each array


            #region Example 1 - This is not a good way to write code

            // Random
            Random r = new Random();
            int N = r.Next(10, 20);

            // Arrays
            int[] arr = new int[N];
            int[] brr = new int[N];

            // Fill 
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(20);
                brr[i] = r.Next(20);
            }

            // Initialization
            int maxArr = arr[0];
            int minArr = arr[0];
            int maxBrr = brr[0];
            int minBrr = brr[0];

            // Searching for Max and Min
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxArr) maxArr = arr[i];
                if (arr[i] < minArr) minArr = arr[i];

                if (brr[i] > maxBrr) maxBrr = brr[i];
                if (brr[i] < minBrr) minBrr = brr[i];
            }

            // Print
            Console.WriteLine("arr");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i],3}");
            }
            Console.WriteLine($"\nmaxArr = {maxArr}");
            Console.WriteLine($"minArr = {minArr}");

            Console.WriteLine("\nbrr");
            for (int i = 0; i < brr.Length; i++)
            {
                Console.Write($"{brr[i],3}");
            }
            Console.WriteLine($"\nmaxBrr = {maxBrr}");
            Console.WriteLine($"minBrr = {minBrr}");

            #endregion
        }
    }
}