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

            //// Write a message to describe what the program does
            //Console.WriteLine("An array with n elements which has only zeros and ones.\nZeros at the begining and ones at the end.");
            //// Prompt the user to enter the number of elements they want in the array
            //Console.Write("Numbers of elements: ");
            //// Read the user's input and convert it to an integer
            //int n = int.Parse(Console.ReadLine());

            //// Create a new instance of the Random class to generate random numbers for the array
            //Random random = new Random();
            //// Initialize an integer array with the size n
            //int[] numbs = new int[n];
            //// Write the original array to the console
            //Console.Write("\nOriginal array: ");
            //// Loop through the array and initialize each element with a random number between 0 and 1
            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    numbs[i] = random.Next(0, 2);
            //    Console.Write($"{numbs[i]} "); // Write the element to the console
            //}


            ////     0  0  0  0  0  0  0  1  1  1
            ////                       ^  ^     
            

            //// Initialize the head and tail pointers to the beginning and end of the array, respectively
            //int head = 0;
            //int tail = numbs.Length - 1;
            //// Initialize a flag variable to keep track of which element (0 or 1) should be swapped next
            //bool flag = true;
            //// Swap the 0's and 1's until the zeros are all at the beginning and the ones are all at the end
            //while (head < tail)
            //{
            //    if (flag)
            //    {
            //        // If the current element at the head pointer is 1, set the flag to false, otherwise increment the head pointer
            //        if (numbs[head] == 1) flag = false;
            //        else head++;
            //    }
            //    else
            //    {
            //        // If the current element at the tail pointer is 0, set the flag to true, otherwise decrement the tail pointer
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

            //// Write the received array to the console
            //Console.Write("\nReceived array: ");
            //for (int i = 0; i < numbs.Length; i++)
            //{
            //    Console.Write($"{numbs[i]} "); // Write the element to the console
            //}
            //// Wait for the user to press a key before closing the console window
            //Console.ReadKey();

            #endregion
        }
    }
}