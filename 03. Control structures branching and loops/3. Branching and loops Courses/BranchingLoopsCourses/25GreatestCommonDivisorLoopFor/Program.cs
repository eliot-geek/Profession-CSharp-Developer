namespace _25GreatestCommonDivisorLoopFor
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

            //Console.Write("Enter a numerator: ");
            //double numerator = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter a denominator: ");
            //double denominator = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"\nThe original fraction {numerator} / {denominator}");
            //double a = numerator, b = denominator;
            //// This solution is not suitable for all numbers (For example 80 -- 9900)
            //// It's wrong! 
            //if (a != b) if (a > b) a = a - b; else b = b - a;
            //if (a != b) if (a > b) a = a - b; else b = b - a;
            //if (a != b) if (a > b) a = a - b; else b = b - a;
            //if (a != b) if (a > b) a = a - b; else b = b - a;
            //Console.WriteLine($"Can be reduced by {a}");
            //Console.WriteLine($"Abbreviated fraction {numerator / a} / {denominator / a}");


            Console.Write("Enter the numerator: ");
            double numerator = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the denominator: ");
            double denominator = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Original fraction {numerator}/{denominator}");
            double a = numerator, b = denominator;

            // Initialize a counter variable named "count" to zero
            int count = 0;
            // Start a loop that iterates 1000 times
            for (int i = 0; i < 1000; i++)
            {
                // Check if variables "a" and "b" are not equal
                if (a != b)
                {
                    // If "a" is greater than "b", subtract "b" from "a", otherwise subtract "a" from "b"
                    if (a > b) a = a - b; else b = b - a;
                    // Output the values of "a" and "b" to the console
                    Console.WriteLine($"{a}  {b}");
                    // Increment the counter variable by one
                    count++;
                    // break;
                }
                // Output the value of the loop index variable "i" to the console
                //Console.WriteLine($"i = {i} ");
            }
            Console.WriteLine($"count = {count}");

            #region for (; a != b;)

            //for (; a != b;)
            //{
            //    if (a > b) a = a - b; else b = b - a;
            //}

            #endregion

            Console.WriteLine($"It's possible to reduce by {a}");
            Console.WriteLine($"Reduced fraction {numerator / a}/{denominator / a}");
        }
    }
}