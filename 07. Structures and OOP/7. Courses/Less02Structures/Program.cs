namespace Less02Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Developer", 20000, "Anders", "Heljsberg", new DateTime(1989, 3, 4));
            Worker worker1 = new Worker("Developer",
                                       20000,
                                       "Anders",
                                       "Heljsberg",
                                       new DateTime(1989, 3, 4));
            Console.WriteLine(worker.Print());
            Console.WriteLine(worker1.Print());


            // Another example
            worker = new Worker("Messi");
            Console.WriteLine(worker.Print());


            // Another example
            Worker w = new Worker()
            {
                FirstName = "Anders",
                LastName = "Heljsberg"
            };
            Console.WriteLine(w.Print());

            Console.ReadLine();
        }
    }
}