namespace _12DataTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 100;   // implicit conversion
            int a = b;      // all right

            //int i = 10; //
            //byte j = i; // Compiler error.

            double d = a;   // all good
            //int g = d;    // compiler error
        }
    }
}