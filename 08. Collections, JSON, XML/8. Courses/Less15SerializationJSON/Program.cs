using Newtonsoft.Json;

namespace Less15SerializationJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Install-Package Newtonsoft.Json

            #region Worker

            Worker worker = new Worker("Bill", "Gates", "CEO", uint.MaxValue, "Microsoft");
            Console.WriteLine(worker.Print());
            Console.ReadLine();

            // Serialize the Worker object to JSON format and write it to a file named "_bill.json".
            string json = JsonConvert.SerializeObject(worker);
            File.WriteAllText("_bill.json", json);


            // Read the JSON content from the file "_satya.json" and deserialize it back to a Worker object.
            json = File.ReadAllText("_satya.json");
            worker = JsonConvert.DeserializeObject<Worker>(json);
            Console.WriteLine(worker.Print());
            Console.ReadLine();

            #endregion

            #region List<Worker>

            List<Worker> list = new List<Worker>();

            // Populate the list with Worker objects using a loop
            for (uint i = 1; i <= 5; i++)
            {
                list.Add(new Worker($"Name_{i}", $"LastName_{i}", $"Position_{i}", i * 1000, $"Department{i}"));
            }

            // Serialize the list of Worker objects to JSON format and write it to a file named "_listWorker.json".
            json = JsonConvert.SerializeObject(list);
            File.WriteAllText("_listWorker.json", json);

            foreach (var e in list)
            {
                Console.WriteLine(e.Print());
            }
            Console.WriteLine();
            Console.ReadLine();


            // Read the JSON content from the file "_listWorker.json" and deserialize it back to a List<Worker>.
            json = File.ReadAllText("_listWorker.json");
            list = JsonConvert.DeserializeObject<List<Worker>>(json);

            Console.WriteLine();
            foreach (var e in list)
            {
                Console.WriteLine(e.Print());
            }
            Console.WriteLine();


            // Display the last names of each worker in the list.
            foreach (var item in list)
            {
                Console.WriteLine($"{item.LastName, 15}");
            }
            Console.ReadLine();


            // Display the department names of each worker in the list.
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Departement, 15}");
            }

            // List<Mystruct> db = new List<List<List<int>>>();

            #endregion
        }
    }
}