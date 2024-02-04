using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less02RobotProgram
{
    /// <summary>
    /// Robot
    /// </summary>
    internal class Robot
    {
        /// <summary>
        /// Dislocation's place Field
        /// </summary>
        private string dislocation;

        /// <summary>
        /// Dislocation's place Property
        /// </summary>
        public string Dislocation { get { return this.dislocation; } }

        /// <summary>
        /// Nickname Field
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Robot's creation
        /// </summary>
        /// <param name="Nickname">Name</param>
        /// <param name="Dislocation">Dislocation's place</param>
        public Robot(string Nickname, string Dislocation)
        {
            this.Nickname = Nickname;
            this.dislocation = Dislocation;
        }
    }
}
