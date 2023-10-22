namespace MethodSumOfTwoMatrices
{
    internal class Program
    {
        static int[,] SumMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] sumMatrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return sumMatrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[,] matrix1 = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = new int[,] { { 5, 6 }, { 7, 8 } };

            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix1);
            Console.WriteLine("Matrix 2:");
            PrintMatrix(matrix2);

            int[,] sumMatrix = SumMatrices(matrix1, matrix2);

            Console.WriteLine("Sum Matrix:");
            PrintMatrix(sumMatrix);
        }
    }
}
