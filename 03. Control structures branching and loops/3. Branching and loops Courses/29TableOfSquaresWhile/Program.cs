namespace _29TableOfSquaresWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 2. A customer asks you to write a program in which the user enters an integer number start.
            // The program should output a table of squares of numbers from start to start+10

            // Loop
            //Console.Write("\nEnter start: ");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            //Console.WriteLine($"{start,4}^2 = {start * start}");


            // For
            //Console.Write("Enter start: ");
            //int start = Convert.ToInt32(Console.ReadLine());
            //for (int i = start; i <= start + 10; i++)
            //{
            //    Console.WriteLine($"{i,4}^2 = {i * i}");
            //}

            // While
            Console.Write("Enter start: ");
            int start = Convert.ToInt32(Console.ReadLine());

            int i = start;
            while (i <= start + 10)
            {
                Console.WriteLine($"{i,4}^2 = {i * i}");
                i++;
            }
        }
    }
}
