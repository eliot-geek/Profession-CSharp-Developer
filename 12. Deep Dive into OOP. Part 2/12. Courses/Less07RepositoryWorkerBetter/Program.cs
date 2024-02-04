namespace Less07RepositoryWorkerBetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Repository instance with 5 workers and printing the data.
            var data1 = new Repository(5);
            data1.Print("data 1");


            // Creating a reference to the cloned Repository instance using ICloneable.
            Repository data2 = (Repository)data1.Clone();
            data2.Print("data 2");


            Console.WriteLine("\n === \n\n");


            // Attempting to change the first name of the worker at index 0 in the data1 instance.
            // Since data1 and data2 now reference different instances due to cloning,
            // modifying data1 does not affect data2.

            // This resolves the issue of unexpected behavior caused by modifying the original list.
            data1.ChangeFirstName(0, "New name");


            // Printing the data for both instances to demonstrate the cloned and independent references.
            data1.Print("data 1");
            data2.Print("data 2");
        }
    }
}
