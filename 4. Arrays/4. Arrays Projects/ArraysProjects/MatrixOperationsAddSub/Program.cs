using static System.Net.Mime.MediaTypeNames;
using System.Buffers.Text;
using System.Diagnostics.Metrics;

namespace MatrixOperationsAddSub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Adding and Subtracting Matrixes

            // The client needs an application that allows adding and subtracting mathematical matrices.
            // Add the ability to enter the number of rows and columns of the matrix.
            // The matrices are automatically filled.
            // If the operation cannot be performed based on the user-entered data, notify the user about it.

            // Example

            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |

            #endregion

            Console.WriteLine($"Adding and Subtracting Matrixes");
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

            // Initialize and Fill the matrices with random numbers
            Random random = new Random();
            int[,] matrix1 = new int[row, col];
            Console.WriteLine("\nMatrix 1: ");

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = random.Next(10);
                    Console.Write($"{matrix1[i, j],5} ");
                }
                Console.WriteLine();
            }

            int[,] matrix2 = new int[row, col];
            Console.WriteLine("\nMatrix 2: ");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = random.Next(10);
                    Console.Write($"{matrix2[i, j],5} ");
                }
                Console.WriteLine();
            }

            // Add the matrices and print the result
            int[,] Addmatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            Console.WriteLine("\nAddition of two matrixes");
            Console.WriteLine("AddMatrix = Matrix 1 + Matrix 2 ");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Addmatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write($"{Addmatrix[i, j],5} ");
                }
                Console.WriteLine();
            }

            // Subtract the matrices and print the result
            int[,] Submatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            Console.WriteLine("\nSubtraction of two matrices");
            Console.WriteLine("SubMatrix = Matrix 1 - Matrix 2 ");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Submatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                    Console.Write($"{Submatrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }
    }
}