using System;
using System.Windows;
using System.Windows.Media;

namespace TelegramBotUserInterface
{
    /// <summary>
    /// Represents a message exchanged within the Telegram bot application.
    /// </summary>
    [Serializable]
    public class TelegramMessage
    {
        /// <summary>
        /// Gets or sets the timestamp of the message.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the message.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the text content of the message.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the name associated with the sender of the message.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether the message is sent by the bot.
        /// </summary>
        public bool IsBotMsg { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelegramMessage"/> class.
        /// </summary>
        /// <param name="text">The text content of the message.</param>
        /// <param name="userName">The name associated with the sender of the message.</param>
        /// <param name="id">The unique identifier of the message.</param>
        /// <param name="isBotMsg">A boolean value indicating whether the message is sent by the bot (default is false).</param>
        public TelegramMessage(string text, string userName, long id, bool isBotMsg = false)
        {
            this.Time = DateTime.Now.ToLongTimeString();
            this.Text = text;
            this.Name = userName;
            this.Id = id;
            this.IsBotMsg = isBotMsg;
        }
    }
}