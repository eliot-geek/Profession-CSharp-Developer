namespace MethodProductOfTwoMatricesInput
{
    internal class Program
    {
        /// <summary>
        /// A method to make the console close delayed
        /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// A method to display the message in the console
        /// </summary>
        /// <param name="Text">Message Text</param>
        static void Print(string Text)
        {
            Console.Write(Text);
        }

        /// <summary>
        /// The method that fills in the matrices
        /// </summary>
        /// <param name="matrix"></param>
        static void Fill(int[,] matrix)
        {
            Random random = new Random();
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }
        }

        /// <summary>
        /// A method that outputs matrices
        /// </summary>
        /// <param name="matrix"></param>
        static void Print(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method that returns the product of matrices
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        static int[,] Array2D(int[,] matrix1, int[,] matrix2)
        {
            int[,] Array2DMul = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            int rows1 = matrix1.GetLength(0);
            int rows2 = matrix2.GetLength(0);
            int colums2 = matrix2.GetLength(1);

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < colums2; j++)
                {
                    for (int k = 0; k < rows2; k++)
                    {
                        Array2DMul[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return Array2DMul;
        }


        /// <summary>
        /// Outputs the provided two-dimensional array to the console with specified formatting.
        /// </summary>
        /// <param name="matrix">The matrix to be printed to the console.</param>
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Matrix_multiplication");
            Print("Enter the number of rows of the first matrix: ");
            int rows1 = int.Parse(Console.ReadLine());
            Print("Enter the number of columns of the first matrix: ");
            int colums1 = int.Parse(Console.ReadLine());

            while (rows1 <= 0 || colums1 <= 0)
            {
                Console.WriteLine($"You were driving invalid numbers. (Such matrices cannot be multiplied because the number of columns " +
                    $"of the first matrix is not equal to the number of rows of the second matrix, or their values are less than or equal to zero.) Try again");
                Print("{Insert the number of rows of the first matrix: ");
                rows1 = int.Parse(Console.ReadLine());
                Print("Enter the number of columns of the first matrix: ");
                colums1 = int.Parse(Console.ReadLine());
            }

            int[,] matrix1 = new int[rows1, colums1];
            Console.WriteLine("\nFirst matrix");
            Console.WriteLine("Matrix 1: ");
            Fill(matrix1);
            Print(matrix1);

            Print("\nEnter the number of rows of the second matrix: ");
            int rows2 = int.Parse(Console.ReadLine());
            Print("Enter the number of columns of the second matrix: ");
            int colums2 = int.Parse(Console.ReadLine());

            while (rows1 <= 0 || colums1 <= 0 || colums1 != rows2)
            {
                Console.WriteLine($"You were driving invalid numbers. (Such matrices cannot be multiplied because the number of columns " +
                    $"of the first matrix does not equal the number of rows of the second matrix, or their values are less than or equal to zero.) Try again");
                Print("{Insert the number of rows of the second matrix: ");
                rows2 = int.Parse(Console.ReadLine());
                Print("Enter the number of columns of the second matrix: ");
                colums2 = int.Parse(Console.ReadLine());
            }

            int[,] matrix2 = new int[rows2, colums2];
            Console.WriteLine("\nSecond matrix");
            Console.WriteLine("Matrix 2: ");
            Fill(matrix2);
            Print(matrix2);


            Console.WriteLine("\nMultiplication of two matrices");
            Console.WriteLine("Array2DMul = Matrix 1 * Matrix 2 ");
            int[,] Array2DMul = Array2D(matrix1, matrix2);
            PrintMatrix(Array2DMul);

            Delay();
        }
    }
}