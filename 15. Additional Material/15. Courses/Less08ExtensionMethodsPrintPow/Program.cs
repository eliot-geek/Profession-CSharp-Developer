namespace Less08ExtensionMethodsPrintPow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            2.Pow(4).Print();
            Console.ReadLine();


            List<int> vs = new List<int>();
            vs.Add(1);
            2.AddToList(vs);
            vs.Print();
            Console.ReadLine();


            2.Pow(8).Print();


            // Docs
            // https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
            // https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/extension-methods#general-guidelines
        }
    }
}
