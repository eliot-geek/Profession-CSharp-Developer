using System.Diagnostics;

namespace _41EvenOddNumb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0) continue;       // Console.Write($"{i} ");

                Debug.Write(">>> ");
                Debug.Write($"{i} ");

                //Console.Write(">>> ");
                //Console.Write($"{i} ");

            }
            Console.ReadKey();
        }
    }
}