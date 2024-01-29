using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Less11TelegramBotMessage
{
    internal class TelegramRepository
    {
        private MainWindow w;
        private TelegramBotClient bot;
        public ObservableCollection<MessageLog> BotMessageLog { get; set; }

        static string ReadToken(string path)
        {
            using (StreamReader reader = new StreamReader(path, System.Text.Encoding.Default))
            {
                return (reader.ReadLine());
            }
        }


        public TelegramRepository(MainWindow W, string Path = @"C:\Users\leosa\Downloads\token")
        {
            this.BotMessageLog = new ObservableCollection<MessageLog>();
            this.w = W;

            string token = ReadToken("token");
            bot = new TelegramBotClient(System.IO.File.ReadAllText(@"C:\Users\leosa\Downloads\token"));
        }

        public void SendMessage(string Text, string Id)
        {
            if (long.TryParse(Id, out long id))
            {
                bot.SendTextMessageAsync(id, Text);
            }
            else
            {
                Console.WriteLine($"Invalid Id format: {Id}. Unable to send message.");
            }

            //long id = Convert.ToInt64(Id);
            //bot.SendTextMessageAsync(id, Text);
        }

    }
}
