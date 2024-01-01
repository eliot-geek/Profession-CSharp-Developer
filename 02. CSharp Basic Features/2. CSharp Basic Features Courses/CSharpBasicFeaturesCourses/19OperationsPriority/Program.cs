namespace _19OperationsPriority
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unary operations
            int a = +10;
            a = -a;                 // a = -1 * 10;
            Console.WriteLine(a);   // -10

            // Prefix increment
            int c = 0;
            Console.WriteLine(++c); // first - 1
            Console.WriteLine(c);   // 1
            // %, /, * 
            // +, -
            // Postfix increment
            // () - brackets change the operations priority

            Console.WriteLine((2 + 2) * 2); // 8
        }
    }
}