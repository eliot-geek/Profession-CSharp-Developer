using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBotUserInterface
{
    /// <summary>
    /// Represents a user in the Telegram bot application.
    /// </summary>
    [Serializable]
    public class TelegramUser : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets the user's nick.
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// Gets or sets the user's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the chat ID associated with the user.
        /// </summary>
        public long ChatId { get; set; }

        /// <summary>
        /// Gets the collection of all messages associated with the user.
        /// </summary>
        public ObservableCollection<TelegramMessage> Messages { get; }

        /// <summary>
        /// Gets the last message sent by the user.
        /// </summary>
        public string LastMessage => Messages.LastOrDefault()?.Text;

        /// <summary>
        /// Gets the number of messages in the chat.
        /// </summary>
        public int MessageCount => Messages.Count;

        /// <summary>
        /// Initializes a new instance of the <see cref="TelegramUser"/> class.
        /// </summary>
        /// <param name="nick">The user's nick.</param>
        /// <param name="name">The user's name.</param>
        /// <param name="chatId">The chat ID associated with the user.</param>
        public TelegramUser(string nick, string name, long chatId)
        {
            Nick = nick;
            Name = name;
            ChatId = chatId;
            Messages = new ObservableCollection<TelegramMessage>();
        }

        /// <summary>
        /// Compares two users based on their ChatId.
        /// </summary>
        /// <param name="other">The other user to compare.</param>
        /// <returns>Returns true if the ChatId values are equal; otherwise, false.</returns>
        public bool Equals(TelegramUser other) => other.ChatId == this.ChatId;

        /// <summary>
        /// Compares the object with a TelegramUser and returns true if they are equal.
        /// </summary>
        /// <param name="obj">The object to compare.</param>
        /// <returns>Returns true if the object is a TelegramUser and has the same ChatId; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (obj is TelegramUser user)
            {
                return Equals(user);
            }
            return false;
        }

        /// <summary>
        /// Returns a hash code based on the ChatId value.
        /// </summary>
        /// <returns>An integer hash code.</returns>
        public override int GetHashCode()
        {
            return (int)ChatId;
        }

        /// <summary>
        /// Adds a message to the user's message collection.
        /// </summary>
        /// <param name="msg">The message to add.</param>
        public void AddMessage(TelegramMessage msg)
        {
            Messages.Add(msg);
            OnPropertyChanged(nameof(MessageCount));
            OnPropertyChanged(nameof(LastMessage));
        }

        /// <summary>
        /// Public event handler for the PropertyChanged event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method that is called when the property changes.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}