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


            #region Solution 1 (2D array)

            Console.WriteLine("Pascal triangle - Easy Mode");
            int[,] array2D = new int[25, 25];
            Console.Write("Enter n (N < 25): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                while (n > 25)
                {
                    Console.Write("The input exceeds the allocated memory. Please try again: ");
                    n = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        array2D[i, j] = 1;
                    }
                    else
                    {
                        array2D[i, j] = array2D[i - 1, j] + array2D[i - 1, j - 1];
                    }

                    Console.Write(array2D[i, j] + "  ");
                }

                Console.WriteLine();
            }
            #endregion


            #region Solution 2 (Jagged 2D array)

            Console.WriteLine("\nSolution 2");
            Console.Write("Enter the number of rows to generate: ");
            int numb = int.Parse(Console.ReadLine());

            int[][] triangle = new int[numb][]; 
            for (int i = 0; i < numb; i++)
            {
                triangle[i] = new int[i + 1];   
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)       
                    {
                        triangle[i][j] = 1;
                    }
                    else
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }

                    Console.Write(triangle[i][j] + "  ");
                }

                Console.WriteLine();
            }

            #endregion

            #region Solution 3 (1D array)

            Console.WriteLine("\nSolution 3");
            Console.WriteLine("Pascal's Triangle - Optimized");
            Console.Write("Enter the number of rows to generate: ");
            int numRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRows; i++)
            {
                int[] row = new int[i + 1];

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row[j] = 1;
                    }
                    else
                    {
                        // Use the values from the previous row to compute the current value
                        row[j] = row[j - 1] * (i - j + 1) / j;
                    }

                    Console.Write(row[j] + "  ");
                }

                Console.WriteLine();
            }

            #endregion
        }
    }
}