﻿namespace _07Array2DDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int col = int.Parse(Console.ReadLine());

            int[,] arr2d = new int[row, col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr2d[i, j] = r.Next(10);
                    Console.Write($"{arr2d[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Declare and instantiate a 2D string array with a predefined set of values
            string[,] table = new string[,] {
                                  { "00", "01", "02", "03" },
                                  { "10", "11", "12", "13" },
                                  { "20", "21", "22", "23" } 
                                };
            Console.WriteLine();

            // Output the rank and dimensions of the integer array to the console
            Console.WriteLine($"table.Rank = {arr2d.Rank}");
            Console.WriteLine($"table.GetLength(0) = {arr2d.GetLength(0)}");
            Console.WriteLine($"table.GetLength(1) = {arr2d.GetLength(1)}");

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j],3} ");
                }
                Console.WriteLine();
            }

            // GetLength() is a method of the multi-dimensional array that returns the length of the specified dimension of the array.
            // For example, if you have a two-dimensional array with dimensions [3,4], GetLength(0) will return 3, and GetLength(1) will return 4.
        }
    }
}
