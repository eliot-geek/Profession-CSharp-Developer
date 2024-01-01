using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less03Properties
{
    /// <summary>
    /// User
    /// </summary>
    struct Account1
    {
        /// <summary>
        /// Login
        /// </summary>
        public string Login;

        /// <summary>
        /// Password
        /// </summary>
        public string Password;
        
        /// <summary>
        /// Account
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public Account1(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
