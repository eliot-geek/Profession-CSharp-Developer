namespace _36TableOfSquaresDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 2. A customer asks you to write a program in which the user enters an integer number start.
            // The program should output a table of squares of numbers from start to start+10

            Console.Write("Enter start: ");
            int start = Convert.ToInt32(Console.ReadLine());
            int i = start;
            do
            {
                Console.WriteLine($"{i,4}^2 = {i * i}");
                i++;
            } while (i <= start + 10);
        }
    }
}