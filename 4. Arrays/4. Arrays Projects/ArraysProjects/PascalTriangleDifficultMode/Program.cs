namespace PascalTriangleDifficultMode
{
    internal class Program
    {
        // Define the size of the triangle as a 2D array with dimensions row x row, where 'row' is a static variable that is set to 20. 
        public static int row = 10;
        public static int[,] triangle = new int[row, row];
        // Define a constant value for the cell width of each number in the triangle, which is set to 5.
        public const int cellWidth = 5;

        // A method to fill the triangle with numbers using Pascal's triangle algorithm, where the first and last
        // values in each row are set to 1, and each other value is the sum of the two values above it in the row above.
        public static void FillTriangle()
        {
            for (int i = 0; i < row; i++)
            {
                triangle[i, 0] = 1;
                triangle[i, i] = 1;
            }

            for (int i = 2; i < row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                }
            }
        }

        // A method to print the filled triangle to the console, where each cell is displayed with a width of 'cellWidth' characters.
        // The method iterates over each row and each column in the triangle, and prints each non-zero value with the defined cell width.
        public static void PrintTriangle()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (triangle[i, j] != 0) 
                        Console.Write($"{triangle[i, j],cellWidth}");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            #region Task 2

            // The client needs an application that builds the first N rows of Pascal's triangle. N < 25.
            // When N = 9, the triangle looks like this:

            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1

            // Pascal's triangle is a triangular array of numbers in which the first and last numbers of each row are 1,
            // and each of the remaining numbers is the sum of the two numbers directly above it. 

            // Reference - https://en.wikipedia.org/wiki/Pascal%27s_triangle

            #endregion


            #region Solution 1

            // Print the title of the program to the console
            Console.WriteLine("Pascal triangle - Difficult Mode");
            // Create a 2D array with size of 25 x 25 - This size is chosen as a maximum size to accommodate the largest possible value of N.
            int[,] array2D = new int[25, 25];
            // Ask the user to input an integer value for N
            Console.Write("Enter n (N < 25): ");
            // Read the user input as an integer and store it in the variable n
            int n = int.Parse(Console.ReadLine());

            int width = 0;
            for (int i = 0; i < n; i++)
            {
                while (n > 25)
                {
                    Console.Write("You entered more than your memory allotment. Again : ");
                    n = int.Parse(Console.ReadLine());
                }
                // Set the console cursor position to the center of the window by subtracting half of the current width of the string (width) from the center position 
                Console.SetCursorPosition((Console.WindowWidth / 2) - width / 2, i);
                // Reset the width of the string to zero at the beginning of each row, since the width will be recalculated
                // and incremented as each element is printed to the console in the current row 
                width = 0;
                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        array2D[i, j] = 1;
                    }
                    else
                    {
                        array2D[i, j] = array2D[i - 1, j] + array2D[i - 1, j - 1];
                    }
                    Console.Write(array2D[i, j] + " ");
                    // Add the length of the current element (array2D[i, j]) plus a space to the width of the string, so that
                    // the total width of the string for the current row can be calculated and used to set the cursor position.
                    width = width + $"{array2D[i, j]} ".Length;
                }
                Console.WriteLine();
            }
            Console.ReadKey(); Console.Clear();
            #endregion


            #region Perfect Solution

            FillTriangle();
            int col = cellWidth * row;
            Console.ReadLine();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.SetCursorPosition(col, i + 0);
                    if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
                    col += cellWidth * 2;
                }
                // After the inner loop finishes printing the values for the current row, it resets the column position 
                // to the rightmost position of the row, and then moves down to the next line to start printing the next row.
                col = cellWidth * row - cellWidth * (i + 1);
                Console.WriteLine();
            }

            Console.ReadKey(); 
            Console.Clear();
            
            
            FillTriangle();
            PrintTriangle();

            #endregion
        }
    }
}