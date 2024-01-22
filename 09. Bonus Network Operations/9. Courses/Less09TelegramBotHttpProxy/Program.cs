using MihaZupan;
using System.Net;
using Telegram.Bot;

namespace Less09TelegramBotHttpProxy
{
    internal class Program
    {
        private static TelegramBotClient botClient;
        static async Task Main(string[] args)
        {
            //var botClient = new TelegramBotClient(token);
            //var proxy = new HttpToSocks5Proxy("155.94.128.90", 1080); // { Timeout = TimeSpan.FromSeconds(10) };
            // https://spys.one/proxys/US/

            string token = System.IO.File.ReadAllText(@"C:\Users\leosa\Downloads\token");
            botClient = new TelegramBotClient(token);

            var webProxy = new WebProxy(Host: "https://example.org/", Port: 8080)
            {
                Credentials = new NetworkCredential("USERNAME", "PASSWORD")
            };
            var httpClient = new HttpClient(
                new HttpClientHandler { Proxy = webProxy, UseProxy = true }
            );


            var proxy = new HttpToSocks5Proxy("127.0.0.1", 1080);
            var Socks5ServerPort = 0000;
            proxy = new HttpToSocks5Proxy(
                "Socks5ServerAddress", Socks5ServerPort, "USERNAME", "PASSWORD"
            );

            // Allows you to use proxies that are only allowing connections to Telegram. Needed for some proxies
            proxy.ResolveHostnamesLocally = true;
            httpClient = new HttpClient(
                new HttpClientHandler { Proxy = proxy, UseProxy = true }
            );
            botClient = new TelegramBotClient(token, httpClient);
        }
    }
}