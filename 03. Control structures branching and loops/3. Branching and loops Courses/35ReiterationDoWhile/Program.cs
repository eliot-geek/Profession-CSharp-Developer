namespace _35ReiterationDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1. Generate 10 random numbers from -8 to 9

            Random r = new Random();
            int i = 0;
            do
            {
                Console.WriteLine($"{i + 1}-e random number {r.Next(-8, 10)}  ");
                i++;
            } while (i < 10);
            Console.ReadKey();
        }
    }
}