namespace _01Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a randomize variable to get random numbers
            Random randomize = new Random();

            // Understanding the range of values that can be stored in different numeric data types in C#.
            Console.WriteLine($"int.MaxValue = {int.MaxValue}");
            Console.WriteLine($"int.MinValue = {int.MinValue}\n");

            Console.WriteLine($"byte.MaxValue = {byte.MaxValue}");
            Console.WriteLine($"byte.MinValue = {byte.MinValue}\n");

            Console.WriteLine($"uint.MaxValue = {uint.MaxValue}");
            Console.WriteLine($"uint.MinValue = {uint.MinValue}\n");

            Console.WriteLine($"long.MaxValue = {long.MaxValue}");
            Console.WriteLine($"long.MinValue = {long.MinValue}\n");

            // Returns a non-negative random integer 32-bit integer with a sign that is greater than or equal to 0 and less than Int32.MaxValue.
            int RandomIntResult = randomize.Next();
            Console.WriteLine($"First Example. RandomIntResult = {RandomIntResult}\n");

            // Returns a non-negative random integer that is less than the maximum allowed value between 0 and 100, not including 100 
            RandomIntResult = randomize.Next(100);
            Console.WriteLine($"Second Example. RandomIntResult = {RandomIntResult}\n");

            // Returns a non-negative random integer that is greater than the minimum allowed value and less than the maximum allowed value between 10 and 100, not including 100
            RandomIntResult = randomize.Next(10, 100);
            Console.WriteLine($"Third Example. RandomIntResult = {RandomIntResult}\n");

            // Returns a random floating point number that is greater than or equal to 0.0 and less than 1.0 not including 1.0
            double RandomDoubleResult = randomize.NextDouble();
            Console.WriteLine($"Fourth Example. RandomDoubleResult = {RandomDoubleResult}\n");

            // Returns a random floating point number that is greater than or equal to 0.0 and less than 100.0
            double RandomDoubleResult1 = randomize.NextDouble() * 100;
            Console.WriteLine($"Fifth Example. RandomDoubleResult1 = {RandomDoubleResult1}\n");

            // The Next(100) method generates a random integer between 0 and 99 (inclusive), and the NextDouble() method generates a random double precision floating-point number between 0.0 and 1.0.
            // When the two values are added together, the resulting value will be a random double precision floating-point number between 0.0 and 100.0.
            double RandomDoubleResult2 = randomize.NextDouble() + randomize.Next(100);
            Console.WriteLine($"Sixth Example. RandomDoubleResult2 = {RandomDoubleResult2}\n");

            Console.ReadKey();
        }
    }
}