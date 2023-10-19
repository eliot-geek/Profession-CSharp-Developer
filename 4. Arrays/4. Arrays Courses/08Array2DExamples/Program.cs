namespace _08Array2DExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrange the elements of the one-dimensional array A consisting of 9 numbers in rows in the matrix B[3×3].

            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[,] b = new int[3, 3];

            //int counterA = 0;
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        b[i, j] = a[counterA++];
            //        Console.Write($"{b[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region In the matrix Z[3×3], divide each element by the diagonal element in the same column.

            //  1 2 3
            //  4 5 6
            //  7 8 9

            //Random r = new Random();        
            //var Z = new double[3, 3];       
            //Console.WriteLine("The original matrix Z[3x3]: ");      
            //for (int i = 0; i < Z.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Z.GetLength(1); j++)
            //    {
            //        Z[i, j] = r.Next(1, 10);
            //        Console.Write($"{Z[i, j],6} ");
            //    }
            //    Console.WriteLine(); 
            //}

            //Console.WriteLine("The matrix Z[3x3] after transformation: ");
            //for (int i = 0; i < Z.GetLength(0); i++)
            //{
            //    double div = Z[i, i];    // Get the diagonal element for the current row
            //    for (int j = 0; j < Z.GetLength(1); j++)
            //    {
            //        Z[i, j] /= div;    // Divide the current element by the diagonal element and assign the result to the current element
            //        Console.Write($"{Z[i, j],6} ");
            //    }
            //    Console.WriteLine(); 
            //}

            #endregion

            #region Find the sum of elements for each row of the matrix A[4x4]

            //Random r = new Random();
            //var A = new int[4, 4];
            //Console.WriteLine("Original matrix A[4x4]: ");

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    int sum = 0;  
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        // Assign a random integer between 1 and 3 to the current element
            //        A[i, j] = r.Next(1, 3);
            //        sum += A[i, j];
            //        Console.Write($"{A[i, j],2} ");
            //    }
            //    Console.WriteLine($" : {sum}");
            //}

            #endregion
        }
    }
}
