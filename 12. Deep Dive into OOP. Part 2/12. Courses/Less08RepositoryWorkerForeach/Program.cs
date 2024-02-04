namespace Less08RepositoryWorkerForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Repository instance with 10 workers and printing the data.
            var rep = new Repository(10);
            rep.Print("Output");

            // Iterating over the workers directly using the Workers property.
            // This is functionally equivalent to using the foreach loop with rep.Workers.
            foreach (var item in rep.Workers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            // Need to Implement the IEnumerable next
            // Iterating over the workers using the foreach loop.
            // This demonstrates the use of IEnumerable implemented in the Repository class.
            //foreach (var item in rep)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();

        }
    }
}
