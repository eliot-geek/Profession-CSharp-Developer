namespace _34LoopDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The do-while loop continues executing the code block only if the continuation condition is true.
            // The condition is only checked at the end of each iteration. As a consequence, when using do-while, the loop body will be executed at least once

            bool condition = false;
            do
            {
                // Loop's body
            } while (condition);

            Console.WriteLine("OutPut of numbers from 0 to 9");
            int i = 0;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i < 10);

            Console.WriteLine("\n\nOutPut of numbers from -5 to 5");
            i = -5;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i <= 5);

            Console.WriteLine("\n\nOutPut of numbers from 10 to 1. First variant");
            int j = 0;
            do
            {
                Console.Write($"{10 - j} ");
                j++;
            } while (j < 10);

            Console.WriteLine("\n\nOutPut of numbers from 10 to 1. Second variant");
            int k = 10;
            do
            {
                Console.Write($"{k} ");
                k--;
            } while (k >= 1);

            Console.WriteLine("\n\nOutPut of numbers from 1 to 22 in increments of 3");
            int counter = 1;
            do
            {
                Console.Write($"{counter} ");
                counter += 3;
            } while (counter <= 22);

            Console.WriteLine("\n\nOutPut of numbers from -1 to 1 in increments of 0.25");
            double step = -1;
            do
            {
                Console.Write($"{step} ");
                step += 0.25;
            } while (step <= 1);

            Console.WriteLine("\n\nOutPut of numbers from 1 to -1 in increments of 0.5");
            double interval = 1;
            do
            {
                Console.Write($"{interval} ");
                interval -= 0.5;
            } while (interval >= -1);


            #region Remarque 1

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nRemarque 1 - Error");

            Console.WriteLine("\n\nOutPut the numbers from 1 to 22 in increments of 3");
            counter = 28;
            do
            {
                Console.Write($"{counter} ");
                counter += 3;
            } while (counter <= 27);

            Console.WriteLine("\n\nOutPut the numbers from -1 to 1 in increments of 0.25");
            step = 9;
            do
            {
                Console.Write($"{step} ");
                step += 0.25;
            } while (step <= 1);

            Console.WriteLine("\n\nOutPut the numbers from 1 to -1 in increments of 0.5");
            interval = -90;
            do
            {
                Console.Write($"{interval} ");
                interval -= 0.5;
            } while (interval >= -1);

            #endregion

            #region Remarque 2

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\nRemarque 2");

            Console.WriteLine("\n\nOutPut the numbers from 1 to 22 in increments of 3");
            counter = 28;
            if (counter < 22)
            {
                do
                {
                    Console.Write($"{counter} ");
                    counter += 3;
                } while (counter <= 27);
            }

            Console.WriteLine("\n\nOutPut the numbers from -1 to 1 in increments of 0.25");
            step = 9;
            if (step == 1)
            {
                do
                {
                    Console.Write($"{step} ");
                    step += 0.25;
                } while (step <= 1);
            }

            Console.WriteLine("\n\nOutPut the numbers from 1 to -1 in increments of 0.5");
            interval = -90;
            if (interval == 1)
            {
                do
                {
                    Console.Write($"{interval} ");
                    interval -= 0.5;
                } while (interval >= -1);
            }
            #endregion
            Console.ReadKey();
        }
    }
}