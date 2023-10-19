namespace _21ReiterationLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1. Generate 10 random numbers from -8 to 9

            //Random rand = new Random();
            //Console.WriteLine($"1-e random number {rand.Next(-8, 10)}");
            //Console.WriteLine($"2-e random number {rand.Next(-8, 10)}");
            //Console.WriteLine($"3-e random number {rand.Next(-8, 10)}");
            //Console.WriteLine($"4-e random number {rand.Next(-8, 10)}");
            //Console.WriteLine($"5-e random number {rand.Next(-8, 10)}");
            //Console.WriteLine($"6-e random number {rand.Next(-8, 10)}");
            //Console.WriteLine($"7-e random number {rand.Next(-8, 10)}");
            //Console.WriteLine($"8-e random number {rand.Next(-8, 10)}");
            //Console.WriteLine($"9-e random number {rand.Next(-8, 10)}");
            //Console.WriteLine($"10-e random number {rand.Next(-8, 10)}");


            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}-e random number {r.Next(-8, 10)}  ");
            }
            Console.ReadKey();
        }
    }
}