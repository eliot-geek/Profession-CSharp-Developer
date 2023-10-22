namespace RandomMatrixSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Random Matrix Summa

            // Task 5.Random matrix
            // Display a matrix of a given size on the screen and fill it with random numbers. Detailed algorithm of the application:

            // First, the user is prompted to enter the number of rows in the future matrix.
            // Then - enter the number of columns in the future matrix.
            // When the data is received, create a matrix of the given size in memory.
            // Using Random, fill the matrix with random integers.
            // Display the obtained matrix on the screen.
            // Display the sum of all elements of this matrix on the screen in a separate line.
            // Recommendation:
            // Use nested loops to work with matrices.

            //What is evaluated:
            //The program displays on the screen a randomly created matrix of a predetermined size, as well as the sum of all elements in it.


            Console.WriteLine($"Random Matrix Summa");
            // Prompt the user to enter the number of rows and columns
            Console.Write("Enter the number of rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int col = int.Parse(Console.ReadLine());

            // Check the matrix
            while (row <= 0 | col <= 0)
            {
                Console.WriteLine("Error: Matrix cannot have zero/negative rows or columns.");
                row = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns: ");
                col = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            // Create the matrix
            int[,] array2D = new int[row, col];
            Console.WriteLine($"\narray2D.Length = {array2D.Length}");
            Console.WriteLine($"memory: {(array2D.Length * sizeof(int))}\n");

            // Fill, Display the matrix with random numbers using Random and Calculate the sum of all elements
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array2D[i, j] = random.Next(10);
                    Console.Write($"{array2D[i, j],4} ");
                    sum += array2D[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("The sum of all elements is: " + sum);
            Console.ReadKey();

            #endregion
        }
    }
}