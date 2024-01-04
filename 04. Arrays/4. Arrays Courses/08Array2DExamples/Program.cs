namespace _08Array2DExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrange the elements of the one-dimensional array A consisting of 9 numbers in rows in the matrix B[3×3].

            //// Create an array of integers with 9 elements
            //int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //// Create a new two-dimensional array of integers with 3 rows and 3 columns
            //int[,] b = new int[3, 3];

            //// Initialize a counter for the one-dimensional array
            //int counterA = 0;
            //// Loop through the rows of the two-dimensional array
            //for (int i = 0; i < b.GetLength(0); i++)
            //{
            //    for (int j = 0; j < b.GetLength(1); j++)
            //    {
            //        // Assign the next value from the one-dimensional array to the current element of the two-dimensional array
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

            //Random r = new Random();        // Create a new instance of the Random class
            //var Z = new double[3, 3];       // Create a new 3x3 two-dimensional array of doubles
            //Console.WriteLine("The original matrix Z[3x3]: ");      // Print a message indicating that the original matrix is being generated
            //// Loop through the rows of the two-dimensional array
            //for (int i = 0; i < Z.GetLength(0); i++)
            //{
            //    // Loop through the columns of the two-dimensional array
            //    for (int j = 0; j < Z.GetLength(1); j++)
            //    {
            //        // Assign a random value between 1 and 9 to the current element of the two-dimensional array
            //        Z[i, j] = r.Next(1, 10);
            //        // Print the current element of the two-dimensional array with a fixed width of 6 characters
            //        Console.Write($"{Z[i, j],6} ");
            //    }
            //    Console.WriteLine(); // Move to the next line in the console
            //}

            //// Print a message indicating that the transformed matrix is being generated
            //Console.WriteLine("The matrix Z[3x3] after transformation: ");
            //// Loop through the rows of the two-dimensional array
            //for (int i = 0; i < Z.GetLength(0); i++)
            //{
            //    // Get the diagonal element for the current row
            //    double div = Z[i, i];
            //    // Loop through the columns of the two-dimensional array
            //    for (int j = 0; j < Z.GetLength(1); j++)
            //    {
            //        // Divide the current element by the diagonal element and assign the result to the current element
            //        Z[i, j] /= div;
            //        // Print the current element of the two-dimensional array with a fixed width of 6 characters
            //        Console.Write($"{Z[i, j],6} ");
            //    }
            //    Console.WriteLine(); // Move to the next line in the console
            //}

            #endregion

            #region Find the sum of elements for each row of the matrix A[4x4]

            //// Create a new instance of the Random class
            //Random r = new Random();
            //// Create a new 2-dimensional array of integers with 4 rows and 4 columns
            //var A = new int[4, 4];
            //// Write a message to the console to indicate the original matrix is being displayed
            //Console.WriteLine("Original matrix A[4x4]: ");

            //// Iterate through each row of the array
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    int sum = 0;   // Create a variable to keep track of the sum of elements in the current row
            //    // Iterate through each column of the array for the current row
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        // Assign a random integer between 1 and 3 to the current element
            //        A[i, j] = r.Next(1, 3);
            //        // Add the current element to the sum for the current row
            //        sum += A[i, j];
            //        // Write the current element to the console with a width of 2 characters
            //        Console.Write($"{A[i, j],2} ");
            //    }
            //    // Write the sum of elements for the current row to the console
            //    Console.WriteLine($" : {sum}");
            //}

            #endregion
        }
    }
}