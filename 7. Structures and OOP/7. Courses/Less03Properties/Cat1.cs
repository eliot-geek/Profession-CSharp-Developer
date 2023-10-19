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
    struct Cat1
    {
        /// <summary> 
        /// Race
        /// </summary>
        public string Breed;

        /// <summary>
        /// Nickname
        /// </summary>
        public string Nickname;

        /// <summary>
        /// Cat's creation
        /// </summary>
        /// <param name="breed"></param>
        /// <param name="nickname"></param>
        public Cat1(string breed, string nickname)
        {
            Breed = breed;
            Nickname = nickname;
        }
    }
}
