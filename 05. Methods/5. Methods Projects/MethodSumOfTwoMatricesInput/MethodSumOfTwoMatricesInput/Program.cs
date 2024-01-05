namespace MethodSumOfTwoMatricesInput
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
        /// <param name="Text">Текст сообщения</param>
        static void Print(string Text)
        {
            Console.Write(Text);
        }

        /// <summary>
        /// Fills the provided two-dimensional array (matrix) with random integer values.
        /// </summary>
        /// <param name="matrix1">The matrix to be filled with random values.</param>
        static void Fill(int[,] matrix1)
        {
            Random random = new Random();
            int rows = matrix1.GetUpperBound(0) + 1;        // GetUpperBound(0) returns the upper bound of the first dimension of the array
            int columns = matrix1.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix1[i, j] = random.Next(10);
                }
            }
        }

        /// <summary>
        /// Outputs the provided two-dimensional array (matrix) to the console.
        /// </summary>
        /// <param name="matrix1">The matrix to be printed to the console.</param>
        static void Print(int[,] matrix1)
        {
            int rows = matrix1.GetUpperBound(0) + 1;
            int colums = matrix1.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix1[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Fills the provided two-dimensional array (matrix) with random integer values.
        /// </summary>
        /// <param name="matrix2">The matrix to be filled with random values.</param>
        static void Fill2(int[,] matrix2)
        {
            Random random = new Random();
            int rows = matrix2.GetUpperBound(0) + 1;
            int colums = matrix2.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    matrix2[i, j] = random.Next(10);
                }
            }
        }

        /// <summary>
        /// Outputs the provided two-dimensional array (matrix) to the console.
        /// </summary>
        /// <param name="matrix2">The matrix to be printed to the console.</param>
        static void Print2(int[,] matrix2)
        {
            int rows = matrix2.GetUpperBound(0) + 1;
            int colums = matrix2.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix2[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Computes the sum of two matrices and returns the resulting matrix.
        /// </summary>
        /// <param name="matrix1">The first matrix for addition.</param>
        /// <param name="matrix2">The second matrix for addition.</param>
        /// <returns>The resulting matrix obtained by adding corresponding elements of the input matrices.</returns>
        static int[,] Array2D(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetUpperBound(0) + 1;
            int columns = matrix1.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix1[i, j] += matrix2[i, j];
                }
            }

            return matrix1;
        }

        /// <summary>
        /// Outputs the provided two-dimensional array to the console with specified formatting.
        /// </summary>
        /// <param name="Array2Add">The array to be printed to the console.</param>
        static void PrintSumArrays(int[,] Array2Add)
        {
            for (int i = 0; i < Array2Add.GetLength(0); i++)
            {
                for (int j = 0; j < Array2Add.GetLength(1); j++)
                {
                    Console.Write($"{Array2Add[i, j],5} ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Adding mathematical matrices");
            Print("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Print("Enter the number of columns: ");
            int colums = int.Parse(Console.ReadLine());

            while (rows <= 0 || colums <= 0)
            {
                Console.WriteLine($"You entered invalid numbers (Enter numbers greater than zero!!). Try again.");
                Print("Enter the number of rows: ");
                rows = int.Parse(Console.ReadLine());
                Print("Enter the number of columns: ");
                colums = int.Parse(Console.ReadLine());
            }

            int[,] matrix1 = new int[rows, colums];
            Console.WriteLine("\nFirst matrix");
            Console.WriteLine("Matrix 1: ");
            Fill(matrix1);
            Print(matrix1);


            int[,] matrix2 = new int[rows, colums];
            Console.WriteLine("\nSecond Matrix");
            Console.WriteLine("Matrix 2: ");
            Fill2(matrix2);
            Print2(matrix2);

            int[,] Array2Add = Array2D(matrix1, matrix2);
            Console.WriteLine("\nAddition of two matrixes");
            Console.WriteLine("Array2Add = Matrix 1 + Matrix 2 ");
            Console.WriteLine();
            PrintSumArrays(Array2Add);
            Delay();
        }
    }
}