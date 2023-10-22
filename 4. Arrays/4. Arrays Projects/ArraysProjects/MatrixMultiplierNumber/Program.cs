using static System.Net.Mime.MediaTypeNames;

namespace MatrixMultiplierNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 3

            // The customer needs an application that allows multiplying a mathematical matrix by a number.
            // Add the ability to enter the number of rows and columns of the matrix and the number  by which the multiplication will be performed.
            // The matrices are filled automatically.
            // If the action is impossible based on the user input, inform them about it.

            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |

            // Reference - https://en.wikipedia.org/wiki/Matrix_(mathematics)

            #endregion

            Console.WriteLine($"Multiplication Of The Matrix By A Number");
            // Get the number of rows and columns from the user
            Console.Write("Enter the number of rows in the matrix: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns in the matrix: ");
            int col = int.Parse(Console.ReadLine());

            // Check if matrix multiplication is possible
            while (row <= 0 | col <= 0)
            {
                Console.WriteLine("Error: Matrix cannot have zero/negative rows or columns.");
                Console.Write("Enter the number of rows in the matrix: ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns in the matrix: ");
                col = int.Parse(Console.ReadLine());
            }

            int answer;
            // Create the matrix and generate its values
            int[,] array2D = new int[row, col];
            Console.WriteLine($"array2D.Length = {array2D.Length}");
            Console.WriteLine($"memory: {(array2D.Length * sizeof(double))}");
            Random random = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2D[i, j] = random.Next(10);
                    Console.Write($"{array2D[i, j],5} ");
                }
                Console.WriteLine();
            }

            // Get the multiplication factor from the user
            Console.Write("\nEnter the number to multiply the matrix by: ");
            int multiplier = int.Parse(Console.ReadLine());

            // Multiply the matrix by the factor
            Console.Write($"\nAfter multiplying the mathematical matrix by a number {multiplier}\n");
            Console.WriteLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    answer = multiplier * array2D[i, j];
                    Console.Write($"{answer,5} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}