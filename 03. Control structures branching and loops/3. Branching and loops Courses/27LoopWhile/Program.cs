namespace _27LoopWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The while loop executes a block of code only if its condition is true and it will continue as long as the condition is true.
            // The condition is only checked at the beginning of each iteration.

            bool condition = false;
            while (condition)
            {
                // Loop's body
            }

            Console.WriteLine("OutPut the numbers from 0 to 9");
            int i = 0;
            while (i < 10)
            {
                Console.Write($"{i} ");
                i++;
            }

            Console.WriteLine("\nOutPut the numbers from -5 to 5");
            i = -5;
            while (i <= 5)
            {
                Console.Write($"{i} ");
                i++;
            }

            Console.WriteLine("\nOutPut the numbers from 10 to 1. First variant");
            int j = 0;
            while (j < 10)
            {
                Console.Write($"{10 - j} ");
                j++;
            }

            Console.WriteLine("\nOutPut the numbers from 10 to 1. Second variant");
            int k = 10;
            while (k >= 1)
            {
                Console.Write($"{k} ");
                k--;
            }

            Console.WriteLine("\nOutPut the numbers from 1 to 22 in increments of 3");
            int counter = 1;
            while (counter <= 22)
            {
                Console.Write($"{counter} ");
                counter += 3;
            }

            Console.WriteLine("\nOutPut the numbers from -1 to 1 in increments of 0.25");
            double step = -1;
            while (step <= 1)
            {
                Console.Write($"{step} ");
                step += 0.25;
            }

            Console.WriteLine("\nOutPut the numbers from 1 to -1 in increments of 0.5");
            double interval = 1;
            while (interval >= -1)
            {
                Console.Write($"{interval} ");
                interval -= 0.5;
            }
            Console.ReadKey();
        }
    }
}