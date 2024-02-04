namespace Less14IndexersWorkerProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Worker> db = new List<Worker>()
            {
                new Worker("Position_1", 10000, "Name_1", 1), // Error on index
                new Worker("Position_2", 10000, "Name_2", 1),
                new Worker("Position_3", 10000, "Name_3", 1),
                new Worker("Position_4", 10000, "Name_4", 4),
                new Worker("Position_5", 10000, "Name_5", 5)
            };

            foreach (var e in db)
            {
                Console.WriteLine(e);
            }
        }
    }
}
