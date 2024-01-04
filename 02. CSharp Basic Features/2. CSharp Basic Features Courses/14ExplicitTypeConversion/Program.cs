namespace _14ExplicitTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 330;          
            //byte j = i;           // Compiler error

            int i = 330; 
            byte j = (byte)i;       // no compiler error
            Console.WriteLine($"j = {j}"); // 74 (https://javarush.ru/groups/posts/2658-privedenie-tipa-int-k-tipu-short-i-byte)

            //double d = 1.2; //
            //byte byteValue = d; // Compiler error.

            double d = 1.2; 
            byte byteValue = (byte)d;   // no compiler's error
            Console.WriteLine($"byteValue = {byteValue}");

            int h = (int)d;
            Console.WriteLine($"h = {h}");

            int q = (int)((byte)d);
            Console.WriteLine($"q = {q}");
        }
    }
}