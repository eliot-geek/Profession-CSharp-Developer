namespace _07TernaryOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ternary operator

            // In addition to the if operator, there is a so-called ternary operator (?:).
            // This operator can replace a single if-else clause, which assigns a value to a specific variable. 
            // The operator takes three expressions. 
            // If the first one is evaluated as true, the second expression will be returned, and if it is false, the third one is returned.

            // Create a new Random object to generate random numbers
            Random r = new Random();
            // Getting a number from 0.0 to 1.0, not including 1.0
            double x = r.NextDouble();
            Console.WriteLine($"Random x = {x}");

            // Ternary operator (?:)
            int result = (x < 0.5) ? 0 : 1;
            Console.WriteLine($"\nResult1 = {result}");

            if (x < 0.5)
            {
                result = 0;
            }
            else
            {
                result = 1;
            }
            Console.WriteLine($"\nResult2 = {result}");

            #region Remarque

            Console.WriteLine("\nResult3 = " + (x < 0.5 ? 0 : 1) + "\n");
            if (x < 0.5)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
            Console.ReadKey();

            #endregion
        }
    }
}