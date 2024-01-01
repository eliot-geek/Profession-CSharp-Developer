namespace _20LoopFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The for loop is used to pass through the block a specified number of times.
            // It uses three parameters.
            // The first parameter initializes the counter and is always executed once, before the loop.
            // The second parameter is the condition for the loop, it is checked before each iteration.
            // The third parameter contains the counter increment and is executed at the end of each iteration.

            //   First    ; Second; Third
            for (int i = 0; i < 10; i++)
            {
                // Loop's body
            }

            Console.WriteLine("Output the numbers from 0 to 9");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nOutput the numbers from -5 to 5");
            for (int i = -5; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nOutput the numbers from 10 to 1. First option");
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{10 - j} ");
            }

            Console.WriteLine("\nOutput the numbers from 10 to 1. Second variant");
            for (int k = 10; k >= 1; k--)
            {
                Console.Write($"{k} ");
            }

            Console.WriteLine("\nOutput the numbers from 1 to 22 in increments of 3");
            for (int counter = 1; counter <= 22; counter += 3)
            {
                Console.Write($"{counter} ");
            }

            Console.WriteLine("\nOutput the numbers from -1 to 1 in increments of 0.25");
            for (double step = -1; step <= 1; step += 0.25)
            {
                Console.Write($"{step} ");
            }

            Console.WriteLine("\nOutput the numbers from 1 to -1 in increments of 0.5");
            for (double interval = 1; interval >= -1; interval -= 0.5)
            {
                Console.Write($"{interval} ");
            }
            Console.ReadKey();
        }
    }
}