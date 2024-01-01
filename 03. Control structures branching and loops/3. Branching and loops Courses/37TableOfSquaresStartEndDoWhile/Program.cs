namespace _37TableOfSquaresStartEndDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 3. A customer asks you to write a program in which the user can enter two integers start and end.
            // The program should print a table of squares of numbers from start to end.
            // (!) The difference between start and end can't be more than 20

            Console.Write("Enter start: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter end: ");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start <= end)
            do
            {
                Console.WriteLine($"{start,4}^2 = {start * start}");
                start++;
            } while (start <= end);
            Console.ReadKey();
        }
    }
}