namespace _13Reiteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1. Generate 10 random numbers from -8 to 9

            Random rand = new Random();

            Console.WriteLine($"1-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"2-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"3-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"4-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"5-e random number {rand.Next(-8, 10)}");

            Console.WriteLine($"6-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"7-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"8-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"9-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"10-e random number {rand.Next(-8, 10)}");

            Console.WriteLine($"11-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"12-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"13-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"14-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"15-e random number {rand.Next(-8, 10)}");

            Console.WriteLine($"16-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"17-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"18-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"19-e random number {rand.Next(-8, 10)}");
            Console.WriteLine($"20-e random number {rand.Next(-8, 10)}");

            // If the client needs 20 random numbers, then copy/paste ? and if he needs another 100, then copy/paste again ? 
            // Of course not, so we have to use a loop
            // Not recommended
        }
    }
}