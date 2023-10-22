namespace _13ImplicitTypeСonversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte byteValue = 1;             // Setting a variable value of byte type
            short shortValue = byteValue;   // Implicit conversion of byte to short
            int intValue = shortValue;      // implicit conversion short to int
            long longValue = intValue;      // Implicit conversion of int to long
            double doubleValue = longValue; // Implicit conversion long to double

            char c = 'a';
            int d = c;

            Console.WriteLine(d); // 97
        }
    }
}