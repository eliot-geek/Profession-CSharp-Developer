using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using VkNet;
using VkNet.Utils;

namespace VkontakteBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Pictures

            // ID Application 8072973
            // Protected key 6nYdgdwvXmUFx3KvBL0O
            // Server key access 72729fb872729fb872729fb8f87209b0b57727272729fb8107245b0f2674387e45182d5
            // 1 - Application
            // 2 - Group by interest -Management - work with API -key(13afa1cafc33aebe2c18dc382f1abc336c271933dd915b267e687bbd45f3819d0c65159e4654c527b042e)
            // 3 - Long Poll API

            //VkApi vk = new VkApi();
            //var webClient = new WebClient() { Encoding = Encoding.UTF8 };

            //// Auth Parameters autorisation
            //vk.Authorize(new ApiAuthParams
            //{
            //    ApplicationId = 8072973, // https://vk.com/apps?act=manage
            //    Login = "", //File.ReadAllText("login.txt"),
            //    Password = "",  //File.ReadAllText("password.txt"),
            //    Settings = Settings.All | Settings.Messages,
            //    // Rights to get permissions for the user's token // https://vk.com/dev/permissions
            //});

            //try
            //{
            // ulong IDApp = 8072973;
            //
            //    // Auth Parameters autorisation
            // vk.Authorize(new ApiAuthParams
            //    {
            // ApplicationId = Convert.ToUInt64(IDApp), // https://vk.com/apps?act=manage
            // Login = "79850859893", //File.ReadAllText("login.txt"),
            // Password = "Leo10@",  //File.ReadAllText("password.txt"),
            // Settings = Settings.All | Settings.Messages,
            //        // Rights to get permissions for the user's token // https://vk.com/dev/permissions
            //    });
            //}
            //catch (Exception)
            //{
            // Console.WriteLine("Unauthorized");
            //}
            //if (vk.IsAuthorized)
            //{
            // Console.WriteLine("Authorized");
            //}

            // https://dev.vk.com/method/groups
            // https://dev.vk.com/method/groups.getMembers
            // https://dev.vk.com/method/groups.getMembers?cv%5Bv%5D=5.92
            // https://vk.com/dev/groups.getMembers?params[v]=5.92

            //// Receive group's members
            //var param = new VkParameters() { }; // Object's creation for transfert // https://vk.com/dev/methods
            //param.Add<string>("group_id", "198345138"); // 198345138 // https://vk.com/id[14110338] // https://dev.vk.com/method/groups.getMembers 
            //param.Add<string>("offset", "0");  // https://dev.vk.com/method/users.get  [user_ids]
            //param.Add<string>("count", "100");  // https://dev.vk.com/method/users.get  [photo]

            //// Receive data in JSON format
            //var rawJson = JObject.Parse(vk.Call("groups.getMembers", param).RawJson);

            //// Creation User's id   // https://dev.vk.com/method/users.get
            //string ids = string.Join(", ", rawJson["response"]["items"].ToArray().Select(e => e.ToString()));

            //param = new VkParameters() { };
            //param.Add<string>("user_ids", ids);
            //param.Add<string>("fields", "photo_100"); // https://vk.com/dev/users.get

            //// Get information about users
            //var dbUsers = JObject.Parse(vk.Call("users.get", param).RawJson)["response"];

            //// Going through all the information about users
            //foreach (dynamic item in dbUsers)
            //{
            //    Console.WriteLine($"{item.id} {item.first_name} {item.last_name} {item.photo_100}");

            //    //string url_photo = item.photo_100;
            //    //web.DownloadFile(new Uri(url_photo.Replace("?ava=1", "")), $"photo\\photo_{item.id}_{item.first_name}_{item.last_name}.jpg");
            //}

            //return;

            #endregion


            // group id
            VkApi vk = new VkApi();
            var webClient = new WebClient() { Encoding = Encoding.UTF8 };
            var param = new VkParameters() { };
            param.Add<string>("group_id", "198345138");  // https://vk.com/terms

            //
            dynamic responseLongPoll = JObject.Parse(vk.Call("groups.getLongPollServer", param).RawJson); //parameters for get important infromation for messages
            string json = String.Empty;  // https://vk.com/dev/bots_longpoll // {$server}?act=a_check&key={$key}&ts={$ts}&wait=5

            //
            string url = String.Empty;
            while (true)
            {
                url = string.Format("{0}?act=a_check&key={1}&ts={2}&wait=1",
                    responseLongPoll.response.server.ToString(),
                    responseLongPoll.response.key.ToString(),
                    json != String.Empty ? JObject.Parse(json)["ts"].ToString() : responseLongPoll.response.ts.ToString());

                // https://lp.vk.com/wh178186688?act=a_check&key=13afa1cafc33aebe2c18dc382f1abc336c271933dd915b267e687bbd45f3819d0c65159e4654c527b042e&ts=55&wait=25
                // https://oauth.vk.com/blank.html#access_token=f96b51c3039ff0ce9b48c923537212eeeb32b419809d042bbe81b0e1e4633eb41aa9ec9c01403e14aa7a0&expires_in=0&user_id=455610169&email=leosarah109@gmail.com
                // f96b51c3039ff0ce9b48c923537212eeeb32b419809d042bbe81b0e1e4633eb41aa9ec9c01403e14aa7a0
                // 13afa1cafc33aebe2c18dc382f1abc336c271933dd915b267e687bbd45f3819d0c65159e4654c527b042e
                json = webClient.DownloadString(url);

                // If there are messages
                var jsonMsg = json.IndexOf(":[]}") > -1 ? "" : $"{json} \n";

                // Message's list
                //List<string> ids = new List<string>();
                var col = JObject.Parse(json)["updates"].ToList();

                // Throught all messages
                foreach (var item in col)
                {
                    if (item["type"].ToString() == "message_new")
                    {
                        // 654c617adbd37f55d2b8a37ad6390d5b3da92940238610fadca34e8b0a5e3b56684b9efc9360f66103fdf (search)
                        string token = @"13afa1cafc33aebe2c18dc382f1abc336c271933dd915b267e687bbd45f3819d0c65159e4654c527b042e";
                        string urlBotMsg = $"https://api.vk.com/method/messages.send?v=5.41&access_token={token}&user_id=";

                        string msg = item["object"]["text"].ToString();
                        Console.WriteLine($"{msg} ");

                        webClient.DownloadString(
                            string.Format(urlBotMsg + "{0}&message={1}",
                            item["object"]["user_id"].ToString(),
                            $"In your message \"{msg}\" there are : {msg.Length}"
                            ));
                        Thread.Sleep(100);
                    }
                }
            }
        }
    }
}