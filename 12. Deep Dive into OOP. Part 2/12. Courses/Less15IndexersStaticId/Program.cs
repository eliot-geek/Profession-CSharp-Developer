namespace Less15IndexersStaticId
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uniqueness of IDs is guaranteed even if all workers have the same name (name_1).
            // This is due to the static nature of the staticId field and the use of a static method (NextId()) to generate unique IDs for each instance.

            List<Worker> db = new List<Worker>()
            {
                 new Worker("Position_1", 10000, "Name_1"), 
                 new Worker("Position_1", 10000, "Name_2"),
                 new Worker("Position_1", 10000, "Name_3"),
                 new Worker("Position_1", 10000, "Name_4"),
                 new Worker("Position_1", 10000, "Name_5"),
            };

            foreach (var e in db)
            {
                Console.WriteLine(e);
            }
        }
    }
}
