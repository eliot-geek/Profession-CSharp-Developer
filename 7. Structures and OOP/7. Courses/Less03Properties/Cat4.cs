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
    struct Cat4
    {
        /// <summary> 
        /// Cat's creation
        /// </summary>
        /// <param name="Breed"></param>
        /// <param name="Nickname"></param>
        //public Cat4(string Breed, string Nickname)
        //{
        //    this.breed = Breed;
        //    this.nickname = Nickname;
        //}

        public Cat4(string Breed, string Nickname) : this() { } // For EyeColor

        /// <summary>
        /// Pseudo
        /// </summary>
        private string nickname;

        /// <summary>
        /// Properties
        /// </summary>
        public string Nickname
        {
            get { return this.nickname; }   // read accessor
            set { this.nickname = value; }  // write accessor
        }

        #region Nickname Old Version

        //public string Nickname;
        //public void SetNickname(string value)
        //{
        //    this.Nickname = value;
        //}
        //public string GetNickname()
        //{
        //    return this.Nickname;
        //}

        #endregion


        /// <summary>
        /// Race
        /// </summary>
        private string breed;  

        /// <summary>
        /// Properties
        /// </summary>
        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        #region Breed Old Version

        //private string Breed;
        //public void SetBreed(string NewBreed)
        //{
        //    this.Breed = NewBreed;
        //}
        //public string GetBreed()
        //{
        //    return this.Breed;
        //}

        #endregion


        /// <summary>
        /// Auto-properties
        /// by default (get, set) - It's public
        /// </summary>
        public string EyeColor { get; set; }
    }
}
