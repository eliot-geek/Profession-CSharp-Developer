namespace _10JaggedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Jagged Arrays - 6. Array of arrays

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


            //         0     1     2     3
            //     ┌─────────────┐
            //     │ ┌───┐ ┌───┐ │
            //  0  │ │ 1 │ │ 3 │ │
            //     │ └───┘ └───┘ └───────────┐
            //     │ ┌───┐ ┌───┐ ┌───┐ ┌───┐ │
            //  1  │ │ 1 │ │ 0 │ │ 3 │ │ 1 │ │
            //     │ └───┘ └───┘ └───┘ └───┘ │
            //     │ ┌───┐ ┌───┐ ┌───┐ ┌─────┘
            //  2  │ │ 2 │ │ 0 │ │ 1 │ │
            //     │ └───┘ └───┘ └───┘ │
            //     └───────────────────┘

            // Toothed arrays are arrays of arrays. They can have irregular sizes. Sizes are distributed one at a time
            // Define a new jagged array named "jaggedArray" with 3 rows (i.e., arrays of different sizes). The size of each row is not specified at this point.
            int[][] jaggedArray = new int[3][];

            // Set the size of the first row to 2.
            // assign the values 1 and 3 to its two elements.
            jaggedArray[0] = new int[2];
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 3;

            // Set the size of the second row to 4.
            // Then assign the values 1, 0, 3, and 1 to its four elements.
            jaggedArray[1] = new int[4];
            jaggedArray[1][0] = 1;
            jaggedArray[1][1] = 0;
            jaggedArray[1][2] = 3;
            jaggedArray[1][3] = 1;

            // Set the size of the third row to 3.
            // Then assign the values 2, 0, and 1 to its three elements.
            jaggedArray[2] = new int[3];
            jaggedArray[2][0] = 2;
            jaggedArray[2][1] = 0;
            jaggedArray[2][2] = 1;

            // Loop through each row and each element in the row 
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    // Print out the value of each element to the console, separated by spaces.
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}