namespace TwitchBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Bot(TwitchConfig.Instance).Start();
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();

            #region MyRegion

            //TwitchConfig config = TwitchConfig.Instance;
            //TwitchClient client = new TwitchClient();

            //client.Initialize(
            //    credentials: new ConnectionCredentials(
            //        twitchUsername: config.TwitchNikname,
            //        twitchOAuth: config.AccessToken),
            //    channel: config.TwitchNikname,
            //    autoReListenOnExceptions: !true);

            //client.OnLog += (s, arg) => Console.WriteLine(arg.Data);

            //client.OnMessageReceived += (s, arg) =>
            //{
            //    string channel = arg.ChatMessage.Channel;
            //    string msg = arg.ChatMessage.Message;
            //    string displayName = arg.ChatMessage.DisplayName;

            //    Console.WriteLine($"Channel: {channel} displayName: {displayName} msg: {msg}\n");

            //    client.SendMessage(config.TwitchNikname, $" @{displayName} Received {msg}");
            //};

            //client.Connect();
            //Console.WriteLine("client.Connnect");
            //Console.ReadLine();

            #endregion

        }
    }
}