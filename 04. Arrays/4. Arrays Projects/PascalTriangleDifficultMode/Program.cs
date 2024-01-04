namespace PascalTriangleDifficultMode
{
    internal class Program
    {
        public static int row = 10;
        public static int[,] triangle = new int[row, row];
        // Define a constant value for the cell width of each number in the triangle, which is set to 5.
        public const int cellWidth = 5;

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
            #region Optimal Solution

            Console.WriteLine("Pascal triangle - Difficult Mode");
            int[,] array2D = new int[25, 25];
            Console.Write("Enter n (N < 25): ");
            int n = int.Parse(Console.ReadLine());

            int width = 0;
            for (int i = 0; i < n; i++)
            {
                while (n > 25)
                {
                    Console.Write("You entered more than your memory allotment. Again : ");
                    n = int.Parse(Console.ReadLine());
                }

                Console.SetCursorPosition((Console.WindowWidth / 2) - width / 2, i);
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
                    width = width + $"{array2D[i, j]} ".Length;
                }
                Console.WriteLine();
            }
            Console.ReadKey(); 
            Console.Clear();
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
                    if (triangle[i, j] != 0) 
                        Console.Write($"{triangle[i, j],cellWidth}");

                    // Move the column position for the next number
                    col += cellWidth * 2;
                }

                // Reset column position for the next row
                col = cellWidth * row - cellWidth * (i + 1);
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.Clear();


            // Another way
            FillTriangle();
            PrintTriangle();
            Console.ReadKey();

            #endregion
        }
    }
}
