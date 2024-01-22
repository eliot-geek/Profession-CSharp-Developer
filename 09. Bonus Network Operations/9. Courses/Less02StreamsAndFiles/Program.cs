using System.Net;

namespace Less02StreamsAndFiles
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region HttpClient

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync("https://filesamples.com/samples/document/txt/sample3.txt");

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(content);
                        Console.WriteLine("\n\n\n\nYES!!\nHttpClient - File download");
                    }
                    else
                    {
                        Console.WriteLine("Failed to download the file.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            Console.ReadLine();

            #endregion


            #region WebClient

            var client = new WebClient();
            using (Stream stream = client.OpenRead("https://filesamples.com/samples/document/txt/sample3.txt"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(reader.ReadToEnd());
                    }
                }
            }

            Console.WriteLine("\n\n\n\nYES!!\nWebClient - File download");
            Console.ReadKey();

            #endregion

        }
    }
}