using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotUserInterface
{
    public class MyTelegramBot
    {
        private MainWindow window;
        public ObservableCollection<TelegramUser> UserList { get; set; }

        private TelegramBotClient _client;
        private string _name;
        private List<BotFile> _files;
        private enum BotCmd { ShowFiles }
        private const string RootPath = "Data";
        private const int MaxFileName = 60;

        private TelegramUser curUser;

        public string Name { get { return _name; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyTelegramBot"/> class.
        /// </summary>
        /// <param name="w">The MainWindow instance associated with the bot.</param>
        /// <param name="token">The Telegram bot token for authentication.</param>
        /// <exception cref="ArgumentNullException">Thrown when the provided token is null or empty.</exception>
        /// <exception cref="Exception">Thrown if there is an issue obtaining information about the bot.</exception>
        public MyTelegramBot(MainWindow w, string token)
        {
            UserList = new ObservableCollection<TelegramUser>();
            window = w;
            if (string.IsNullOrEmpty(token))
                throw new ArgumentNullException(nameof(token));

            // Bot initialization
            _client = new TelegramBotClient(token);
            var me = _client.GetMeAsync().Result;

            if (!(me is null) && !string.IsNullOrEmpty(me.Username))
                _name = me.Username;
            else
                throw new Exception("Не удалось получить информацию о боте!");
        }

        internal async void SendMessage(string message)
        {
            SendText(message);
        }

        /// <summary>
        /// Initiates the operation of the Telegram bot by subscribing to message and callback query events
        /// and starting the receiving process.
        /// </summary>
        /// <returns>
        /// Returns a boolean value indicating whether the bot started successfully.
        /// </returns>
        /// <exception cref="Exception">
        /// Thrown if there is an issue during the initiation process, and the bot fails to start.
        /// </exception>
        public bool Start()
        {
            try
            {
                // Subscribe to message and callback query events
                _client.OnMessage += MessageListener;
                _client.OnCallbackQuery += CallbackQuery;

                // Start receiving incoming updates
                _client.StartReceiving();

                // Return true indicating successful start
                return true;
            }
            catch (Exception e)
            {
                // Log the exception and rethrow
                Debug.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Handles incoming text messages and processes different message types accordingly.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The <see cref="MessageEventArgs"/> instance containing the event data.</param>
        private async void MessageListener(object sender, MessageEventArgs e)
        {
            // Return if the message is null
            if (e.Message is null) return;

            // Extract user information
            var userName = $"{e.Message.From.FirstName} {e.Message.From.LastName}";
            curUser = CheckUser(e.Message.From.Username, userName, e.Message.Chat.Id);

            // Process different message types
            switch (e.Message.Type)
            {
                case MessageType.Text:
                    MessageLog(e.Message.Text);
                    TextHandler(e.Message);
                    break;
                case MessageType.Document:
                    MessageLog($"{userName} send doc: {e.Message.Document.FileName} {e.Message.Document.FileSize}");
                    DocumentHandler(e.Message.Document.FileId, e.Message.Document.FileName);
                    break;
                case MessageType.Audio:
                    MessageLog($"{userName} send audio: {e.Message.Audio.FileName} {e.Message.Audio.FileSize}");
                    DocumentHandler(e.Message.Audio.FileId, e.Message.Audio.FileName);
                    break;
                case MessageType.Photo:
                    MessageLog($"{userName} send photo: {e.Message.Photo[e.Message.Photo.Length - 1].FileId} {e.Message.Photo[e.Message.Photo.Length - 1].FileSize}");
                    DocumentHandler(e.Message.Photo[e.Message.Photo.Length - 1].FileId, e.Message.Photo[e.Message.Photo.Length - 1].FileId);
                    break;
                case MessageType.Video:
                    MessageLog($"{userName} send video: {e.Message.Video.FileName} {e.Message.Video.FileSize}");
                    DocumentHandler(e.Message.Video.FileId, (string.IsNullOrEmpty(e.Message.Video.FileName) ? e.Message.Video.FileId : e.Message.Video.FileName));
                    break;
                case MessageType.Voice:
                    MessageLog($"{userName} send voice: {e.Message.Video.FileName} {e.Message.Video.FileSize}");
                    DocumentHandler(e.Message.Voice.FileId, e.Message.Voice.FileId);
                    break;
                default:
                    MessageLog($"{userName} send {e.Message.Type}");
                    await _client.SendTextMessageAsync(e.Message.Chat.Id, "Enter /start");
                    MessageLog("Enter /start");
                    break;
            }
        }

        /// <summary>
        /// Logs a message with timestamp, sender information, and content, and updates the user interface.
        /// </summary>
        /// <param name="message">The content of the message to be logged.</param>
        /// <param name="IsBotAnswer">A boolean indicating whether the message is a response from the bot.</param>
        private async void MessageLog(string message, bool IsBotAnswer = false)
        {
            Debug.WriteLine($"{DateTime.Now} \t {(IsBotAnswer ? _name : curUser.Name)} : {message}");

            // Update the user interface on the main thread
            window.Dispatcher.Invoke(() =>
            {
                curUser.AddMessage(new TelegramMessage(message, (IsBotAnswer ? _name : curUser.Name), curUser.ChatId, IsBotAnswer));
                window.UpdateLayout();
            });
        }

        /// <summary>
        /// Sends a text message to the current user and logs the message.
        /// </summary>
        /// <param name="message">The content of the message to be sent.</param>
        private async void SendText(string message)
        {
            Thread.Sleep(1000);
            MessageLog(message, true);
            await _client.SendTextMessageAsync(curUser.ChatId, message);
        }


        /// <summary>
        /// Handles button clicks in response to callback queries.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The <see cref="CallbackQueryEventArgs"/> instance containing the event data.</param>
        private async void CallbackQuery(object sender, CallbackQueryEventArgs e)
        {
            Debug.WriteLine($"{DateTime.Now} \t\t {e.CallbackQuery.From.FirstName} {e.CallbackQuery.From.LastName} \t\t touch button:{e.CallbackQuery.Data}");
            MenuHandler(e.CallbackQuery);
        }

        /// <summary>
        /// Processes incoming text messages and executes corresponding actions based on the message content.
        /// </summary>
        /// <param name="msg">The <see cref="Message"/> instance representing the incoming text message.</param>
        public async void TextHandler(Message msg)
        {
            switch (msg.Text.ToLower())
            {
                case "/start":
                    var answer =
                        @"
/start - Launch the bot
/menu - menu output
/keyboard - keyboard output";
                    SendText(answer);
                    break;
                case "/menu":
                    var inlineKeyboard = new InlineKeyboardMarkup(new[]
                    {
                        new[]{ InlineKeyboardButton.WithCallbackData("List of downloaded files", BotCmd.ShowFiles.ToString()) },
                    });
                    await _client.SendTextMessageAsync(msg.From.Id, "Press it to see the files",
                        replyMarkup: inlineKeyboard);
                    break;
                case "/keyboard":
                    var replyKeyboard = new ReplyKeyboardMarkup(new[]
                    {
                        new[]
                        {
                            new KeyboardButton("Contact") {RequestContact = true},
                            new KeyboardButton("Geo"){RequestLocation = true}
                        }
                    });
                    await _client.SendTextMessageAsync(msg.Chat.Id, "The keyboard is enabled", replyMarkup: replyKeyboard);
                    break;
                default:
                    SendText("Enter /start");
                    break;
            }
        }

        /// <summary>
        /// Handles incoming documents by downloading and saving them to the specified directory.
        /// </summary>
        /// <param name="fileId">The unique identifier of the document file.</param>
        /// <param name="fileName">The name of the document file.</param>
        /// <exception cref="NotImplementedException">Thrown as this method is not fully implemented.</exception>
        public void DocumentHandler(string fileId, string fileName)
        {
            if (!Directory.Exists(RootPath)) { Directory.CreateDirectory(RootPath); }
            DownloadFile(fileId, Path.Combine(RootPath, fileName));
        }

        /// <summary>
        /// Handles button clicks in response to callback queries, executing corresponding menu actions.
        /// </summary>
        /// <param name="query">The <see cref="CallbackQuery"/> instance containing the event data.</param>
        public async void MenuHandler(CallbackQuery query)
        {
            if (query.Data == "ShowFiles")
            {
                List<List<InlineKeyboardButton>> keyboard = new List<List<InlineKeyboardButton>>();
                _files = GetFileList();
                foreach (var file in _files)
                {
                    keyboard.Add(
                        new List<InlineKeyboardButton>
                        {
                            InlineKeyboardButton.WithCallbackData(
                                $"{(file.Name.Length > MaxFileName ? file.Name.Substring(0, MaxFileName) : file.Name)}",
                                file.Id.ToString())
                        });
                }

                var keyboardMarkup = new InlineKeyboardMarkup(keyboard);

                await _client.SendTextMessageAsync(query.From.Id, "List of files: (press the file to download it)",
                    replyMarkup: keyboardMarkup);
            }

            foreach (var file in _files)
            {
                if (query.Data == file.Id.ToString())
                {
                    using (FileStream fs = new FileStream(file.Path, FileMode.Open))
                    {
                        await _client.SendDocumentAsync(query.From.Id, new InputOnlineFile(fs, file.Name));
                    }
                }
            }
        }

        /// <summary>
        /// Downloads a file from Telegram using its unique identifier and saves it to the specified path.
        /// </summary>
        /// <param name="fileId">The unique identifier of the file to be downloaded.</param>
        /// <param name="path">The path where the downloaded file will be saved.</param>
        private async void DownloadFile(string fileId, string path)
        {
            try
            {
                var file = await _client.GetFileAsync(fileId);
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    await _client.DownloadFileAsync(file.FilePath, fs);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error downloading: " + ex.Message);
            }
        }

        /// <summary>
        /// Retrieves a list of <see cref="BotFile"/> objects representing files in the root path.
        /// </summary>
        /// <returns>A list of <see cref="BotFile"/> objects.</returns>
        private List<BotFile> GetFileList()
        {
            Random rnd = new Random();
            var ls = new List<BotFile>();
            foreach (var file in GetRecursFiles(RootPath))
            {
                ls.Add(new BotFile(rnd.Next(), file));
            }
            return ls;
        }

        /// <summary>
        /// Recursively retrieves a list of file paths from the specified start path, including subdirectories.
        /// </summary>
        /// <param name="startPath">The starting path to begin the recursive search.</param>
        /// <returns>A list of file paths.</returns>
        private List<string> GetRecursFiles(string startPath)
        {
            var ls = new List<string>();
            try
            {
                var folders = Directory.GetDirectories(startPath);
                foreach (var folder in folders)
                {
                    ls.AddRange(GetRecursFiles(folder));
                }
                var files = Directory.GetFiles(startPath);
                foreach (var file in files)
                {
                    ls.Add(file);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            return ls;
        }

        /// <summary>
        /// Checks and creates the specified directory path if it does not exist.
        /// </summary>
        /// <param name="path">The directory path to check and create if needed.</param>
        /// <returns>The validated and created directory path.</returns>
        private string CheckDirectory(string path)
        {
            if (!Directory.Exists(RootPath)) { Directory.CreateDirectory(RootPath); }
            if (!Directory.Exists($"{RootPath}/{path}")) { Directory.CreateDirectory($"{RootPath}/{path}"); }

            return $"{RootPath}/{path}";
        }


        /// <summary>
        /// Checks if a user with the specified Nick, Name, and Id exists in the UserList collection.
        /// If not, adds the user to the collection and returns the existing or newly added user.
        /// </summary>
        /// <param name="Nick">The username (Nick) of the user.</param>
        /// <param name="Name">The full name of the user.</param>
        /// <param name="Id">The unique identifier of the user.</param>
        /// <returns>The existing or newly added <see cref="TelegramUser"/>.</returns>
        private TelegramUser CheckUser(string Nick, string Name, long Id)
        {
            var user = new TelegramUser(Nick, Name, Id);
            if (!UserList.Contains(user))
            {
                window.Dispatcher.Invoke(() =>
                {
                    UserList.Add(user);
                });
            }
            return UserList[UserList.IndexOf(user)];
        }

    }
}