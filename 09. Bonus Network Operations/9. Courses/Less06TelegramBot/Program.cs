using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace Less06TelegramBot
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string token = System.IO.File.ReadAllText(@"C:\Users\leosa\Downloads\token");

            // Add reference Telegram.Bot package.
            // Add reference Telegram.Bot.Extensions.Polling package.

            #region getMe

            //var botClient = new TelegramBotClient(token);
            //var me = await botClient.GetMeAsync();
            //Console.WriteLine($"Hello, World! I am user {me.Id} and my name is {me.FirstName}");
            //// Hello, World! I am user 5126063196 and my name is Jroyce

            #endregion

            #region First Chat Bot

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

                var chatId = update.Message.Chat.Id;
                var messageText = update.Message.Text;
                Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");

                // Echo received message text
                Message sentMessage = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: "You said:\n" + messageText,
                    cancellationToken: cancellationToken);

                // Sending text message
                Message textmessage = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: "Hello, Eliiot!",
                    cancellationToken: cancellationToken);

                
                // Send Text Message and link
                Message message = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: "Trying *all the parameters* of `sendMessage` method",
                    parseMode: ParseMode.MarkdownV2,
                    disableNotification: true,
                    replyToMessageId: update.Message.MessageId,
                    replyMarkup: new InlineKeyboardMarkup(
                        InlineKeyboardButton.WithUrl(
                            "Check sendMessage method",
                            "https://core.telegram.org/bots/api#sendmessage")),
                    cancellationToken: cancellationToken);

                Console.WriteLine(
                    $"{message.From.FirstName} sent message {message.MessageId} " +
                    $"to chat {message.Chat.Id} at {message.Date}. " +
                    $"It is a reply to message {message.ReplyToMessage.MessageId} " +
                    $"and has {message.Entities.Length} message entities."
                    );

                // Contact Message
                Message messageContact = await botClient.SendContactAsync(
                    chatId: chatId,
                    phoneNumber: "+1234567890",
                    firstName: "Han",
                    lastName: "Solo",
                    cancellationToken: cancellationToken);

                Message messageCont = await botClient.SendContactAsync(
                    chatId: chatId,
                    phoneNumber: "+1234567890",
                    firstName: "Han",
                    vCard: "BEGIN:VCARD\n" +
                           "VERSION:3.0\n" +
                           "N:Solo;Han\n" +
                           "ORG:Scruffy-looking nerf herder\n" +
                           "TEL;TYPE=voice,work,pref:+1234567890\n" +
                           "EMAIL:hansolo@mfalcon.com\n" +
                           "END:VCARD",
                    cancellationToken: cancellationToken);

                // Message Venue
                Message messageVenue = await botClient.SendVenueAsync(
                    chatId: chatId,
                    latitude: 50.0840172f,
                    longitude: 14.418288f,
                    title: "Man Hanging out",
                    address: "Husova, 110 00 Staré Město, Czechia",
                    cancellationToken: cancellationToken);

                // Message Location
                Message messageLocation = await botClient.SendLocationAsync(
                    chatId: chatId,
                    latitude: 33.747252f,
                    longitude: -112.633853f,
                    cancellationToken: cancellationToken);


                //// Sending sticker message
                //Message sticker = await botClient.SendStickerAsync(
                //chatId: chatId,
                //sticker: "https://github.com/TelegramBots/book/raw/master/src/docs/sticker-dali.webp",
                //cancellationToken: cancellationToken);

                //// Sending video message
                //Message video = await botClient.SendVideoAsync(
                //    chatId: chatId,
                //    video: "https://github.com/TelegramBots/book/raw/master/src/docs/video-bulb.mp4",
                //    cancellationToken: cancellationToken);

                //// Photo
                //Message messagephoto = await botClient.SendPhotoAsync(
                //    chatId: chatId,
                //    photo: "https://github.com/TelegramBots/book/raw/master/src/docs/photo-ara.jpg",
                //    caption: "<b>Ara bird</b>. <i>Source</i>: <a href=\"https://pixabay.com\">Pixabay</a>",
                //    parseMode: ParseMode.Html,
                //    cancellationToken: cancellationToken);

                //// Sticker by http url to WebP and by file_id
                //Message message1 = await botClient.SendStickerAsync(
                //    chatId: chatId,
                //    sticker: "https://github.com/TelegramBots/book/raw/master/src/docs/sticker-fred.webp",
                //    cancellationToken: cancellationToken);

                //Message message2 = await botClient.SendStickerAsync(
                //    chatId: chatId,
                //    sticker: message1.Sticker.FileId,
                //    cancellationToken: cancellationToken);

                //// Audio Messages
                //Message messageaudio = await botClient.SendAudioAsync(
                //    chatId: chatId,
                //    audio: "https://github.com/TelegramBots/book/raw/master/src/docs/audio-guitar.mp3",
                //    /*
                //    performer: "Joel Thomas Hunger",
                //    title: "Fun Guitar and Ukulele",
                //    duration: 91, // in seconds
                //    */
                //    cancellationToken: cancellationToken);

                //// Voice Messages
                //Message messagevoice;
                //using (var stream = System.IO.File.OpenRead(@"C:\Users\leosa\Downloads\src_docs_voice-nfl_commentary.ogg"))
                //{
                //        messagevoice = await botClient.SendVoiceAsync(
                //        chatId: chatId,
                //        voice: stream,
                //        duration: 36,
                //        cancellationToken: cancellationToken);
                //}

                //// Video Message 
                //Message messagevideo = await botClient.SendVideoAsync(
                //    chatId: chatId,
                //    video: "https://raw.githubusercontent.com/TelegramBots/book/master/src/docs/video-countdown.mp4",
                //    thumb: "https://raw.githubusercontent.com/TelegramBots/book/master/src/2/docs/thumb-clock.jpg",
                //    supportsStreaming: true,
                //    cancellationToken: cancellationToken);

                //// Video note Message
                //Message messagenote;
                //using (var stream = System.IO.File.OpenRead(@"C:\Users\leosa\Downloads\video-waves.mp4"))
                //{
                //        messagenote = await botClient.SendVideoNoteAsync(
                //        chatId: chatId,
                //        videoNote: stream,
                //        duration: 47,
                //        length: 360, // value of width/height
                //        cancellationToken: cancellationToken);
                //}

                //// Albun Messages
                //Message[] messages = await botClient.SendMediaGroupAsync(
                //    chatId: chatId,
                //    media: new IAlbumInputMedia[]
                //    {
                //        new InputMediaPhoto("https://cdn.pixabay.com/photo/2017/06/20/19/22/fuchs-2424369_640.jpg"),
                //        new InputMediaPhoto("https://cdn.pixabay.com/photo/2017/04/11/21/34/giraffe-2222908_640.jpg"),
                //    },
                //    cancellationToken: cancellationToken);

                //// Send Documents
                //Message messagedocuments = await botClient.SendDocumentAsync(
                //    chatId: chatId,
                //    document: "https://github.com/TelegramBots/book/raw/master/src/docs/photo-ara.jpg",
                //    caption: "<b>Ara bird</b>. <i>Source</i>: <a href=\"https://pixabay.com\">Pixabay</a>",
                //    parseMode: ParseMode.Html,
                //    cancellationToken: cancellationToken);

                //// Send Animations
                //Message messageAnimations = await botClient.SendAnimationAsync(
                //    chatId: chatId,
                //    animation: "https://raw.githubusercontent.com/TelegramBots/book/master/src/docs/video-waves.mp4",
                //    caption: "Waves",
                //    cancellationToken: cancellationToken);

                //// Native Poll Messages // Send a poll
                //Message pollMessage = await botClient.SendPollAsync(
                //    chatId: "@group_or_channel_username",
                //    question: "Did you ever hear the tragedy of Darth Plagueis The Wise?",
                //    options: new[]
                //    {
                //        "Yes for the hundredth time!",
                //        "No, who`s that?"
                //    },
                //    cancellationToken: cancellationToken);

                //Poll poll = await botClient.StopPollAsync(
                //    chatId: pollMessage.Chat.Id,
                //    messageId: pollMessage.MessageId,
                //    cancellationToken: cancellationToken);

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
            // Received a 'Miss' message in chat 877280567

            #endregion
        }
    }
}