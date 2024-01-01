namespace _14TableOfSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 2. A customer asks you to write a program in which the user enters an integer number start.
            // The program should output a table of squares of numbers from start to start+10

            Console.Write("\nEnter start: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;

            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;
            Console.WriteLine($"{start,4}^2 = {start * start}"); start++;

            Console.WriteLine($"{start,4}^2 = {start * start}");

            // If there are 50, 100 or more? Copy/paste? Of course not, that's why we have to use Loop
            // Not recommended again
        }
    }
}