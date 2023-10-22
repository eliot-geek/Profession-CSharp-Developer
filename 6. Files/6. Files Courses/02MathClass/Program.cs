namespace _02MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 1: Built-in methods. Math Class

            // Math Class provides constants and static methods for various common mathematical functions, including trigonometric and logarithmic functions.
            // To calculate the area of a circle with a radius of 2 using the formula S circl. = πr²
            // Math.PI - represents  the constant π (the ratio of the circumference of a circle to its diameter), defined as a constant.
            // Math.E  - represents  the base of the natural logarithm, defined as a constant.
            // Math.Abs - Returns the absolute value of a number.
            // Trigonometric functions such as Sin, Cos, Tan, Atan, Tanh, etc.
            // Log and Log10 functions for logarithmic calculations.
            // Max and Min functions to find the maximum or minimum of two values.
            // var result = Math.Max(11, 22); // assigns the larger value between 11 and 22 to the "result" variable.

            // Returns the smallest integer that is greater than or equal to the given decimal number.
            Console.WriteLine(Math.Ceiling(1.2));   // 2
            Console.WriteLine(Math.Ceiling(-1.2));  // -1

            // Returns the value of e raised to the specified power.
            Console.WriteLine(Math.Exp(2)); // e² = e^2 = ( e = 2.71828 so 2.71828^2 = 7.38905609893065)

            // Returns the largest integer less than or equal to the specified decimal number.
            Console.WriteLine(Math.Floor(1.2)); // 1
            Console.WriteLine(Math.Floor(-1.2)); // -2

            // Returns the specified number raised to the specified power.
            Console.WriteLine(Math.Pow(4, 3));       // 4³
            Console.WriteLine(Math.Pow(2020, 2));    // 2020²

            // Rounds a decimal value to a specified number of fractional digits.
            Console.WriteLine(Math.Round(1.2345)); // 1
            Console.WriteLine(Math.Round(1.5345)); // 2
            Console.WriteLine(Math.Round(-1.5345)); // -2
            Console.WriteLine(Math.Round(-1.56789, 3)); // -1,568

            // Returns an integer that indicates the sign of an 8-bit signed integer.
            Console.WriteLine(Math.Sign(-20));  // -1
            Console.WriteLine(Math.Sign(20));   // 1

            int r = 2;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
