namespace DailyPlannerApp
{
    internal class Program
    {
        /// <summary>
        /// Initialize a Random object for generating random data
        /// </summary>
        private static readonly Random random = new();  

        /// <summary>
        /// Generates and Saves random records to the diary.
        /// </summary>
        /// <param name="diary">The diary to populate with random records.</param>
        private static void GenerateSave(Diary diary)
        {
            var records = new List<Record>();
            for (var i = 0; i < 10; i++)
            {
                var record = new Record
                {
                    Id = i,
                    Topic = RandomString(random.Next(2, 6)),
                    Body = RandomString(random.Next(15, 20)),
                    Name = RandomString(random.Next(5, 10)),
                    Date = DateTime.Now.AddDays(-i)
                };
                records.Add(record);
            }
            diary.AddRecords(records);
            diary.Save();
        }

        /// <summary>
        /// Generates a random string of a given length.
        /// </summary>
        /// <param name="length">The length of the random string to generate.</param>
        /// <returns>The generated random string.</returns>
        private static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }


        private static void Main(string[] args)
        {
            // Generates a list of random records, saves it, and prints it.
            var diary = new Diary();
            GenerateSave(diary);
            Console.Write("Automatically generated : \n" + diary);
            Console.ReadLine();

            // Orders records by different fields (Id, Topic, Body, Name, and Date) and prints each ordered list.
            var id = diary.OrderById();
            Console.Write($"\nOrder By Id : \n{string.Join(",\n", id)}");
            Console.ReadLine();
            var topic = diary.OrderByTopic();
            Console.Write($"\nOrder By Topic : \n{string.Join(",\n", topic)}");
            Console.ReadLine();
            var body = diary.OrderByBody();
            Console.Write($"\nOrder By Body : \n{string.Join(",\n", body)}");
            Console.ReadLine();
            var name = diary.OrderByName();
            Console.Write($"\nOrder By Name : \n{string.Join(",\n", name)}");
            Console.ReadLine();
            var date = diary.OrderByDate();
            Console.Write($"\nOrder By Date : \n{string.Join(",\n", date)}");
            Console.ReadLine();

            // Finds and prints records created between two specific dates.
            var records = diary.FindByDateBetween(DateTime.Now.AddDays(-6), DateTime.Now.AddDays(-2));
            var enumerable = records.ToList();
            Console.Write($"\nSorted list by created dates : \n{string.Join(",\n", enumerable)}");
            Console.ReadLine();

            // Deletes all printed dates from the diary.
            diary.DeleteRecords(enumerable);
            diary.Save();
            diary.Load();
            Console.Write("\nAfter deleting : \n" + diary);
            Console.ReadLine();

            // Edits a record in the diary.
            diary.records[2].Id = 55;
            diary.records[2].Topic = "Changed";
            diary.records[2].Body = "Changed";
            diary.records[2].Name = "Changed";
            diary.records[2].Date = DateTime.Now.AddDays(-22);
            diary.Save();
            diary.Load();
            Console.Write("\n\nAfter editing : \n" + diary);
            Console.ReadLine();

            // Adds a new record to the diary and prints it.
            var record = new Record
            {
                Id = 10,
                Topic = RandomString(random.Next(2, 6)),
                Body = RandomString(random.Next(15, 20)),
                Name = RandomString(random.Next(5, 10)),
                Date = DateTime.Now.AddDays(-10)
            };
            diary.AddRecord(record);
            diary.Save();
            diary.Load();
            Console.Write("\nAfter Adding one record : \n" + diary);
            Console.ReadLine();
        }
    }
}