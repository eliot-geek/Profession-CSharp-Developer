namespace MethodMultiplyMatrixByNumberInput
{
    internal class Program
    {
        /// <summary>
        /// Delays the closure of the console, providing a visual effect.
        /// </summary>
        static void Delay()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Displays the provided message in the console.
        /// </summary>
        /// <param name="Text">The text message to be displayed.</param>
        static void Print(string Text)
        {
            Console.Write(Text);
        }

        /// <summary>
        /// Fills the provided two-dimensional array (matrix) with random values.
        /// </summary>
        /// <param name="array2D">The matrix to be filled with random values.</param>
        static void Fill(int[,] array2D)
        {
            Random random = new Random();
            int rows = array2D.GetUpperBound(0) + 1;    // GetUpperBound() returns the largest index. Upper bound is rows - 1. So, adding 1 gives us the actual number of rows in the 2D array.
            int colums = array2D.Length / rows;         // Dividing array2D.Length by rows gives us the number of elements per row, which is equal to the number of columns. 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    array2D[i, j] = random.Next(10);
                }
            }
        }

        /// <summary>
        /// Outputs the provided two-dimensional array (matrix) to the console with specified formatting.
        /// </summary>
        /// <param name="array2D">The matrix to be printed to the console.</param>
        static void Print(int[,] array2D)
        {
            Random random = new Random();
            int rows = array2D.GetUpperBound(0) + 1;
            int colums = array2D.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array2D[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Multiplies a given matrix by a specified number and returns the resulting matrix.
        /// </summary>
        /// <param name="multiplier">The number to be multiplied by each element in the matrix.</param>
        /// <param name="array2D">The matrix to be multiplied.</param>
        /// <returns>The matrix obtained after multiplying each element by the specified number.</returns>
        static int[,] Array2D(int multiplier, int[,] array2D)
        {
            int row = array2D.GetUpperBound(0) + 1;
            int col = array2D.Length / row;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2D[i, j] *= multiplier;
                }
            }
            return array2D;
        }


        /// <summary>
        /// Outputs the provided two-dimensional array (matrix) to the console with specified formatting.
        /// </summary>
        /// <param name="matrix">The matrix to be printed to the console.</param>
        static void PrintArray(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }

                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"Multiply_matrix_by_number");
            Print("Enter the number of rows: ");               
            int row = int.Parse(Console.ReadLine());
            Print("Enter the number of columns: ");             
            int col = int.Parse(Console.ReadLine());

            while (row <= 0 || col <= 0)
            {
                Console.WriteLine($"You entered invalid numbers (Enter numbers greater than zero!!). Try again.");
                Print("Enter number of rows: ");
                row = int.Parse(Console.ReadLine());
                Print("Enter the number of columns: ");
                col = int.Parse(Console.ReadLine());
            }

            int[,] array2D = new int[row, col];
            Fill(array2D);      
            Print(array2D);    
            Console.Write($"Enter the number by which we'll multiply the matrix: ");
            int multiplier = int.Parse(Console.ReadLine());
            int[,] Array2Dproduit = Array2D(multiplier, array2D);   
            Console.Write($"\nAfter multiplying a mathematical matrix by the number {multiplier} we get this beauty\n");
            Console.WriteLine();
            PrintArray(Array2Dproduit);
            Delay(); 
        }
    }
}
