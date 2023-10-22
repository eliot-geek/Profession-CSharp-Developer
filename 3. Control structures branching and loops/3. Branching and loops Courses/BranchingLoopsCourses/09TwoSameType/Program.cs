namespace _09TwoSameType
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Random rand = new Random();

            int a = rand.Next(-21, 23);
            int b = rand.Next(-21, 23);
            Console.WriteLine($"randomInt a = {a}");
            Console.WriteLine($"randomInt b = {b}");

            bool f = a > b;
            int outputInt = f ? a : b;
            Console.WriteLine($"\nMaxInt = {outputInt}");

            string OutPutString = f ? "YES" : "NO";
            Console.WriteLine($"\nBoolMax is {OutPutString}");

            Console.ReadKey();
        }
    }
}