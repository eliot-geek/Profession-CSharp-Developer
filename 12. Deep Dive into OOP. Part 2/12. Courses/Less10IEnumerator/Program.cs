namespace Less10IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rep = new Repository(10);
            rep.Print("Output");

            // Iterating over the workers using the foreach loop.
            // This demonstrates the use of IEnumerable implemented in the Repository class.
            foreach (var item in rep)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
