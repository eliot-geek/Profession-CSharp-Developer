namespace Less01MethodAsParameter
{
    internal class Program
    {
        /// <summary>
        /// Generates a list of workers with random data.
        /// </summary>
        /// <param name="Count">The number of workers to generate. Default is 10.</param>
        /// <returns>A list of workers.</returns>
        static List<Worker> GetWorkers(int Count = 10)
        {
            var listOfWorkers = new List<Worker>();

            Random rand = new Random();
            
            for (int i = 0; i < Count; i++)
            {
                listOfWorkers.Add(new Worker($"Name_{i + 1}", $"LastName_{i + 1}", rand.Next(18, 70), rand.Next(20000, 30000)));
            }

            return listOfWorkers;
        }

        /// <summary>
        /// Determines whether the specified worker's age is greater than 40.
        /// </summary>
        /// <param name="obj">The worker to be checked.</param>
        /// <returns>True if the worker's age is greater than 40, otherwise false.</returns>
        private static bool Search(Worker obj)
        {
            return obj.Age > 40;
        }

        static void Main(string[] args)
        {
            // Generate a list of workers
            List<Worker> storage = GetWorkers();
            foreach (var item in storage)
                Console.WriteLine(item);
            Console.ReadLine();


            // Define a search predicate based on the Search method
            Predicate<Worker> search = new Predicate<Worker>(Search);
            var findsWorker = storage.FindAll(search);
            foreach (var item in findsWorker)
                Console.WriteLine(item);
            Console.ReadLine();


            // Find all workers in the storage using a delegate and an anonymous method
            var findsWorker1 = storage.FindAll(delegate (Worker obj)
            {
                return obj.Age > 40;
            });
            foreach (var item in findsWorker1)
                Console.WriteLine(item);
            Console.ReadLine();


            // Find all workers in the storage using a lambda expression
            var findsWorker2 = storage.FindAll((Worker obj) =>
            {
                return obj.Age > 40;
            });
            foreach (var item in findsWorker2)
                Console.WriteLine(item);
            Console.ReadLine();


            // Find all workers in the storage using a lambda expression with inferred parameter type
            // with an explicit return statement 
            var findsWorker3 = storage.FindAll((obj) =>
            {
                return obj.Age > 40;
            });
            foreach (var item in findsWorker3)
                Console.WriteLine(item);
            Console.ReadLine();


            // Find all workers in the storage using a lambda expression with implicit return
            var findsWorker4 = storage.FindAll(obj =>
            {
                return obj.Age > 40;
            });
            foreach (var item in findsWorker4)
                Console.WriteLine(item);
            Console.ReadLine();


            // Find all workers in the storage using a lambda expression with implicit return and single line body
            var findsWorker5 = storage.FindAll(obj => obj.Age > 40);
            foreach (var item in findsWorker4)
                Console.WriteLine(item);
            Console.ReadLine();


            // Find all workers in the storage using a lambda expression with single letter parameter
            var findsWorker6 = storage.FindAll(e => e.Age > 40);
            foreach (var item in findsWorker6)
                Console.WriteLine(item);
            Console.ReadLine();

        }
    }
}
