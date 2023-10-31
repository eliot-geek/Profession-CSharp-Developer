using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class DiscordConfig
    {
        // DSharpPlus package
        // 940285198459887616
        // url = https://discord.com/api/oauth2/authorize?client_id=940285198459887616&scope=bot&permissions=1
        
        private static DiscordConfig config;
        public string Token => token;
        public static DiscordConfig Instance { get => config == null ? new DiscordConfig() : config; }

        private DiscordConfig()
        {
            /// server
            /// https://discord.com/developers/applications
            /// 
            /// application/Bot DoIt
            this.token = "OTQwMjg1MTk4NDU5ODg3NjE2.YgFK1A.56giXhwxfhxlz9OJJuLuM18-lI8";

            // Copy CLIENT ID from General Information then authorize the bot on the server
            // https://discord.com/developers/docs/topics/oauth2#bot-authorization-flow-url-example
        }
        string token;
    }
}
