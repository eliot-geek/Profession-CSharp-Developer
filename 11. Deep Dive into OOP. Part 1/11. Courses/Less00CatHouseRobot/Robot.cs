using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less00CatHouseRobot
{
    /// <summary>
    /// Represents a Robot class.
    /// </summary>
    internal class Robot
    {
        /// <summary>
        /// Private field to store the robot's dislocation.
        /// </summary>
        private string dislocation;

        /// <summary>
        /// Initializes a new instance of the <see cref="Robot"/> class.
        /// </summary>
        /// <param name="Nickname">The nickname of the robot.</param>
        /// <param name="dislocation">The dislocation of the robot.</param>
        public Robot(string Nickname, string dislocation)
        {
            this.Nickname = Nickname;
            this.dislocation = dislocation;
        }

        /// <summary>
        /// Gets the dislocation of the robot.
        /// </summary>
        public string Dislocation { get { return this.dislocation; } }

        /// <summary>
        /// Gets or sets the nickname of the robot.
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Method to perform a task by the robot
        /// </summary>
        public void PerformTask()
        {
            Console.WriteLine($"{this.Nickname} is performing a task....");
        }
    }
}
