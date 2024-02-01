using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less00CatHouseRobot
{
    /// <summary>
    /// Represents a House class.
    /// </summary>
    internal class House
    {
        /// <summary>
        /// Private field to store the floor count of the house.
        /// </summary>
        private int floorCount;

        /// <summary>
        /// Private field to store the flat count of the house.
        /// </summary>
        private int flatCount;

        /// <summary>
        /// Private field to store the address of the house.
        /// </summary>
        private string address;

        /// <summary>
        /// Initializes a new instance of the <see cref="House"/> class.
        /// </summary>
        /// <param name="floorCount">The floor count of the house.</param>
        /// <param name="flatCount">The flat count of the house.</param>
        /// <param name="address">The address of the house.</param>
        public House(int floorCount, int flatCount, string address)
        {
            this.floorCount = floorCount;
            this.flatCount = flatCount;
            this.address = address;
        }

        /// <summary>
        /// Gets the floor count of the house.
        /// </summary>
        public int FloorCount { get { return this.floorCount; } }

        /// <summary>
        /// Gets the flat count of the house.
        /// </summary>
        public int FlatCount { get { return this.flatCount; } }

        /// <summary>
        /// Gets the address of the house.
        /// </summary>
        public string Address { get { return this.address; } }
    }
}
