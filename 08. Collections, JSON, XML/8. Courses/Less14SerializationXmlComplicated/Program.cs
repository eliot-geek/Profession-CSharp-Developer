using System.Xml.Linq;

namespace Less14SerializationXmlComplicated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region XDocument.Parse

            // Read the content of the "_weather.xml" file into a string
            string xml = System.IO.File.ReadAllText("_weather.xml");

            // Parse the XML content using XDocument and navigate to the desired elements
            var forecastElements = XDocument.Parse(xml)
                               .Descendants("MMWEATHER")
                               .Descendants("REPORT")
                               .Descendants("TOWN")
                               .Descendants("FORECAST")
                               .ToList();

            // Display the entire forecast elements
            foreach (var item in forecastElements)
            {
                Console.WriteLine($"\n\n{item}");
            }
            Console.ReadLine();
            Console.Clear();

            // Display the day, month, and year attributes for each forecast element
            foreach (var item in forecastElements)
            {
                Console.WriteLine("day: {0} month: {1} year: {2}",
                                    item.Attribute("day").Value,
                                    item.Attribute("month").Value,
                                    item.Attribute("year").Value);
            }
            Console.ReadLine();
            Console.Clear();

            // Display the min and max temperature attributes for each forecast element.
            foreach (var item in forecastElements)
            {
                Console.WriteLine("min: {0} max: {1}",
                                    item.Element("TEMPERATURE").Attribute("min").Value,
                                    item.Element("TEMPERATURE").Attribute("max").Value);
            }
            Console.ReadLine();
            Console.Clear();

            // Retrieve the city name from the XML and display it
            string city = XDocument.Parse(xml)
                                   .Element("MMWEATHER")
                                   .Element("REPORT")
                                   .Element("TOWN")
                                   .Attribute("sname").Value;
            Console.WriteLine(city);
            Console.ReadLine();
            Console.Clear();

            #endregion


            #region XDocument.Create

            // Create XElement instances to build an XML structure representing weather data
            XElement myMMWEATHER = new XElement("MMWEATHER");
            XElement myTOWN = new XElement("TOWN");
            XElement myFORECAST = new XElement("FORECAST");
            XElement myTEMPERATURE = new XElement("TEMPERATURE");

            // Create attributes for min and max temperature
            XAttribute xAttributeMin = new XAttribute("min", 7);
            XAttribute xAttributeMax = new XAttribute("max", 10);

            // Add min and max temperature attributes to the TEMPERATURE element
            myTEMPERATURE.Add(xAttributeMin, xAttributeMax);

            // Add the TEMPERATURE element to the FORECAST element
            myFORECAST.Add(myTEMPERATURE);

            // Create an attribute for the city name
            XAttribute xAttributeCityName = new XAttribute("sname", "Москва");

            // Add the FORECAST element and city name attribute to the TOWN element multiple times
            myTOWN.Add(myFORECAST, xAttributeCityName);
            myTOWN.Add(myFORECAST);
            myTOWN.Add(myFORECAST);
            myTOWN.Add(myFORECAST);

            // Add the TOWN element to the MMWEATHER element
            myMMWEATHER.Add(myTOWN);

            // Save the created XML structure to a file named "_myWeather.xml"
            myMMWEATHER.Save("_myWeather.xml");

            // Display a message indicating that the XDocument has been created and saved
            Console.WriteLine("XDocument.Create Done! - Check Your Folder!");
            Console.ReadKey();

            #endregion
        }
    }
}