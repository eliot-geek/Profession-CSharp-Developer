namespace MethodMultiplyMatrixByNumber
{
    internal class Program
    {
        // This method takes in a number and a matrix and returns the matrix multiplied by the number
        public static int[,] MultiplyMatrixByNumber(int number, int[,] matrix)
        {
            // Get the number of rows and columns in the matrix
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Create a new matrix to store the result of the multiplication
            int[,] result = new int[rows, columns];

            // Loop through each element in the matrix and multiply it by the number
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix[i, j] * number;
                }
            }
            // Return the result matrix
            return result;
        }


        static void Main(string[] args)
        {
            // Example input matrix
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };

            // Example number to multiply the matrix by
            int number = 3;

            // Call the MultiplyMatrixByNumber method and store the result in a new matrix
            int[,] resultMatrix = MultiplyMatrixByNumber(number, matrix);

            // Print the result matrix to the console
            Console.WriteLine("Result Matrix:");
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}