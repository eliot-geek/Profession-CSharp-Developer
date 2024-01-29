using System;

namespace TelegramBotUserInterface
{
    /// <summary>
    /// Represents a file associated with the Telegram bot.
    /// </summary>
    public class BotFile
    {
        /// <summary>
        /// Gets or sets the unique identifier for the file.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets the file name extracted from the file path.
        /// </summary>
        public string Name => System.IO.Path.GetFileName(Path);

        /// <summary>
        /// Initializes a new instance of the <see cref="BotFile"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the file.</param>
        /// <param name="path">The file path.</param>
        public BotFile(int id, string path)
        {
            this.Id = id;
            this.Path = path;
        }
    }
}