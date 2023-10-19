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
    struct Account2
    {
        /// <summary>
        /// Login
        /// </summary>
        public string Login;
        
        /// <summary>
        /// Password
        /// </summary>
        private string Password;

        /// <summary>
        /// New Password
        /// </summary>
        /// <param name="NewPassword"></param>
        public void SetPassword(string NewPassword)
        {
            this.Password = NewPassword;
        }

        /// <summary>
        /// Account
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        public Account2(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
