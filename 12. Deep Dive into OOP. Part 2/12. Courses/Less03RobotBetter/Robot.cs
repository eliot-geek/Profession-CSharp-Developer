using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less03RobotBetter
{
    /// <summary>
    /// Represents a Robot with properties such as Nickname and Dislocation.
    /// Implements the IEquatable interface for equality comparison.
    /// </summary>
    internal class Robot : IEquatable<Robot>
    {
        /// <summary>
        /// Gets or sets the dislocation of the robot.
        /// </summary>
        private string dislocation;

        /// <summary>
        /// Gets the dislocation of the robot.
        /// </summary>
        public string Dislocation { get { return this.dislocation; } }

        /// <summary>
        /// Gets or sets the nickname of the robot.
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Initializes a new instance of the Robot class.
        /// </summary>
        /// <param name="Nickname">The name of the robot.</param>
        /// <param name="Dislocation">The place of dislocation for the robot.</param>
        public Robot(string Nickname, string Dislocation)
        {
            this.Nickname = Nickname;
            this.dislocation = Dislocation;
        }

        /// <summary>
        /// Determines whether the specified Robot is equal to the current Robot.
        /// </summary>
        /// <param name="other">The Robot to compare with the current Robot.</param>
        /// <returns>True if the specified Robot is equal to the current Robot; otherwise, false.</returns>
        public bool Equals(Robot other)
        {
            return this.Nickname == other.Nickname
                   && this.dislocation == other.dislocation;
        }
    }
}
