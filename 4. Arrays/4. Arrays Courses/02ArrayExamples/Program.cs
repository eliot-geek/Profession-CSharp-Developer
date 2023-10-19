using System;

namespace _02ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //Console.WriteLine("Generate an array of N random numbers from -5 to 5");

            //Console.Write("Enter n: ");                  // Prompt to enter a number
            //int n = int.Parse(Console.ReadLine());       // Input a number from the keyboard

            //Random random = new Random();                // Initialize a pseudo-random number generator

            //int[] numbs = new int[n];                    // Declare and initialize an array
            //for (int i = 0; i < numbs.Length; i++)       
            //{                                            
            //    numbs[i] = random.Next(-5, 6);           // Fill the array
            //    Console.Write($"{numbs[i]} ");           // Display the array on the screen
            //}
            //Console.ReadLine(); Console.ReadKey();

            #endregion

            #region Task 2

            //Console.WriteLine("Generate an array of N random numbers. Count the number of even numbers");

            //Random random = new Random();                 // Initialize a pseudo-random number generator

            //Console.Write("Enter n: ");                   // Prompt to enter a number
            //int n = int.Parse(Console.ReadLine());        // Input a number from the keyboard

            //var numbs = new int[n];                       // Declare and initialize an array
            //int evenElement = 0;                          // Number of even elements

            //for (int i = 0; i < numbs.Length; i++)        
            //{                                             
            //    numbs[i] = random.Next(10);               // Fill the array
            //    Console.Write($"{numbs[i]} ");            // Display the array on the screen
            //    if (numbs[i] % 2 == 0) evenElement++;     // Count even elements
            //}                                              
            //Console.WriteLine($"\nEven numbers: {evenElement}");
            //Console.ReadKey();

            #endregion

            #region Task 3

            //Console.WriteLine("In an array of 10 numbers, calculate how many times the entered number occurs");

            //Random random = new Random();
            //int[] numbs = new int[10];                      // Declare and initialize an array

            //for (int i = 0; i < numbs.Length; i++)        
            //{                                             
            //    numbs[i] = random.Next(10);                 // Fill the array
            //    Console.Write($"{numbs[i]} ");              // Display the array on the screen
            //}                                              
            //Console.Write("\nEnter a number to search: ");  // Prompt to enter a number
            //int n = int.Parse(Console.ReadLine());          // Input the number to search from the keyboard

            //int find = 0;                                   // Search result
            //for (int i = 0; i < numbs.Length; i++)          
            //{                                               
            //    if (numbs[i] == n) find++;                  // Search for the desired element
            //}
            //Console.WriteLine($"Element '{n}' found: {find} times. ");
            //Console.ReadKey();

            #endregion

            #region Task 4

            //Console.WriteLine("An array with n elements which has only zeros and ones.\nZeros at the begining and ones at the end.");
            //Console.Write("Numbers of elements: ");
            //int n = int.Parse(Console.ReadLine());

            //Random random = new Random();
            //int[] numbs = new int[n];
            //Console.Write("\nOriginal array: ");
            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i] = random.Next(0, 2);
            //    Console.Write($"{numbs[i]} "); 
            //}

            ////     0  0  0  0  0  0  0  1  1  1
            ////                       ^  ^     

            //int head = 0;
            //int tail = numbs.Length - 1;
            //bool flag = true;
            //while (head < tail)
            //{
            //    if (flag)
            //    {
            //        if (numbs[head] == 1) flag = false;
            //        else head++;
            //    }
            //    else
            //    {
            //        if (numbs[tail] == 0) flag = true;
            //        else tail--;
            //    }

            //    // If both the current element at the head pointer is 1 and the current element at the tail pointer is 0, swap the elements
            //    if (numbs[head] == 1 && numbs[tail] == 0)
            //    {
            //        int temp = numbs[head];
            //        numbs[head] = numbs[tail];
            //        numbs[tail] = temp;

            //        // Increment the head pointer and decrement the tail pointer
            //        head++;
            //        tail--;
            //    }
            //}

            //Console.Write("\nReceived array: ");
            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    Console.Write($"{numbs[i]} "); 
            //}
            //Console.ReadKey();

            #endregion
        }
    }
}
