using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less11SocialNetworkTwitter
{
    /// <summary>
    /// Represents the arguments for a Twitter message.
    /// </summary>
    internal class TwitterMessageArgs
    {
        /// <summary>
        /// Gets or sets the time of the Twitter message.
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// Gets or sets the content of the Twitter message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the array of content objects associated with the Twitter message.
        /// </summary>
        public Content[] Objs { get; set; }
    }
}
