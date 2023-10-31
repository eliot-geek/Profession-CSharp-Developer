using Newtonsoft.Json.Linq;

namespace OpenWeatherMap
{
    // https://openweathermap.org/
    internal class Program
    {
        static HttpClient httpClient = new HttpClient();

        /// <summary>
        /// GetTemperature
        /// </summary>
        /// <param name="Title"></param>
        /// <returns></returns>
        static public string GetTemperature(string Title)
        {
            try
            {
                // 4f3761c8baa8417dad387e6e709d35e8
                string url = $"https://api.openweathermap.org/data/2.5/weather?q={Title}&units=metric&appid=4f3761c8baa8417dad387e6e709d35e8";
                string data = httpClient.GetStringAsync(url).Result;
                dynamic r = JObject.Parse(data);
                return $"{r.main.temp}c";
            }
            catch (Exception)
            {
                return "Error";
            }
        }

        static void Main(string[] args)
        {
            //// XML 
            //string xml = File.ReadAllText(@"");
            //var col = XDocument.Parse(xml)
            //                   .Descendants("WEATHER")
            //                   .Descendants("REPORT")
            //                   .Descendants("TOWN")
            //                   .ToList()
            //                   .Select(e => Convert.ToInt32(e.Element("TEMPERATURE").Attribute("value").Value))
            //                   .GroupBy(e => e)
            //                   .OrderBy(e => e.Key)
            //                   ;


            //int all = 0;
            //foreach (var item in col)
            //{
            //    Console.WriteLine($"{item.Key,4} -  {item.Count()}");
            //    all += item.Count();
            //}
            //Console.WriteLine(all);

            // JSON
            Console.WriteLine(GetTemperature("Guinea"));
        }
    }
}