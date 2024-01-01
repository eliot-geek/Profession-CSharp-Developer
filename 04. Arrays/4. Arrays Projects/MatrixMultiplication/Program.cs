using static System.Net.Mime.MediaTypeNames;
using System.Buffers.Text;
using System.Diagnostics.Metrics;

namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Matrix Multiplication

            // The customer needs an application that allows multiplying mathematical matrices.
            // Add the ability to enter the number of rows and columns of the matrix.
            // The matrices are automatically filled.
            // If the operation cannot be performed based on the user-entered data, notify the user.

            //  | 1  3  5 |   | 1  3  4 |   | 22  48  57 |
            //  | 4  5  7 | х | 2  5  6 | = | 35  79  95 |
            //  | 5  3  1 |   | 3  6  7 |   | 14  36  45 |


            Console.WriteLine($"Multiplication of two matrices");
            Console.Write("Enter the number of rows in the matrix: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns in the matrix: ");
            int col = int.Parse(Console.ReadLine());

            while (row <= 0 || col <= 0 || row != col)
            {
                Console.WriteLine($"\nSuch matrices cannot be multiplied because the number of columns of the first matrix does not equal " +
                    $"the number of rows of the second matrix or their values are less than or equal to zero");
                Console.Write("\nEnter the number of rows in the matrix: ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns in the matrix: ");
                col = int.Parse(Console.ReadLine());
            }

            Random random = new Random();
            int[,] matrix1 = new int[row, col];
            Console.WriteLine("Matrix 1: ");
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
            Console.WriteLine("Matrix 2: ");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = random.Next(10);
                    Console.Write($"{matrix2[i, j],5} ");
                }
                Console.WriteLine();
            }

            int[,] Multimatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            Console.WriteLine("\nMultiplication of two matrices");
            Console.WriteLine("MulMatrix = Matrix 1 * Matrix 2 ");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        Multimatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                    Console.Write($"{Multimatrix[i, j],5} ");
                }
                Console.WriteLine();
            }

            #endregion


            #region 1X1 Matrix

            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  



            Console.WriteLine($"\n\nMultiplication of two matrices 2");
            Console.Write("Enter the number of rows in the matrix: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns in the matrix: ");
            int columns = int.Parse(Console.ReadLine());

            while (rows <= 0 || columns <= 0)
            {
                Console.WriteLine($"\nSuch matrices cannot be multiplied because the number of columns of the first matrix does not equal " +
                    $"the number of rows of the second matrix or their values are less than or equal to zero");
                Console.Write("\nEnter the number of rows in the matrix: ");
                rows = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns in the matrix: ");
                columns = int.Parse(Console.ReadLine());
            }

            Random random1 = new Random();
            int[,] matrix01 = new int[rows, columns];
            Console.WriteLine("Matrix 1: ");
            for (int i = 0; i < matrix01.GetLength(0); i++)
            {
                for (int j = 0; j < matrix01.GetLength(1); j++)
                {
                    matrix01[i, j] = random1.Next(10);
                    Console.Write($"{matrix01[i, j],5} ");
                }
                Console.WriteLine();
            }

            // Get the number of rows and columns from the user
            Console.Write("\nEnter the number of rows in the matrix: ");
            int rows1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns in the matrix: ");
            int columns1 = int.Parse(Console.ReadLine());

            while (rows1 <= 0 || columns1 <= 0)
            {
                Console.WriteLine($"\nSuch matrices cannot be multiplied because the number of columns of the first matrix does not equal " +
                    $"the number of rows of the second matrix or their values are less than or equal to zero");
                Console.Write("\nEnter the number of rows in the matrix: ");
                rows1 = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns in the matrix: ");
                columns1 = int.Parse(Console.ReadLine());
            }

            int[,] matrix02 = new int[rows1, columns1];
            Console.WriteLine("Matrix 2: ");
            for (int i = 0; i < matrix02.GetLength(0); i++)
            {
                for (int j = 0; j < matrix02.GetLength(1); j++)
                {
                    matrix02[i, j] = random1.Next(10);
                    Console.Write($"{matrix02[i, j],5} ");
                }
                Console.WriteLine();
            }

            int[,] Multmatrix = new int[matrix01.GetLength(0), matrix02.GetLength(1)];
            Console.WriteLine("\nMultiplication of two matrices");
            Console.WriteLine("MulMatrix = Matrix 1 * Matrix 2 ");
            for (int i = 0; i < matrix01.GetLength(0); i++)
            {
                for (int j = 0; j < matrix02.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix02.GetLength(0); k++)
                    {
                        Multmatrix[i, j] += matrix01[i, k] * matrix02[k, j];
                    }
                    Console.Write($"{Multmatrix[i, j],5} ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
