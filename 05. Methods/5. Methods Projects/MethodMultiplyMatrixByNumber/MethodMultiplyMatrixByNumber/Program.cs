namespace MethodMultiplyMatrixByNumber
{
    internal class Program
    {
        /// <summary>
        /// Multiplies each element of a given matrix by a specified number and returns the resulting matrix.
        /// </summary>
        /// <param name="number">The number to be multiplied by each element in the matrix.</param>
        /// <param name="matrix">The matrix to be multiplied.</param>
        /// <returns>The matrix obtained after multiplying each element by the specified number.</returns>
        public static int[,] MultiplyMatrixByNumber(int number, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix[i, j] * number;
                }
            }

            return result;
        }

        /// <summary>
        /// Outputs the provided two-dimensional array (matrix) to the console with specified formatting.
        /// </summary>
        /// <param name="matrix">The matrix to be printed to the console.</param>
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
            int number = 3;
            int[,] resultMatrix = MultiplyMatrixByNumber(number, matrix);

            Console.WriteLine("Result Matrix:");
            PrintMatrix(resultMatrix);
        }
    }
}
