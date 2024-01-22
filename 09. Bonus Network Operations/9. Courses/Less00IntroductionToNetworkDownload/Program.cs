using System.Net;
using System.Text;

namespace Less00IntroductionToNetworkDownload
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region  Use HttpClient for sending and receiving HTTP responses from a ressource identified by a URL

            using (HttpClient httpClient = new HttpClient())
            {
                // Define the base URL and the specific file URL
                string baseUrl = "https://filesamples.com/samples/document/txt/";
                string fileUrl = baseUrl + "sample3.txt";

                try
                {
                    // Send an asynchronous GET request to the specified file URL
                    HttpResponseMessage response = await httpClient.GetAsync(fileUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                        string filePath = "HttpClientsample3.txt";
                        await File.WriteAllBytesAsync(filePath, fileBytes);
                        Console.WriteLine("HttpClient - Text File Downloaded!");
                    }
                    else
                    {
                        Console.WriteLine("Failed to download the file.");
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"HttpClient - Error: {e.Message}");
                }
            }
            Console.ReadLine();

            #endregion


            #region WebRequest, HttpWebRequest, ServicePoint, WebClient are obsolete starting in .NET 6 (Not recommended anymore)

            // https://learn.microsoft.com/en-us/dotnet/fundamentals/syslib-diagnostics/syslib0014

            WebClient webClient = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            webClient.BaseAddress = "https://filesamples.com/samples/document/txt/";
            webClient.DownloadFile(@"https://filesamples.com/samples/document/txt/sample3.txt", "WebClientsample3.txt");
            Console.WriteLine("WebClient - Text File Downloaded!");
            Console.ReadLine();

            //string url = @"audio_api.mp3";
            //webClient.BaseAddress = "http://jroyce.com/sb/";
            //webClient.DownloadFile(@"http://jroyce.com/jr/audio_api.mp3", "WebClientaudio_api.mp3");
            //webClient.DownloadFile(url, "WebClientaudio_api.mp3");
            //Console.WriteLine("WebClient - Audio File Downloaded!");
            //Console.ReadLine();

            #endregion

        }
    }
}