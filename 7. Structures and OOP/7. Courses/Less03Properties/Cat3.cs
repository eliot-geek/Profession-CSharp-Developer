using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less03Properties
{
    /// <summary> 
    /// Cat
    /// </summary>
    struct Cat3
    {
        /// <summary>
        /// Nickname
        /// </summary>
        private string Nickname;
        
        /// <summary>
        /// Breed
        /// </summary>
        private string Breed;

        /// <summary>
        /// Cat's creation
        /// </summary>
        /// <param name="nickname"></param>
        /// <param name="breed"></param>
        public Cat3(string breed, string nickname)
        {
            Breed = breed;
            Nickname = nickname;
        }

        /// <summary>
        /// Change the Nickname
        /// </summary>
        /// <param name="NewNickname"></param>
        private void SetNickname(string NewNickname)
        {
            this.Nickname = NewNickname;
        }

        /// <summary>
        /// Get the informationa
        /// </summary>
        /// <returns></returns>
        public string GetNickname()
        {
            return this.Nickname;
        }

        /// <summary>
        /// Change the race
        /// </summary>
        /// <param name="NewBreed"></param>
        public void SetBreed(string NewBreed)
        {
            this.Breed = NewBreed;
        }

        /// <summary>
        /// Get information
        /// </summary>
        private string GetBreed()
        {
            return this.Breed;
        }
    }
}
