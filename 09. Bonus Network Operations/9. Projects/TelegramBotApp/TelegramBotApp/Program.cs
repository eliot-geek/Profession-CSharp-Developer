using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace TelegramBotApp
{
    // http://t.me/BotFather                            // TELEGRAM BOT
    // @BotFather                                       // TELEGRAM BOT
    // https://core.telegram.org/bots/api               // TELEGRAM BOT
    // https://core.telegram.org/api                    // TELEGRAM BOT

    internal class Program
    {
        /// <summary>
        /// Read Token File
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static string ReadToken(string path)
        {
            using (StreamReader reader = new StreamReader(path, System.Text.Encoding.Default))
            {
                return (reader.ReadLine());
            }
        }

        static ITelegramBotClient telegramBot;


        static async Task Main(string[] args)
        {
            string token = ReadToken("token");
            //string token = System.IO.File.ReadAllText(@"token");
            telegramBot = new TelegramBotClient(token);
            using var cancellationTokenSource = new CancellationTokenSource();

            // StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { } // receive all update types
            };
            telegramBot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken: cancellationTokenSource.Token);

            var me = await telegramBot.GetMeAsync();
            Console.WriteLine($"Start listening for @{me.Username}");
            Console.WriteLine("Please Enter /start in the bot's telegram");
            Console.ReadLine();

            // Send cancellation request to stop bot
            cancellationTokenSource.Cancel();
        }

        static async Task HandleUpdateAsync(ITelegramBotClient telegramBot, Update update, CancellationToken cancellationToken)
        {
            string text = $"{DateTime.Now.ToLongTimeString()}: {update.Message.Chat.FirstName} {update.Message.Chat.Id} {update.Message.Text}";
            Console.WriteLine($"{text} TypeMessage: {update.Message.Type.ToString()}");

            string path = @".\Download\";

            if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Document)
            {
                Console.WriteLine($"FileId : {update.Message.Document.FileId}");
                Console.WriteLine($"FileName : {update.Message.Document.FileName}");
                Console.WriteLine($"FileSize : {update.Message.Document.FileSize}");

                Download(update.Message.Document.FileId, update.Message.Document.FileName, path);
            }

            if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                Console.WriteLine($"TextLength : {update.Message.Text.Length}");
            }

            if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Photo)
            {
                Console.WriteLine($"PhotoLength : {update.Message.Photo.Length}");
            }

            if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Audio)
            {
                Console.WriteLine($"AudioId : {update.Message.Audio.FileId}");
                Console.WriteLine($"AudioName : {update.Message.Audio.FileName}");
                Console.WriteLine($"AudioSize : {update.Message.Audio.FileSize}");

                Download(update.Message.Audio.FileId, update.Message.Audio.FileName, path);
            }

            if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Video)
            {
                Console.WriteLine($"VideoId : {update.Message.Video.FileId}");
                Console.WriteLine($"VideoName : {update.Message.Video.FileName}");
                Console.WriteLine($"VideoSize : {update.Message.Video.FileSize}");

                Download(update.Message.Video.FileId, update.Message.Video.FileName, path);
            }

            if (update.Message.Text == null)
            {
                return;
            }

            if (!String.IsNullOrEmpty(update.Message.Text))
            {
                if (update.Message.Text == "/start")
                {
                    _ = telegramBot.SendTextMessageAsync(update.Message.Chat.Id,
                        "Welcome to my Bot!\nAccepts messages and commands from the user\n" +
                        "Saves audio messages, pictures and arbitrary files\nAllows the user to view the list of downloaded files\n" +
                        "Allows you to download the selected file\nYou just have to ask by sending these commands:");

                    _ = telegramBot.SendTextMessageAsync(update.Message.Chat.Id,
                        "/list - list all files");

                    _ = telegramBot.SendTextMessageAsync(update.Message.Chat.Id,
                        "/file name - download file (write the file's fullname)");
                }

                if (update.Message.Text == "/list")
                {
                    string[] fileEntries = Directory.GetFiles(path);
                    foreach (var fileName in fileEntries)
                    {
                        _ = telegramBot.SendTextMessageAsync(update.Message.Chat.Id,
                            $"{fileName}");
                    }
                }

                if (update.Message.Text.Contains("/file"))
                {
                    var send = update.Message.Text.Substring(6);
                    Upload(send, update.Message.Chat.Id);
                }
            }
        }

        /// <summary>
        /// Download the file 
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="fileName"></param>
        /// <param name="path"></param>
        static async void Download(string fileId, string fileName, string path)
        {
            if (!Directory.Exists(path))
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(path);
            }

            var file = await telegramBot.GetFileAsync(fileId);
            FileStream filestream = new FileStream(path + fileName, FileMode.Create);
            await telegramBot.DownloadFileAsync(file.FilePath, filestream);
            filestream.Close();
            filestream.Dispose();
        }

        /// <summary>
        /// Upload
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="id"></param>
        static async void Upload(string fileName, long id)
        {
            using (FileStream filestream = System.IO.File.OpenRead(fileName))
            {
                InputOnlineFile inputOnlineFile = new InputOnlineFile(filestream, fileName);
                await telegramBot.SendDocumentAsync(id, inputOnlineFile);

                /*
                14:17:33: Amadu 877280567  TypeMessage: Audio
                AudioId : CQACAgIAAxkBAAID_2H_rkvfnsFSQawmNXc0Dkh2JrVjAAJnEwACnF34S8Em4qQE_RndIwQ
                AudioName : src_docs_voice-nfl_commentary.ogg
                AudioSize : 417335

                14:17:36: Amadu 877280567  TypeMessage: Document
                FileId : BQACAgIAAxkBAAIEAAFh_65Oe-Aei9tKDQ7URF-3IXhB6wACaBMAApxd-EuDC8lby17yvCME
                FileName : Jooble.docx
                FileSize : 14829

                14:17:36: Amadu 877280567  TypeMessage: Document
                FileId : BQACAgIAAxkBAAIEAWH_rk7CwrorT4b_UaikMw_C_kbHAAJpEwACnF34S7HzjYxKrMFGIwQ
                FileName : bit.pdf
                FileSize : 189448

                14:17:36: Amadu 877280567  TypeMessage: Document
                FileId : BQACAgIAAxkBAAIEAmH_rk41s2slyP5roQsLoBmEHDegAAJrEwACnF34S3xRV_EFc6-qIwQ
                FileName : bitaddress.pdf
                FileSize : 291110

                14:17:36: Amadu 877280567  TypeMessage: Document
                FileId : BQACAgIAAxkBAAIEA2H_rk4G75-d4kRQQO_mXjTgmdMtAAJqEwACnF34S3Qi5n2xPiRgIwQ
                FileName : main.cpp
                FileSize : 648

                14:18:30: Amadu 877280567  TypeMessage: Video
                VideoId : BAACAgIAAxkBAAIEBGH_roQuZPR5--IfNF031ugE6nCFAAJsEwACnF34S3FwWNicnAjpIwQ
                VideoName : video-waves.mp4
                VideoSize : 4825102
                */
            }
        }

        /// <summary>
        /// HandleErrorAsync method is invoked in case of an error
        /// </summary>
        /// <param name="telegramBot"></param>
        /// <param name="exception"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        static Task HandleErrorAsync(ITelegramBotClient telegramBot, Exception exception, CancellationToken cancellationToken)
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
    }
}