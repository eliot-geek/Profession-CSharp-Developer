using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less11SocialNetworkTwitter
{
    /// <summary>
    /// Represents a Twitter user.
    /// </summary>
    internal class TwitterUser
    {
        /// <summary>
        /// Gets or sets the nickname of the Twitter user.
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// Constructs a new instance of the TwitterUser class with the specified nickname.
        /// </summary>
        /// <param name="Nick">The nickname of the Twitter user.</param>
        public TwitterUser(string Nick)
        {
            this.Nick = $"@{Nick}";
        }

        /// <summary>
        /// Publishes a public message on Twitter.
        /// </summary>
        /// <param name="Msg">The message to be published.</param>
        public void PublicMessage(string Msg)
        {
            var args = new TwitterMessageArgs()
            {
                Time = DateTime.Now.ToShortTimeString(),
                Message = Msg
            };
            Page.Print($"Message \"{Msg}\" published by {Nick}\n");

            post?.Invoke(this, args);
            //if (this.Post != null) Post(this, args);
        }

        /// <summary>
        /// Publishes a public message with additional content on Twitter.
        /// </summary>
        /// <param name="Msg">The message to be published.</param>
        /// <param name="Docs">Additional content objects.</param>
        public void PublicMessage(string Msg, params Content[] Docs)
        {
            var args = new TwitterMessageArgs()
            {
                Time = DateTime.Now.ToShortTimeString(),
                Message = Msg,
                Objs = Docs
            };

            Page.Print($"Message  \"{Msg}\" and other content was published by {Nick} \n");
            post?.Invoke(this, args);
        }

        /// <summary>
        /// Event triggered when the Twitter user makes a post.
        /// </summary>
        private event Action<object, TwitterMessageArgs> post;

        #region ToDo

        /// <summary>
        /// Event that represents a user subscribing or unsubscribing to the Twitter user's posts.
        /// </summary>
        public event Action<object, TwitterMessageArgs> Post
        {
            // subscription
            add
            {
                Console.WriteLine($"The User {this.Nick} has a new follower. {(value.Target as TwitterUser).Nick}");
                post += value;
            }
            // unsubscription
            remove
            {
                Console.WriteLine($"{(value.Target as TwitterUser).Nick} unsubscribed from the user {this.Nick}. ");
                post -= value;
            }
        }

        #endregion


        /// <summary>
        /// Handles incoming messages and displays them on the user's tape.
        /// </summary>
        /// <param name="sender">The sender of the message.</param>
        /// <param name="e">The TwitterMessageArgs containing message details.</param>
        public void Tape(object sender, TwitterMessageArgs e)
        {
            var user = sender as TwitterUser;
            Page.Print($"--> Tape {this.Nick}:  {user.Nick} published: {e.Message} ");

            if (e.Objs != null)
            {
                Console.Write("and ");
                foreach (var args in e.Objs)
                {
                    Console.Write($"{args.GetType().Name} ");
                }
            }
            Console.WriteLine();
        }
    }
}
