using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client.Events;

namespace DiscordBot
{
    internal class Bot
    {

        DiscordClient client;

        public Bot(DiscordConfig config, LogLevel logLevel = LogLevel.Info)
        {
            this.client = new DiscordClient(new DiscordConfiguration()
            {
                Token = config.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,

                LogLevel = logLevel
            });
        }

        public void Start(AsyncEventHandler<MessageCreateEventArgs> e = null)
        {
            if (e != null) client.MessageCreated += e;
            else client.MessageCreated += new AsyncEventHandler<MessageCreateEventArgs>(DefaultMessageReceived);

            client.ConnectAsync();
        }

        private Task DefaultMessageReceived(MessageCreateEventArgs e)
        {
            if (e.Author.IsBot) return Task.CompletedTask;

            var msgType = e.Message.MessageType;
            var username = e.Author.Username;
            var msg = e.Message.Content;

            Console.WriteLine(String.Format("{0} {1} {2}",
                msgType,
                username,
                msg));

            var ans = msg switch
            {
                "!hi" => "Hello",
                "!time" => DateTime.Now.ToString(),
                _ => $"Received {msg}"
            };


            ans = String.Format(
                "**{0}** bold \n "
                + "__{0}__ underline \n "
                + "_{0}_ italic \n "
                + "*{0}* italic \n "
                + "~~{0}~~ strikethrough \n "
                + "||{0}|| spoiler \n "
                + "`{0}` inline code \n "
                + @"```
for (int i = 0; i < length; i++)
    Console.WriteLine(i);
``` multiline code block "

                + "<http://jroyce.com/>\n "
                ,
                ans
                );
            // https://discord.fandom.com/ru/wiki/ Formatting text



            var embed = new DiscordEmbedBuilder
            {
                Title = "Important message and his domain ",
                ImageUrl = "http://jroyce.com/icons/telegram.png",
                Url = "http://jroyce.com/ ",
                Description = $"{DiscordEmoji.FromName(client, ":no_entry:")} \n Text message",
                Color = new DiscordColor(0x0000FF), // rule's color
                Footer = new DiscordEmbedBuilder.EmbedFooter()
                {
                    Text = $"Footer Text"
                }
            };

            return e.Message.RespondAsync(
               content: ans,
               embed: embed
              );
        }
    }
}
