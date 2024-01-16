namespace Less03ListWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>();
            Random rand = new Random();

            for (int i = 1; i <= 10; i++)
            {
                workers.Add(
                    new Worker(
                        $"FirstName_{i}",
                        $"LastName_{i}",
                        $"Position_{i}",
                        $"Departement_{i}",
                        (uint)rand.Next(10000, 20000)));
            }

            foreach (var item in workers)
            {
                Console.WriteLine(item.Print());
            }
            Console.ReadKey();
        }
    }
}