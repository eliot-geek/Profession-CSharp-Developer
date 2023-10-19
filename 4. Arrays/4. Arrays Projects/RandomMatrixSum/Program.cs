namespace RandomMatrixSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Random Matrix Summa

            Console.WriteLine($"Random Matrix Summa");
            Console.Write("Enter the number of rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int col = int.Parse(Console.ReadLine());

            while (row <= 0 | col <= 0)
            {
                Console.WriteLine("Error: Matrix cannot have zero/negative rows or columns.");
                row = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns: ");
                col = int.Parse(Console.ReadLine());
            }

            int sum = 0;
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
