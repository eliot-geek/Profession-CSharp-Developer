using Newtonsoft.Json.Linq;
using System;

namespace Less16SerializationJSONComplicated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parse

            // Read the content of the "telegram.json" file into a string
            string json = File.ReadAllText("telegram.json");

            Console.WriteLine(json);
            Console.ReadLine();
            Console.Clear();

            // Parse the JSON and display the value of the "ok" property.
            Console.WriteLine(JObject.Parse(json)["ok"].ToString());
            Console.ReadLine();
            Console.Clear();

            var messages = JObject.Parse(json)["result"].ToArray();
            Console.ReadLine();
            Console.Clear();

            foreach (var item in messages)
            {
                Console.WriteLine(item["message"]["message_id"].ToString());
                Console.WriteLine(item["message"]["text"].ToString());
                Console.WriteLine(item["message"]["chat"]["username"].ToString());
                Console.WriteLine();
            }
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Create

            // Create a JArray and a JObject to build a JSON structure.
            JArray array = new JArray();
            JObject mainTree = new JObject();

            mainTree["ok"] = true;

            // Create a sample JObject for updates and add it to the JArray multiple times.
            JObject o = new JObject();
            o["update_id"] = 1880746;
            o["message_id"] = 886;

            array.Add(o);
            array.Add(o);
            array.Add(o);

            mainTree["messages"] = array;

            JObject userObj = new JObject();
            userObj["id"] = 220310598;
            userObj["first_name"] = "A.C.";
            userObj["username"] = "ac";

            mainTree["user"] = userObj;

            json = mainTree.ToString();

            Console.WriteLine("Done!");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region JSON (List<Worker>)

            List<Worker> list = new List<Worker>();

            // Create a JObject to store data
            JObject data = new JObject();
            JArray jArray = new JArray();

            // Populate the JArray with Worker objects
            for (uint i = 1; i <= 5; i++)
            {
                // Create a JObject for each Worker and add it to the JArray
                JObject obj = new JObject
                {
                    ["FirstName"] = $"Name_{i}",
                    ["LastName"] = $"LastName_{i}",
                    ["Position"] = $"Position_{i}",
                    ["Department"] = $"Department_{i}",
                    ["Salary"] = i * 1000
                };
                jArray.Add(obj);
            }

            // Display the generated JSON string for the first set of Workers.
            Console.WriteLine(jArray.ToString());
            Console.ReadLine();
            Console.Clear();


            JArray jArray1 = new JArray();
            for (uint i = 1; i <= 3; i++)
            {
                JObject obj = new JObject();
                obj["FirstName"] = $"Name_{i}";
                obj["LastName"] = $"LastName_{i}";
                obj["Position"] = $"Position_{i}";
                obj["Department"] = $"Department_{i}";
                obj["Salary"] = i * 1000;
                jArray1.Add(obj);
            }

            Console.WriteLine(jArray1.ToString());
            Console.ReadKey();

            #endregion
        }
    }
}