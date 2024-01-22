using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Less07TelegramBotPlus
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
                // https://core.telegram.org/bots/api#message
                if (update.Type != UpdateType.Message)
                    return;
                if (update.Message!.Type != MessageType.Text)
                    return;

                // BQACAgIAAxkBAAPlYf4QvFCM9oO6N_4m1u0gjPVk8sQAAtEYAAJxRvBLXRIAAcDEhCWJIwQ
                // Jooble.docx
                // 14829

                var chatId = update.Message.Chat.Id;
                var messageText = update.Message.Text;
                Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");

                //// Custom keyboards
                //// Single-row keyboard markup
                //ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
                //{
                //    new KeyboardButton[] { "Help me", "Call me ☎️" },
                //})
                //{
                //    ResizeKeyboard = true
                //};
                //Message sentMessage = await botClient.SendTextMessageAsync(
                //    chatId: chatId,
                //    text: "Choose a response",
                //    replyMarkup: replyKeyboardMarkup,
                //    cancellationToken: cancellationToken);

                //// Multi-row keyboard markup
                //ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
                //    {
                //        new KeyboardButton[] { "One", "Two" },
                //        new KeyboardButton[] { "Three", "Four" },
                //    })
                //{
                //    ResizeKeyboard = true
                //};
                //Message sentMessage = await botClient.SendTextMessageAsync(
                //    chatId: chatId,
                //    text: "Choose a response",
                //    replyMarkup: replyKeyboardMarkup,
                //    cancellationToken: cancellationToken);

                //// Request information
                //ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
                //    {
                //        KeyboardButton.WithRequestLocation("Share Location"),
                //        KeyboardButton.WithRequestContact("Share Contact"),
                //    });
                //Message sentMessage = await botClient.SendTextMessageAsync(
                //    chatId: chatId,
                //    text: "Who or Where are you?",
                //    replyMarkup: replyKeyboardMarkup,
                //    cancellationToken: cancellationToken);

                //// Remove keyboard
                //Message sentMessage = await botClient.SendTextMessageAsync(
                //    chatId: chatId,
                //    text: "Removing keyboard",
                //    replyMarkup: new ReplyKeyboardRemove(),
                //    cancellationToken: cancellationToken);

                //// Callback buttons
                //InlineKeyboardMarkup inlineKeyboard = new(new[]
                //    {
                //        // first row
                //        new []
                //        {
                //            InlineKeyboardButton.WithCallbackData(text: "1.1", callbackData: "11"),
                //            InlineKeyboardButton.WithCallbackData(text: "1.2", callbackData: "12"),
                //        },
                //        // second row
                //        new []
                //        {
                //            InlineKeyboardButton.WithCallbackData(text: "2.1", callbackData: "21"),
                //            InlineKeyboardButton.WithCallbackData(text: "2.2", callbackData: "22"),
                //        },
                //    });
                //Message sentMessage = await botClient.SendTextMessageAsync(
                //    chatId: chatId,
                //    text: "A message with an inline keyboard markup",
                //    replyMarkup: inlineKeyboard,
                //    cancellationToken: cancellationToken);

                //// URL buttons
                //InlineKeyboardMarkup inlineKeyboard = new(new[]
                //    {
                //        InlineKeyboardButton.WithUrl(
                //            text: "Link to the Repository",
                //            url: "https://github.com/TelegramBots/Telegram.Bot"
                //        )
                //    }
                //);
                //Message sentMessage = await botClient.SendTextMessageAsync(
                //    chatId: chatId,
                //    text: "A message with an inline keyboard markup",
                //    replyMarkup: inlineKeyboard,
                //    cancellationToken: cancellationToken);

                //// Switch to Inline buttons
                //InlineKeyboardMarkup inlineKeyboard = new(new[]
                //    {
                //        InlineKeyboardButton.WithSwitchInlineQuery("switch_inline_query"),
                //        InlineKeyboardButton.WithSwitchInlineQueryCurrentChat("switch_inline_query_current_chat"),
                //    }
                //);
                //Message sentMessage = await botClient.SendTextMessageAsync(
                //    chatId: chatId,
                //    text: "A message with an inline keyboard markup",
                //    replyMarkup: inlineKeyboard,
                //    cancellationToken: cancellationToken);

                //// Upload an actual file
                //using (FileStream stream = System.IO.File.OpenRead(@"C:\Users\leosa\Downloads\CSharp.pdf"))
                //{
                //    InputOnlineFile inputOnlineFile = new InputOnlineFile(stream, "CSharp.pdf");
                //    await botClient.SendDocumentAsync(chatId, inputOnlineFile);
                //}

                //// Updload file by file_id
                //InputOnlineFile inputOnlineFile = new InputOnlineFile("BQACAgIAAxkBAAPlYf4QvFCM9oO6N_4m1u0gjPVk8sQAAtEYAAJxRvBLXRIAAcDEhCWJIwQ");
                //await botClient.SendDocumentAsync(chatId, inputOnlineFile);

                //// Updload file by URL
                //InputOnlineFile inputOnlineFile = new InputOnlineFile("telegram.org/img/t_logo.png");
                //await botClient.SendDocumentAsync(chatId, inputOnlineFile);

                // Working Behind a Proxy

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
        }
    }
}