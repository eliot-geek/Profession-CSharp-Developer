using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Less03DelegateAPIService
{
    /// <summary>
    /// Contains static methods for handling data.
    /// </summary>
    static class Handlers
    {
        /// <summary>
        /// Saves the data to a text file.
        /// </summary>
        /// <param name="DataSource">The data source to be saved.</param>
        public static void SaveToTextFile(string DataSource)
        {
            File.WriteAllText("file.txt", DataSource);
            Debug.WriteLine("Data saved in file.txt");
        }

        /// <summary>
        /// Writes the data to the console.
        /// </summary>
        /// <param name="DataSource">The data source to be written.</param>
        public static void WriteToConsole(string DataSource)
        {
            Console.WriteLine(DataSource);
            Debug.WriteLine("Data saved in the console");
        }

        /// <summary>
        /// Saves the data to an XML file.
        /// </summary>
        /// <param name="DataSource">The data source to be saved.</param>
        public static void SaveToXmlFile(string DataSource)
        {
            new XElement("Data", DataSource).Save("data.xml");
            Debug.WriteLine("Data saved in file.xml");
        }
    }
}
