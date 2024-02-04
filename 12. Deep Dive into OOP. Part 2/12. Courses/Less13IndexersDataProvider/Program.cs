namespace Less13IndexersDataProvider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataProvider db = new DataProvider(
                 new Worker("Position_1", 10000, "Name_444"),
                 new Worker("Position_2", 10000, "Name_2"),
                 new Worker("Position_3", 10000, "Name_3"),
                 new Worker("Position_4", 10000, "Name_4"),
                 new Worker("Position_5", 10000, "Name_5")
            );

            Console.WriteLine(db[0]);

            Console.WriteLine(db["Name_3"]);

            Console.WriteLine(db["Name_7"] == null);    // True

            // Checking if a worker with the assumed name "Name_7" exists in the database,
            // and if so, printing their first name.
            if (db["Name_7"] != null)
                Console.WriteLine(db["Name_7"].FirstName);

            Console.WriteLine(db["Name_3", "Position_3"]);
        }
    }
}
