namespace _39GreatestCommonDivisorDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 5. The user enters two integers, numerator and denominator, which are the numerator and denominator, respectively
            // Find out if it is possible to reduce the fraction and if so, by what number.
            //   50     25      5     1
            // ----- = ---- = ---- = ---
            //  100     50     10     2

            // https://en.wikipedia.org/wiki/Greatest_common_divisor (Greatest common divisor)
            // https://en.wikipedia.org/wiki/Euclidean_algorithm (Euclidean algorithm)
            // Mathematics 5th grade. Theme "Reduction of fractions".

            Console.Write("Enter the numerator: ");
            double numerator = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the denominator: ");
            double denominator = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Original fraction {numerator}/{denominator}");
            double a = numerator, b = denominator;

            #region for
            //for (int i = 0; i < 100000; i++)
            //{
            //    if (a != b) if (a > b) a = a - b; else b = b - a;
            //}
            #endregion

            if (a != b)
            {
                do
                {
                    if (a > b) a = a - b; else b = b - a;

                    Console.WriteLine($">>> {a} {b}"); 
                } while (a != b);
            }

            Console.WriteLine($"It's possible to reduce by {a}");
            Console.WriteLine($"Reduced fraction {numerator / a}/{denominator / a}");
        }
    }
}