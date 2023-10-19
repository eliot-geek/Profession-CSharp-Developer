using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less05FileSolution
{
    /// <summary> 
    /// Worker
    /// </summary>
    struct Worker
    {
        #region Parametres
        
        /// <summary>
        /// First Name
        /// </summary>
        private string FirstName;

        /// <summary>
        /// Last Name
        /// </summary>
        private string LastName;

        /// <summary>
        /// Position
        /// </summary>
        private string Position;

        /// <summary>
        /// Departement
        /// </summary>
        private string Department;

        /// <summary>
        /// Salary
        /// </summary>
        private uint Salary;

        #endregion

        #region Constructor

        /// <summary>
        /// Worker's creation
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="position"></param>
        /// <param name="department"></param>
        /// <param name="salary"></param>
        public Worker(string firstName, string lastName, string position, uint salary, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Department = department;
            Salary = salary;
        }

        #endregion

        #region Method

        /// <summary>
        /// Print Worker's db
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{this.FirstName,15} {this.LastName,15} {this.Department,15} {this.Position,15} {this.Salary,10}";
        }

        #endregion

        #region Properties

        /// <summary>
        /// FirstName
        /// </summary>
        public string firstName { get { return this.FirstName; } set { this.FirstName = value; } }

        /// <summary>
        /// LastName
        /// </summary>
        public string lastName { get { return this.LastName; } set { this.LastName = value; } }

        /// <summary>
        /// Position
        /// </summary>
        public string position { get { return this.Position; } set { this.Position = value; } }

        /// <summary>
        /// Departement
        /// </summary>
        public string department { get { return this.Department; } set { this.Department = value; } }

        /// <summary>
        /// Salary
        /// </summary>
        public uint salary { get { return this.Salary; } set { this.Salary = value; } }

        /// <summary>
        /// Salary by hour
        /// </summary>
        public double HourRate
        {
            get
            {
                byte workingDays = 25;      // Working days per month
                byte workingHours = 8;      // Working hours per day
                return ((double)Salary) / workingDays / workingHours;
            }
        }

        #endregion
    }
}
