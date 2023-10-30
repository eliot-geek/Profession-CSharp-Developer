using MihaZupan;
using Telegram.Bot;

namespace Less11UsageHttpClientTelegramLibrary
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Usage with an HttpClient
            var proxy = new HttpToSocks5Proxy("127.0.0.1", 1080);
            var handler = new HttpClientHandler { Proxy = proxy };
            HttpClient httpClient = new HttpClient(handler, true);
            var result = await httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Get, "https://httpbin.org/ip"));
            Console.WriteLine("HTTPS GET : " + await result.Content.ReadAsStringAsync());



            // Usage with Telegram.Bot library
            proxy = new HttpToSocks5Proxy("my-socks-server.com", 1080);
            new HttpToSocks5Proxy("my-socks-server.com", 1080, "username", "password");
            proxy.ResolveHostnamesLocally = true;
            //TelegramBotClient Bot = new TelegramBotClient("API Token", proxy);

            proxy = new HttpToSocks5Proxy(new[] {
                new ProxyInfo("tor-proxy.com", 1080),
                new ProxyInfo("random-socks.com", 1090),
                new ProxyInfo("tor-proxy.com", 1080)
            });
        }
    }
}