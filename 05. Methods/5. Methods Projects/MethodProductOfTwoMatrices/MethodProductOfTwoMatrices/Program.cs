namespace MethodProductOfTwoMatrices
{
    internal class Program
    {
        static int[,] ProductMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);       //  "rows1" represents the number of rows in the first matrix
            int cols1 = matrix1.GetLength(1);       //  "cols1" represents the number of columns in the first matrix
            int cols2 = matrix2.GetLength(1);       //  "cols2" represents the number of columns in the second matrix.

            int[,] productMatrix = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    productMatrix[i, j] = sum;
                }
            }
            return productMatrix;
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

            int[,] productMatrix = ProductMatrices(matrix1, matrix2);

            Console.WriteLine("Product Matrix:");
            PrintMatrix(productMatrix);
        }
    }
}
