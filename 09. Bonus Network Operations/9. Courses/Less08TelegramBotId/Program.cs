using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Polling;

namespace Less08TelegramBotId
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string token = System.IO.File.ReadAllText(@"C:\Users\leosa\Downloads\token");
            var botClient = new TelegramBotClient(token);
            using var cts = new CancellationTokenSource();

            // StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { } // receive all update types
            };
            botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken: cts.Token);

            var me = await botClient.GetMeAsync();
            Console.WriteLine($"Start listening for @{me.Username}");
            Console.ReadLine();

            // Send cancellation request to stop bot
            cts.Cancel();

            async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
            {
                var chatId = update.Message.Chat.Id;

                string text = $"{DateTime.Now.ToLongTimeString()}: {update.Message.Chat.FirstName} {update.Message.Chat.Id} {update.Message.Text}";
                Console.WriteLine($"{text} TypeMessage: {update.Message.Type.ToString()}");

                if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Document)
                {
                    Console.WriteLine($"FileId : {update.Message.Document.FileId}");
                    Console.WriteLine($"FileName : {update.Message.Document.FileName}");
                    Console.WriteLine($"FileSize : {update.Message.Document.FileSize}");

                    Download(update.Message.Document.FileId, update.Message.Document.FileName);
                }
                if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                {
                    Console.WriteLine($"TextLength : {update.Message.Text.Length}");
                }
                if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Audio)
                {
                    Console.WriteLine($"AudioId : {update.Message.Audio.FileId}");
                    Console.WriteLine($"AudioName : {update.Message.Audio.FileName}");
                    Console.WriteLine($"AudioSize : {update.Message.Audio.FileSize}");

                    Download(update.Message.Audio.FileId, update.Message.Audio.FileName);
                }
                if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Video)
                {
                    Console.WriteLine($"VideoId : {update.Message.Video.FileId}");
                    Console.WriteLine($"VideoName : {update.Message.Video.FileName}");
                    Console.WriteLine($"VideoSize : {update.Message.Video.FileSize}");

                    Download(update.Message.Video.FileId, update.Message.Video.FileName);
                }
                if (update.Message.Text == null)
                {
                    return;
                }

                //// Updload file by file_id
                //InputOnlineFile inputOnlineFile = new InputOnlineFile("BQACAgIAAxkBAAPlYf4QvFCM9oO6N_4m1u0gjPVk8sQAAtEYAAJxRvBLXRIAAcDEhCWJIwQ");
                //await botClient.SendDocumentAsync(chatId, inputOnlineFile);
            }

            Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
            {
                var ErrorMessage = exception switch
                {
                    ApiRequestException apiRequestException
                       => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                    _ => exception.ToString()
                };

                Console.WriteLine(ErrorMessage);
                return Task.CompletedTask;
            }

            async void Download(string fileId, string path)
            {
                var file = await botClient.GetFileAsync(fileId);
                FileStream fs = new FileStream("_" + path, FileMode.Create);
                await botClient.DownloadFileAsync(file.FilePath, fs);
                fs.Close();
                fs.Dispose();
            }
        }
    }
}