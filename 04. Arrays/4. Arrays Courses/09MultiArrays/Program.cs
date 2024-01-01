﻿namespace _09MultiArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.5 Multidimensional Arrays: Usage and Assignment

            int[,,] matrix3D = new int[3, 4, 9];
            Console.WriteLine($"matrix3D.Rank = {matrix3D.Rank}");
            Console.WriteLine($"matrix3D.Length = {matrix3D.Length}");
            Console.WriteLine($"matrix3D.GetLength(0) = {matrix3D.GetLength(0)}");
            Console.WriteLine($"matrix3D.GetLength(1) = {matrix3D.GetLength(1)}");
            Console.WriteLine($"matrix3D.GetLength(2) = {matrix3D.GetLength(2)}");

            Random r = new Random();

            for (int i = 0; i < matrix3D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix3D.GetLength(2); k++)
                    {
                        matrix3D[i, j, k] = r.Next(10);
                        Console.Write($"{matrix3D[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n\n");
            // Create a new 4-dimensional array of integers with dimensions of 3, 4, 6, and 9
            int[,,,] matrix4D = new int[3, 4, 6, 9];
            Console.WriteLine($"matrix4D.Rank = {matrix4D.Rank}");
            Console.WriteLine($"matrix4D.Length = {matrix4D.Length}");
            Console.WriteLine($"matrix4D.GetLength(0) = {matrix4D.GetLength(0)}");
            Console.WriteLine($"matrix4D.GetLength(1) = {matrix4D.GetLength(1)}");
            Console.WriteLine($"matrix4D.GetLength(2) = {matrix4D.GetLength(2)}");
            Console.WriteLine($"matrix4D.GetLength(3) = {matrix4D.GetLength(3)}");

            for (int i = 0; i < matrix4D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix4D.GetLength(2); k++)
                    {
                        for (int l = 0; l < matrix4D.GetLength(3); l++)
                        {
                            matrix4D[i, j, k, l] = r.Next(10);
                            Console.Write($"{matrix4D[i, j, k, l]} ");
                        }
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("\n\n");
            // Creating a new 5-dimensional array of integers with dimensions of 3, 4, 1, 3, and 9
            int[,,,,] matrix5D = new int[3, 4, 1, 3, 9];
            Console.WriteLine($"matrix5D.Rank = {matrix5D.Rank}");
            Console.WriteLine($"matrix5D.Length = {matrix5D.Length}");
            Console.WriteLine($"matrix5D.GetLength(0) = {matrix5D.GetLength(0)}");
            Console.WriteLine($"matrix5D.GetLength(1) = {matrix5D.GetLength(1)}");
            Console.WriteLine($"matrix5D.GetLength(2) = {matrix5D.GetLength(2)}");
            Console.WriteLine($"matrix5D.GetLength(3) = {matrix5D.GetLength(3)}");
            Console.WriteLine($"matrix5D.GetLength(4) = {matrix5D.GetLength(4)}");

            // Initializing the array with random values using nested loops for each dimension
            for (int i = 0; i < matrix5D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix5D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix5D.GetLength(2); k++)
                    {
                        for (int l = 0; l < matrix5D.GetLength(3); l++)
                        {
                            for (int m = 0; m < matrix5D.GetLength(4); m++)
                            {
                                matrix5D[i, j, k, l, m] = r.Next(10);
                                Console.Write($"{matrix5D[i, j, k, l, m]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }

            Console.WriteLine("\n\n");

            // Define a new 6-dimensional double array named "matrix6D"
            double[,,,,,] matrix6D = new double[2, 2, 1, 1, 2, 5];
            Console.WriteLine($"matrix6D.Rank = {matrix6D.Rank}");
            Console.WriteLine($"matrix6D.Length = {matrix6D.Length}");
            Console.WriteLine($"memory: {(matrix6D.Length * sizeof(double))}");
            Console.WriteLine($"matrix6D.GetLength(0) = {matrix6D.GetLength(0)}");
            Console.WriteLine($"matrix6D.GetLength(1) = {matrix6D.GetLength(1)}");
            Console.WriteLine($"matrix6D.GetLength(2) = {matrix6D.GetLength(2)}");
            Console.WriteLine($"matrix6D.GetLength(3) = {matrix6D.GetLength(3)}");
            Console.WriteLine($"matrix6D.GetLength(4) = {matrix6D.GetLength(4)}");
            Console.WriteLine($"matrix6D.GetLength(5) = {matrix6D.GetLength(5)}");
            
            for (int i = 0; i < matrix6D.GetLength(0); i++)
            {
                for (int j = 0; j < matrix6D.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix6D.GetLength(2); k++)
                    {
                        for (int l = 0; l < matrix6D.GetLength(3); l++)
                        {
                            for (int m = 0; m < matrix6D.GetLength(4); m++)
                            {
                                for (int n = 0; n < matrix6D.GetLength(5); n++)
                                {
                                    matrix6D[i, j, k, l, m, n] = r.NextDouble() * 100;
                                    Console.Write($"{matrix6D[i, j, k, l, m, n]:F2} ");
                                }
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}