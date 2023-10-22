namespace _05NestedLoopsBreakContinueOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.3 Nested loops, break and continue operators.

            #region Print the multiplication table

            // 2 x 1 = 2        3 x 1 = 3          4 x 1 = 4
            // 2 x 2 = 4        3 x 2 = 6          4 x 2 = 8
            // 2 x 3 = 6        3 x 3 = 9          4 x 3 = 12
            // 2 x 4 = 8        3 x 4 = 12         4 x 4 = 16
            // 2 x 5 = 10       3 x 5 = 15         4 x 5 = 20
            // 2 x 6 = 12       3 x 6 = 18         4 x 6 = 24
            // 2 x 7 = 14       3 x 7 = 21         4 x 7 = 28
            // 2 x 8 = 16       3 x 8 = 24         4 x 8 = 32
            // 2 x 9 = 18       3 x 9 = 27         4 x 9 = 36
            // 2 x 10 = 20      3 x 10 = 30        4 x 10 = 40

            //// This code prints out the multiplication tables for 2, 3, and 4. It uses a for loop to iterate through the numbers 1 to 10,
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"2 x {i} = {2 * i}");
            //}
            //Console.WriteLine();

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"3 x {i} = {3 * i}");
            //}
            //Console.WriteLine();

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"4 x {i} = {4 * i}");
            //}
            //Console.WriteLine(); Console.ReadKey();

            #region ToDo

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #endregion

            #region Show all possible three-letter words from the alphabet S K I L

            // 4 * 4 * 4 = 4^3

            #region ToDo

            //// An array of characters is defined.
            //char[] symbols = { 'S', 'K', 'I', 'L' };
            //int count = 1;      // A count variable is defined and initialized to 1.

            //// Three nested loops are used to generate all possible combinations of three letters.
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    for (int j = 0; j < symbols.Length; j++)
            //    {
            //        for (int k = 0; k < symbols.Length; k++)
            //        {
            //            // For each combination, the count and combination are printed to the console.
            //            Console.WriteLine($"{count++,3}: {symbols[i]}{symbols[j]}{symbols[k]}");
            //        }
            //    }
            //}

            #endregion

            #endregion

            #region Find at least one solution to the equation in integer numbers

            //     ┌                             ┐
            //     │     ┌   ┐ 3         ┌   ┐ 2 │
            //     │ 2 × │ a │    +  3 × │ b │   │ = 8337
            //     │     └   ┘           └   ┘   │
            //     └                             ┘

            // 2 * 1^3 + 3 * 1^2
            // 2 * 1^3 + 3 * 2^2
            // 2 * 1^3 + 3 * 3^2
            // 2 * 1^3 + 3 * 4^2
            // 2 * 1^3 + 3 * 5^2
            // ...
            // 2 * 2^3 + 3 * 1^2
            // 2 * 2^3 + 3 * 2^2
            // 2 * 2^3 + 3 * 3^2
            // 2 * 2^3 + 3 * 4^2
            // 2 * 2^3 + 3 * 5^2
            // ...
            // 2 * 3^3 + 3 * 1^2
            // 2 * 3^3 + 3 * 2^2
            // 2 * 3^3 + 3 * 3^2
            // 2 * 3^3 + 3 * 4^2
            // 2 * 3^3 + 3 * 5^2  // Not good

            #region ToDo

            // The code attempts to find at least one solution to the equation 2a^3 + 3b^2 = 8337 in integer numbers.

            //for (double a = -500; a < 500; a++)
            //{
            //    for (double b = -500; b < 500; b++)
            //    {
            //        // If a pair of values of a and b satisfy the equation, then print out the solution.
            //        if ((2 * a * a * a + 3 * b * b) == 8337) Console.WriteLine($"a = {a}  b = {b}");
            //    }
            //}

            #endregion

            #endregion

            #region break и continue

            //// Prints out all possible pairs of integers between 0 and 9
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write($"({i} {j})  ");
            //    }
            //}
            //Console.WriteLine();

            //// A variable "count" is initialized to zero to store the number of odd integers.
            //int count = 0;
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i % 2 == 0) continue;
            //    for (int j = 0; j < 1000; j++)
            //    {
            //        break;
            //        //Console.Write($"({i} {j})  ");
            //        //count++;
            //    }
            //    count++;
            //}
            //Console.WriteLine($"count = {count}");
            //Console.WriteLine();

            #endregion

            // "Break" is used to terminate a loop early, skipping over any remaining iterations. When a "break" statement is encountered within a loop,
            // the program immediately exits the loop and continues with the code following the loop.

            // "Continue" is used to skip the current iteration of a loop and move on to the next iteration.
            // When a "continue" statement is encountered within a loop, the program skips the current iteration and proceeds with the next iteration of the loop.
        }
    }
}