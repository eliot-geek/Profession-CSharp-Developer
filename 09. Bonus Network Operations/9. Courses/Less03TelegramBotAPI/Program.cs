using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace Less03TelegramBotAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // http://t.me/BotFather
            // @BotFather
            // https://core.telegram.org/bots/api
            // https://telegram.org/
            // https://core.telegram.org/api
            // https://core.telegram.org/bots
            // https://core.telegram.org/bots/samples Bot API Library Examples - How do I create a bot?
            // https://core.telegram.org/bots/api How do bots work?
            // https://api.telegram.org/token/getMe
            // getUpdates - receive all messages To Bot
            // sendMessage?text=YYYYY&chat_id=111111

            // BotName in Telegram - Jroyce

            string token = File.ReadAllText(@"C:\Users\leosa\Downloads\PushHub\Github\Profession-CSharp-Developer\9. Bonus Network Operations\9. Courses\NetworkOperations\Less03TelegramBotAPI\token");
            WebClient webClient = new WebClient() { Encoding = Encoding.UTF8 };

            int update_id = 0;
            string startUrl = $@"https://api.telegram.org/bot{token}/";

            while (true)
            {
                string url = $"{startUrl}getUpdates?offset={update_id}";
                var r = webClient.DownloadString(url);
                //Console.WriteLine(r);
                //Console.ReadLine();

                /* {"ok":true,"result":[{"update_id":337056241,message":{"message_id":2,"from":{"id":877280567,"is_bot":false,"first_name":"Am\u0430du","last_name":"\ud83d\udc68\u200d\ud83d\udcbb",
                "username":"leo109","language_code":"ru"},"chat":{"id":877280567,"first_name":"Am\u0430du","last_name":"\ud83d\udc68\u200d\ud83d\udcbb","username":"leo109","type":"private"},
                "date":1698214042,"text":"/start","entities":[{"offset":0,"length":6,"type":"bot_command"}]}}]} */

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