namespace _06Array2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.4 Two-dimensional arrays: usage, assignment.

            // int[] collection = new int[3];

            // ┌───────────────────────────────────────────┐
            // │    ┌────────┐   ┌────────┐   ┌────────┐   │
            // │    │   31   │   │   12   │   │  1771  │   │
            // │    └────────┘   └────────┘   └────────┘   │
            // │         0            1           2        │
            // └───────────────────────────────────────────┘


            // int[,] matrix = new int[3, 4];

            //         0     1     2     3
            //     ┌─────────────────────────┐
            //     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            //  0  │ │ 1 │ │ 3 │ │ 0 │ │ 1 │ │
            //     │ └───┘ └───┘ └───┘ └───┘ │
            //     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            //  1  │ │ 1 │ │ 0 │ │ 3 │ │ 1 │ │
            //     │ └───┘ └───┘ └───┘ └───┘ │
            //     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            //  2  │ │ 2 │ │ 0 │ │ 1 │ │ 9 │ │
            //     │ └───┘ └───┘ └───┘ └───┘ │
            //     └─────────────────────────┘


            // Assigning a two-dimensional array with 3 rows and 4 columns.
            int[,] matrix = new int[3, 4];
            // Sets a value of 3 in the element at row 1 and column 2 of the matrix.
            matrix[1, 2] = 3;
            // Creates a new instance of the Random class to generate random integers.
            Random r = new Random();
            // This loop iterates over each row and column of the matrix and assigns a random integer between 0 and 9 to each element.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = r.Next(10);              // Assigns a random integer to the current element.
                    Console.Write($"{matrix[i, j]} ");      // Prints out the value of the current element.
                }
                Console.WriteLine();        // Moves to the next row of the matrix.
            }
        }
    }
}