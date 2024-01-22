using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace Less04TelegramBotAPIMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread task = new Thread(BackgroundBot);
            task.Start();

            for (int i = 0; i < 500; i++)
            {
                Console.Write("+ ");
                Thread.Sleep(50);
            }
        }

        static void BackgroundBot()
        {
            string token = File.ReadAllText(@"C:\Users\leosa\Downloads\token");
            WebClient webClient = new WebClient() { Encoding = Encoding.UTF8 };

            int update_id = 0;
            string startUrl = $@"https://api.telegram.org/bot{token}/";

            while (true)
            {
                string url = $"{startUrl}getUpdates?offset={update_id}";
                var r = webClient.DownloadString(url);

                var messages = JObject.Parse(r)["result"].ToArray();

                foreach (dynamic message in messages)
                {
                    update_id = Convert.ToInt32(message.update_id) + 1;

                    string userMessage = message.message.text;
                    string userId = message.message.from.id;
                    string userFirstName = message.message.from.first_name;

                    string text = $"{userFirstName} {userId} {userMessage}";
                    Console.WriteLine(text);

                    if (userMessage == "hello")
                    {
                        string responseText = $"Good Morning, {userFirstName}";
                        url = $"{startUrl}sendMessage?chat_id={userId}&text={responseText}";
                        //Console.WriteLine("+");
                        Console.WriteLine(webClient.DownloadString(url));
                    }
                }
                Thread.Sleep(100);
            }
        }
    }
}