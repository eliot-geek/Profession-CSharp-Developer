using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace PascalTriangleEasyMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 2

            // The client needs an application that builds the first N rows of Pascal's triangle. N < 25.
            // When N = 9, the triangle looks like this:
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1

            // Pascal's triangle is a triangular array of numbers in which the first and last numbers of each row are 1,
            // and each of the remaining numbers is the sum of the two numbers directly above it. 
            
            // Reference - https://en.wikipedia.org/wiki/Pascal%27s_triangle
            
            #endregion


            #region Solution 1

            // Print the title of the program to the console
            Console.WriteLine("Pascal triangle - Easy Mode");
            // Create a 2D array with size of 25 x 25 - This size is chosen as a maximum size to accommodate the largest possible value of N.
            int[,] array2D = new int[25, 25];
            // Ask the user to input an integer value for N
            Console.Write("Enter n (N < 25): ");
            // Read the user input as an integer and store it in the variable n
            int n = int.Parse(Console.ReadLine());

            // Start a loop to generate the rows of the Pascal's triangle
            for (int i = 0; i < n; i++)
            {
                // Check if the user input value exceeds the array size limit, if yes, keep asking for input until it is within the limit
                while (n > 25)
                {
                    Console.Write("You entered more than your memory allotment. Again : ");
                    n = int.Parse(Console.ReadLine());
                }
                // Generate the numbers for each row of the triangle and store them in the array
                for (int j = 0; j <= i; j++)
                {
                    // the first and last elements in each row are always 1
                    if (j == 0 || i == j)
                    {
                        array2D[i, j] = 1;
                    }
                    else
                    {
                        array2D[i, j] = array2D[i - 1, j] + array2D[i - 1, j - 1];
                    }
                    // Print each number to the console
                    Console.Write(array2D[i, j] + "  ");
                }
                Console.WriteLine();
            }
            #endregion


            #region Solution 2
            
            Console.WriteLine("\nSolution 2");
            Console.Write("Enter the number of rows to generate: ");
            int numb = int.Parse(Console.ReadLine());

            // create a 2D jagged array to hold the triangle
            int[][] triangle = new int[numb][]; 
            for (int i = 0; i < numb; i++)
            {
                // create an array for each row with length i+1
                triangle[i] = new int[i + 1];   
                for (int j = 0; j <= i; j++)
                {
                    // the first and last elements in each row are always 1
                    if (j == 0 || j == i)       
                    {
                        triangle[i][j] = 1;
                    }
                    else   // the other elements are the sum of the two elements above them
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
            }
            // print out the triangle
            for (int i = 0; i < numb; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i][j] + "  ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}