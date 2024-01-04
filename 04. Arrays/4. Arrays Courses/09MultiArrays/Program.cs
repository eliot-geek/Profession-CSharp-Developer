namespace _09MultiArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.5 Multidimensional Arrays: Use, Assignment

            // Create a new 3-dimensional array of integers with dimensions of 3, 4, and 5
            int[,,] matrix3D = new int[3, 4, 5];
            // Write the rank of the array (the number of dimensions it has) to the console
            Console.WriteLine($"matrix3D.Rank = {matrix3D.Rank}");
            // Write the total number of elements in the array to the console
            Console.WriteLine($"matrix3D.Length = {matrix3D.Length}");
            // Write the length of the first dimension of the array to the console
            Console.WriteLine($"matrix3D.GetLength(0) = {matrix3D.GetLength(0)}");
            // Write the length of the second dimension of the array to the console
            Console.WriteLine($"matrix3D.GetLength(1) = {matrix3D.GetLength(1)}");
            // Write the length of the third dimension of the array to the console
            Console.WriteLine($"matrix3D.GetLength(2) = {matrix3D.GetLength(2)}");
            
            // Create a new instance of the Random class
            Random r = new Random();
            // Iterate through each element in the 3-dimensional array
            for (int i = 0; i < matrix3D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3D.GetLength(2); k++)
                    {
                        // Assign a random integer between 0 and 9 to the current element
                        matrix3D[i, j, k] = r.Next(10);
                        // Write the current element to the console
                        Console.Write($"{matrix3D[i, j, k]} ");
                    }
                }
            }

            Console.WriteLine("\n\n");
            // Create a new 4-dimensional array of integers with dimensions of 3, 4, 5, and 6
            int[,,,] matrix4D = new int[3, 4, 5, 6];
            Console.WriteLine($"matrix4D.Rank = {matrix4D.Rank}");
            Console.WriteLine($"matrix4D.Length = {matrix4D.Length}");
            Console.WriteLine($"matrix4D.GetLength(0) = {matrix4D.GetLength(0)}");
            Console.WriteLine($"matrix4D.GetLength(1) = {matrix4D.GetLength(1)}");
            Console.WriteLine($"matrix4D.GetLength(2) = {matrix4D.GetLength(2)}");
            Console.WriteLine($"matrix4D.GetLength(3) = {matrix4D.GetLength(3)}");

            // Create a new instance of the Random class and assign a random integer to each element in the 4-dimensional array
            for (int i = 0; i < matrix4D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix4D.GetLength(2); k++)
                    {
                        for (int l = 0; l < matrix4D.GetLength(3); l++)
                        {
                            matrix4D[i, j, k, l] = r.Next(10);              // Assign a random integer between 0 and 9 to the current element
                            Console.Write($"{matrix4D[i, j, k, l]} ");       // Write the current element to the console
                        }
                    }
                }
            }

            Console.WriteLine("\n\n");
            // Create a new 5-dimensional array of integers with dimensions of 3, 4, 5, 6 and 10
            int[,,,,] matrix5D = new int[3, 4, 5, 6, 10];
            Console.WriteLine($"matrix5D.Rank = {matrix5D.Rank}");
            Console.WriteLine($"matrix5D.Length = {matrix5D.Length}");
            Console.WriteLine($"matrix5D.GetLength(0) = {matrix5D.GetLength(0)}");
            Console.WriteLine($"matrix5D.GetLength(1) = {matrix5D.GetLength(1)}");
            Console.WriteLine($"matrix5D.GetLength(2) = {matrix5D.GetLength(2)}");
            Console.WriteLine($"matrix5D.GetLength(3) = {matrix5D.GetLength(3)}");
            Console.WriteLine($"matrix5D.GetLength(4) = {matrix5D.GetLength(4)}");

            Console.WriteLine("\n\n");
            Console.ReadKey();
            // Define a new 6-dimensional double array named "matrix6D"
            double[,,,,,] matrix6D = new double[30, 43, 55, 61, 10, 7];
            // double[,,,,,] matrix6D = new double[30, 43, 55, 61, 10, 7];
            Console.WriteLine($"matrix6D.Rank = {matrix6D.Rank}");
            Console.WriteLine($"matrix6D.Length = {matrix6D.Length}");
            Console.WriteLine($"memory: {(matrix6D.Length * sizeof(double))}");
            Console.WriteLine($"matrix6D.GetLength(0) = {matrix6D.GetLength(0)}");
            Console.WriteLine($"matrix6D.GetLength(1) = {matrix6D.GetLength(1)}");
            Console.WriteLine($"matrix6D.GetLength(2) = {matrix6D.GetLength(2)}");
            Console.WriteLine($"matrix6D.GetLength(3) = {matrix6D.GetLength(3)}");
            Console.WriteLine($"matrix6D.GetLength(4) = {matrix6D.GetLength(4)}");
            Console.WriteLine($"matrix6D.GetLength(4) = {matrix6D.GetLength(5)}");
        }
    }
}