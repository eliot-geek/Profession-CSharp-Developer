using System.Runtime.InteropServices;

namespace _04FloatPointTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Floating-point types can store real numbers with different precision.

            // Fixed floating point numbers in C# are always stored as variables of type double,
            // To use float type we need to add F or f at the end. 
            // Analogously for decimal type it is necessary to add M or m at the end 
            // Analogously for double type adding of D or d is optional 

            // Example
            float floatVariable = 3.14F;
            double doubleVariable = 3.14;
            decimal decimalVariable = 3.14M;

            // Float type accepts values from ±1.5 x 10^(-45) to ±3.4 x 10^38  - It has a precision of 7 digits

            floatVariable = 1.12345678910f;
            Console.WriteLine(floatVariable); // 1.1234567

            // Type double takes values from ±5.0 × 10^(-324) to ±1.7 × 10^308 precision - 15 digits doubleVariable = 1.1234567898765431d;

            doubleVariable = 1.1234567898765431d;
            Console.WriteLine(doubleVariable); // 1,12345678987654

            // decimal type accepts values from ±1.0 x 10^(-28) to ±7.9228 x 10^28 - It has a precision from 28 to 29 decimal places

            decimalVariable = 1.12345678912345678901234567891234m;
            Console.WriteLine(decimalVariable); // 1,1234567891234567890123456789

            Console.ReadKey();
        }
    }
}