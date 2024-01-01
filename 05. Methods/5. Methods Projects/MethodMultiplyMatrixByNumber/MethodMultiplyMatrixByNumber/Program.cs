namespace MethodMultiplyMatrixByNumber
{
    internal class Program
    {
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


        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };
            int number = 3;
            int[,] resultMatrix = MultiplyMatrixByNumber(number, matrix);

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
