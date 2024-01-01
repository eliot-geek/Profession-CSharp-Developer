using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKBot
{
    public class VkConfig
    {
        /// https://vk.com/dev/bots
        /// https://vk.com/dev/bots_docs - Basics
        
        /// Enable the bot at https://vk.com/club202670669?act=messages&tab=bots
        
        /// 1.1. Obtain the Long Poll access key
        /// Open the "Community Management" section
        /// ("Page Management" if you have a public page),
        /// select the "API Usage" tab, and click "Create Access Key."
        /// https://vk.com/club202670669?act=longpoll_api
        ///
        /// Obtain the groupId at https://vk.com/dev/groups.getById

        private static readonly VkConfig config;

        static VkConfig()
        {
            config = new VkConfig();
        }
        public string AccessToken => accessToken;

        public static VkConfig Instance => config;
        public ulong GroupId => groupId;

        private VkConfig()
        {
            this.accessToken = "13afa1cafc33aebe2c18dc382f1abc336c271933dd915b267e687bbd45f3819d0c65159e4654c527b042e";
            this.groupId = 210580527;

            #region login password

            //this.login = "";
            //this.password = "";
            //this.appId = "";

            #endregion
        }

        string accessToken;
        ulong groupId;

        #region login

        //public string Login => login;
        //public string Password => password; 
        //public ulong AppId  => appId;
        //ulong appId;
        //string login;
        //string password;

        #endregion
    }
}
