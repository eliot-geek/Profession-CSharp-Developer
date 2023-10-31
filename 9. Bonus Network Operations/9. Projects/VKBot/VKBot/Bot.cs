using System;
using System.Collections.Generic;
using System.Threading;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Enums.StringEnums;
using VkNet.Model;

namespace VKBot
{
    class Bot
    {
        // https://vknet.github.io/vk/

        private VkApi vkClient;

        // The object with which you can connect to the quick message server in order to receive them and process other events
        // http://vk.com/dev/messages.getLongPollServer

        private LongPollServerResponse longPollServerResponse;
        private VkConfig config;
        string currentTs; // index last receive msg
        public event Action<GroupUpdate> OnMessage; // when receive new sms

        public Bot(VkConfig config, bool showLog = false)
        {
            this.config = config;
            vkClient = new VkApi();
            vkClient.Authorize(new ApiAuthParams
            {
                AccessToken = config.AccessToken,
                Settings = Settings.All | Settings.Messages // what this session has to do but there are others
            });

            longPollServerResponse = vkClient.Groups.GetLongPollServer(config.GroupId);
            currentTs = longPollServerResponse.Ts;
            if (showLog) ViewLog();

        }
        private void ViewLog()
        {
            Console.WriteLine($"longPollServerResponse.Key = {longPollServerResponse.Key}");
            Console.WriteLine($"longPollServerResponse.Pts = {longPollServerResponse.Pts}");

            Console.WriteLine($"longPollServerResponse.Ts = {longPollServerResponse.Ts}");
            Console.WriteLine($"longPollServerResponse.Server = {longPollServerResponse.Server}");
        }
        public void Start(Action<GroupUpdate> onMessage = null)
        {
            if (onMessage != null) OnMessage += OnMessage;
            else OnMessage += DefaultOnMessage;
            //else OnMessage += DefaultOnMessageKeyboard;

            new Thread(OnUpdate).Start();
        }
        public User GetUserInfo(long id)
        {
            #region users.get
            ////https://vk.com/dev/users.get
            //var users = vkClient.Users.Get(new long[] { 560682090 });
            //users = vkClient.Users.Get(
            //    userIds: new long[] { 560682090 },
            //    fields: ProfileFields.FirstName,
            //    nameCase: NameCase.Acc

            //    );
            //foreach (var user in users)
            //{
            //    Console.WriteLine(user.FirstName);
            //    Console.WriteLine(user.LastName);
            //}
            #endregion

            return vkClient.Users.Get(new long[] { id })[0];
        }
        private void DefaultOnMessage(GroupUpdate e)
        {
            Console.WriteLine();
            Console.WriteLine(
                String.Format(
                    "Type: {0}\n Text: {1}\n " +
                    "Body: {2}\n FromId: {3}\n " +
                    "UserId: {4}\n FirstName: {5}\n ",
                    e.Type,
                    e?.Message?.Text,
                    e?.Message?.Body,
                    e?.Message?.FromId,
                    e?.Message?.UserId,
                    this.GetUserInfo(e.Message.FromId.Value).FirstName
                ));

            var ans = e?.Message?.Text switch
            {
                "!hi" => "Hola!",
                "!time" => DateTime.Now.ToString(),
                _ => $"Received!"
            };

            this.SendMessage(
                userId: e.Message.FromId,
                text: ans,
                replyToMessageId: e?.Message?.Id
                );
        }

        public void SendMessage(long? userId, string text,
                                long? replyToMessageId = -1,
                                MessageKeyboard keyboard = null)
        {
            var msg = new MessagesSendParams()
            {
                RandomId = Guid.NewGuid().GetHashCode(),
                UserId = userId,
                Message = text
            };
            if (replyToMessageId != -1) msg.ReplyTo = replyToMessageId;
            if (keyboard != null) msg.Keyboard = keyboard;

            vkClient.Messages.Send(msg);
        }

        private void DefaultOnMessageKeyboard(GroupUpdate e)
        {
            bool showKeyboard = e?.Message?.Text switch
            {
                "buttons" => true,
                _ => false
            };


            this.SendMessage(
                userId: e.Message.FromId,
                text: "Keyboard",
                replyToMessageId: e?.Message?.Id,
                keyboard: showKeyboard switch
                {
                    true => new MessageKeyboard()
                    {

                        Inline = true,
                        OneTime = true,
                        Buttons = new List<List<MessageKeyboardButton>>()
                                {
                                    new List<MessageKeyboardButton>(){
                                        new MessageKeyboardButton() {
                                            Action = new MessageKeyboardButtonAction()
                                            {
                                                Type =  KeyboardButtonActionType.Text,
                                                Label="Button 1.1"
                                            }
                                        },
                                        new MessageKeyboardButton() {
                                            Action = new MessageKeyboardButtonAction()
                                            {
                                                Type =  KeyboardButtonActionType.Text,
                                                 Label="Button 1.2"
                                            }
                                        }

                                    },
                                    new List<MessageKeyboardButton>(){
                                        new MessageKeyboardButton() {
                                            Action = new MessageKeyboardButtonAction()
                                            {
                                                Type =  KeyboardButtonActionType.Text,
                                                Label="Button 2.1"
                                            }
                                        },
                                        new MessageKeyboardButton() {
                                            Action = new MessageKeyboardButtonAction()
                                            {
                                                Type =  KeyboardButtonActionType.Text,
                                                 Label="Button 2.2"
                                            }
                                        },
                                        new MessageKeyboardButton() {
                                            Action = new MessageKeyboardButtonAction()
                                            {
                                                Type =  KeyboardButtonActionType.Text,
                                                 Label="Кнопка 2.3"
                                            }
                                        }

                                    },
                                    new List<MessageKeyboardButton>(){
                                        new MessageKeyboardButton() {
                                            Action = new MessageKeyboardButtonAction()
                                            {
                                                Type =  KeyboardButtonActionType.IntentSubscribe,
                                                Label="Button 3.1",
                                                PeerId =  560682090,
                                                Intent = Intent.NonPromoNewsLetter
                                            }
                                        }
                                    },
                                    new List<MessageKeyboardButton>(){
                                        new MessageKeyboardButton() {
                                            Action = new MessageKeyboardButtonAction()
                                            {
                                                Type =  KeyboardButtonActionType.OpenLink,
                                                Label="link",
                                                Link = new Uri("https://ru.wikipedia.org/wiki/C_Sharp")
                                                //Link = new Uri("http://ksergey.ru/profcsharp/")
                                            }
                                        }
                                    },
                                    new List<MessageKeyboardButton>(){
                                        new MessageKeyboardButton() {
                                            Action = new MessageKeyboardButtonAction()
                                            {
                                                Type =  KeyboardButtonActionType.Location,
                                            }
                                        }
                                    },
                                    new List<MessageKeyboardButton>(){
                                        new MessageKeyboardButton() {
                                            Action = new MessageKeyboardButtonAction()
                                            {
                                                Type =  KeyboardButtonActionType.Callback,
                                                Label="Hide buttons"
                                            }
                                        }
                                    }
                                },
                    },
                    _ => new MessageKeyboard() { Buttons = new List<List<MessageKeyboardButton>>() }
                }
                );
        }

        public void OnUpdate()
        {
            while (true)
            {
                var res = vkClient.Groups.GetBotsLongPollHistory(
                    new BotsLongPollHistoryParams()
                    {
                        Key = longPollServerResponse.Key,
                        Ts = currentTs,
                        Server = longPollServerResponse.Server
                    });
                if (OnMessage != null)
                {
                    foreach (GroupUpdate item in res.Updates)
                    {
                        currentTs = res.Ts;
                        if (item?.Message?.RandomId != 0
                        //|| item.Type == GroupUpdateType.MessageReply
                        ) { continue; }

                        OnMessage?.Invoke(item);
                        Thread.Sleep(100);
                    }
                }
                Thread.Sleep(2000);
            }
        }
    }
}
