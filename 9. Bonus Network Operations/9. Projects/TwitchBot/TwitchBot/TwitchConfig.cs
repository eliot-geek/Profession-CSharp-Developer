using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot
{
    public class TwitchConfig
    {
        static TwitchConfig() => config = new TwitchConfig();

        public static TwitchConfig config;
        public static TwitchConfig Instance => config;


        string twitchNikname;
        public string TwitchNikname => twitchNikname;

        string accessToken;
        public string AccessToken => accessToken;


        private TwitchConfig()
        {
            //https://twitchtokengenerator.com/
            this.accessToken = "";
            this.twitchNikname = ""; // https://www.twitch.tv/twitchNikname

            #region addition

            // Programmer's Application

            //https://dev.twitch.tv/console/apps
            //this.idClient = "";
            //this.botUsername = "";

            #endregion
        }


        #region addition

        //string botUsername;
        //public string BotUsername => botUsername;

        //string idClient;
        //public string IdClient => idClient;

        #endregion

    }
}
