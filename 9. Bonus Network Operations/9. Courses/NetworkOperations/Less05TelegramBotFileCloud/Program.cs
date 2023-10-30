using System.Net;
using Telegram.Bot;

namespace Less05TelegramBotFileCloud
{
    internal class Program
    {
        static TelegramBotClient bot;

        static void Main(string[] args)
        {
            string token = File.ReadAllText(@"C:\Users\leosa\Downloads\PushHub\Github\Profession-CSharp-Developer\9. Bonus Network Operations\9. Courses\NetworkOperations\Less03TelegramBotAPI\token");

            #region Obselete - Proxy Method

            // https://hidemyna.me/ru/proxy-list/?maxtime=250#list

            var proxy = new WebProxy()
            {
                //Address = new Uri($"http://77.87.240.74:3128"),
                Address = new Uri($"http://62.33.210.34:58918"),
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(userName: "login", password: "password")
            };

            // Creates an instance of the class System.Net.Http.HttpClientHandler.
            var httpClientHandler = new HttpClientHandler() 
            { 
                Proxy = proxy 
            };

            // Provides a base class for sending HTTP requests and receiving HTTP responses from a resource with a specified URI
            HttpClient hc = new HttpClient(httpClientHandler);

            bot = new TelegramBotClient(token, hc);

            #endregion

            //bot = new TelegramBotClient(token);
            bot.OnMessage += MessageListener;
            bot.StartReceiving();
            Console.ReadKey();
        }

        private static void MessageListener(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            string text = $"{DateTime.Now.ToLongTimeString()}: {e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";
            Console.WriteLine($"{text} TypeMessage: {e.Message.Type.ToString()}");

            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Document)
            {
                Console.WriteLine(e.Message.Document.FileId);
                Console.WriteLine(e.Message.Document.FileName);
                Console.WriteLine(e.Message.Document.FileSize);

                Download(e.Message.Document.FileId, e.Message.Document.FileName);
            }

            if (e.Message.Text == null)
            {
                return;
            }

            var messageText = e.Message.Text;

            bot.SendTextMessageAsync(e.Message.Chat.Id,
                $"{messageText}"
                );
        }

        static async void Download(string fileId, string path)
        {
            var file = await bot.GetFileAsync(fileId);
            FileStream fs = new FileStream("_" + path, FileMode.Create);
            await bot.DownloadFileAsync(file.FilePath, fs);
            fs.Close();
            fs.Dispose();
        }
    }
}