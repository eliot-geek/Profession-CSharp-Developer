using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;

namespace TwitchBot
{
    class Bot
    {

        TwitchConfig config;
        TwitchClient client;
        public Bot(TwitchConfig config, bool viewLog = true)
        {
            this.config = config;
            client = new TwitchClient();
            client.Initialize(
                credentials: new ConnectionCredentials(
                    twitchUsername: config.TwitchNikname,

                    twitchOAuth: config.AccessToken),
                channel: config.TwitchNikname, // channel for receiving chat's message
                autoReListenOnExceptions: !true);
            if (viewLog) client.OnLog += (s, arg) => Console.WriteLine(arg.Data);
        }


        public void Start(EventHandler<OnMessageReceivedArgs> e = null)
        {
            if (e != null) client.OnMessageReceived += e;
            else client.OnMessageReceived += new EventHandler<OnMessageReceivedArgs>(DefaultMessageReceived);

            client.Connect();
        }

        private void DefaultMessageReceived(object s, OnMessageReceivedArgs arg)
        {
            string channel = arg.ChatMessage.Channel;
            string msg = arg.ChatMessage.Message;
            string displayName = arg.ChatMessage.DisplayName;

            Console.WriteLine($"channel: {channel}  displayName: {displayName}  msg: {msg}\n");

            var ans = msg switch
            {
                "!hi" => "Hello",
                "!time" => DateTime.Now.ToString(),
                _ => $"Received {msg}"
            };
            client.SendMessage(config.TwitchNikname, $" @{displayName} {ans}");


        }
    }
}
