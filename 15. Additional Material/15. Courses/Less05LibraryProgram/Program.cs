using Less05LibraryProgramClassLibrary1;

namespace Less05LibraryProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Less05LibraryProgramClassLibrary1.MyMath.Sum(12, 34);
            Console.WriteLine(result);

            var sum = MyMath.Sum(12, 34);
            Console.WriteLine($"r = {sum}");

            Console.ReadKey();
        }
    }
}
