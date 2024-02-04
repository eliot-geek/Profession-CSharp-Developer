namespace Less18NestedClassesBetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Worker> db = new List<Worker>()
            {
                 new Worker("Position_1", 04, "Name_1"),
                 new Worker("Position_2", 02, "Name_1"),
                 new Worker("Position_3", 03, "Name_2"),
                 new Worker("Position_4", 10, "Name_1"),
                 new Worker("Position_5", 05, "Name_3"),
                 new Worker("Position_5", 11, "Name_3"),
                 new Worker("Position_5", 52, "Name_3"),
                 new Worker("Position_5", 15, "Name_1"),
                 new Worker("Position_5", 45, "Name_1"),
                 new Worker("Position_5", 05, "Name_1"),
                 new Worker("Position_5", 05, "Name_1"),
                 new Worker("Position_5", 05, "Name_2"),
            };

            Console.WriteLine("Initial database");
            foreach (var e in db)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // db.Sort(); // IComparable
            
            db.Sort(Worker.SortedBy(SortedCriterion.Salary));
            Console.WriteLine("\nSortBySalary");
            foreach (var e in db)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            Console.WriteLine("\nSortByName");
            db.Sort(Worker.SortedBy(SortedCriterion.FirstName));
            foreach (var e in db)
            {
                Console.WriteLine(e);
            }
        }
    }
}
