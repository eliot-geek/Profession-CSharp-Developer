using System.Xml.Serialization;

namespace Less13SerializationXml
{
    internal class Program
    {
        /// <summary>
        /// Method to Serialize a Worker Object
        /// </summary>
        /// <param name="ConcreteWorker">The Worker object to be serialized</param>
        /// <param name="Path">The file path where the serialized data will be saved</param>
        static void SerializeWorker(Worker ConcreteWorker, string Path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));                // Create an XML serializer for the Worker type.
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);       // Create a stream for writing data to the specified file.
            xmlSerializer.Serialize(fStream, ConcreteWorker);                               // Serialize the ConcreteWorker object and save it to the file.
            fStream.Close();                                                                // Close the stream after serialization.
        }

        /// <summary>
        /// Method to Deserialize a Worker Object
        /// </summary>
        /// <param name="Path">The file path from which the serialized data will be read</param>
        /// <returns>The deserialized Worker object</returns>
        static Worker DeserializeWorker(string Path)
        {
            //Worker tempWorker = new Worker();                                             
            Worker? tempWorker = new Worker();                                              // Create a temporary Worker object.
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Worker));                // Create an XML serializer for the Worker type.
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);          // Create a file stream for reading data from the specified file.
            tempWorker = xmlSerializer.Deserialize(fStream) as Worker;                      // Deserialize the data from the file into the tempWorker object.
            fStream.Close();                                                                // Close the file stream.
            
            return tempWorker;                                                              // Return the deserialized Worker object.
        }

        /// <summary>
        /// Method to serialize a List of Worker objects.
        /// </summary>
        /// <param name="concreteWorkerList">The List of Worker objects to be serialized.</param>
        /// <param name="path">The file path where the serialization output will be saved.</param>
        static void SerializeWorkerList(List<Worker> ConcreteWorkerList, string Path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            xmlSerializer.Serialize(fStream, ConcreteWorkerList);
            fStream.Close();
        }

        /// <summary>
        /// Method to deserialize a List of Worker objects from an XML file.
        /// </summary>
        /// <param name="path">The file path from which to deserialize the data.</param>
        /// <returns>A List of Worker objects deserialized from the specified file.</returns>
        static List<Worker> DeserializeWorkerList(string Path)
        {
            //List<Worker> tempWorkerCol = new List<Worker>();
            List<Worker>? tempWorkerCol = new List<Worker>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Worker>));
            Stream fStream = new FileStream(Path, FileMode.Open, FileAccess.Read);
            tempWorkerCol = xmlSerializer.Deserialize(fStream) as List<Worker>;
            fStream.Close();

            return tempWorkerCol;
        }

        static void Main(string[] args)
        {
            #region Worker

            Worker worker = new Worker("Elon", "Musk", "Founder", uint.MaxValue, "Tesla");
            Console.WriteLine(worker.Print());
            SerializeWorker(worker, "_elon.xml");
            Console.WriteLine();

            worker = DeserializeWorker("_jroyce.xml");
            Console.WriteLine(worker.Print());
            Console.WriteLine();

            #endregion


            #region List<Worker>

            List<Worker> list = new List<Worker>();
            for (uint i = 1; i <= 5; i++)
            {
                list.Add(new Worker($"Name_{i}", $"LastName_{i}", $"Position_{i}", i * 1000, $"Department_{i}"));
            }
            SerializeWorkerList(list, "_listWorker.xml");
            foreach (var e in list)
            {
                Console.WriteLine(e.Print());
            }
            Console.WriteLine();


            list = DeserializeWorkerList("_listWorker.xml");
            foreach (var e in list)
            {
                Console.WriteLine(e.Print());
            }
            Console.ReadKey();

            #endregion
        }
    }
}