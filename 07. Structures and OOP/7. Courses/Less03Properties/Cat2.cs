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
    struct Cat2
    {
        /// <summary>
        /// Nick
        /// </summary>
        public string Nickname;

        /// <summary>
        /// Race
        /// </summary>
        private string Breed;
        
        /// <summary>
        /// Cat's creation
        /// </summary>
        /// <param name="nickname"></param>
        /// <param name="breed"></param>
        public Cat2(string breed, string nickname)
        {
            Breed = breed;
            Nickname = nickname;
        }

        /// <summary>
        /// Get information
        /// </summary>
        /// <returns></returns>
        public string GetBreed()
        {
            return this.Breed;
        }
    }
}
