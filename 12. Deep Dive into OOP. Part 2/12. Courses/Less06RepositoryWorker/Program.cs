namespace Less06RepositoryWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data1 = new Repository(5);
            data1.Print("data 1");

            Repository data2 = data1;
            data2.Print("data 2");

            Console.WriteLine("\n === \n\n");


            // Attempting to change the first name of the worker at index 0 in the data1 instance.
            // The issue here is that data1 and data2 reference the same list of workers,
            // so modifying data1 also affects data2 due to the shared reference.

            // This operation might lead to unexpected behavior, as it modifies the original list.
            data1.ChangeFirstName(0, "New name");


            data1.Print("data 1");
            data2.Print("data 2");
        }
    }
}
