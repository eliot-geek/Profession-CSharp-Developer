using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less06FileSolutionSave
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
        private string firstName;

        /// <summary>
        /// Last Name
        /// </summary>
        private string lastName;

        /// <summary>
        /// Position
        /// </summary>
        private string position;

        /// <summary>
        /// Departement
        /// </summary>
        private string department;

        /// <summary>
        /// Salary
        /// </summary>
        private uint salary;

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
        public Worker(string FirstName, string LastName, string Position, uint Salary, string Department)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.position = Position;
            this.department = Department;
            this.salary = Salary;
        }

        #endregion

        #region Method

        /// <summary>
        /// Print Worker's db
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{this.firstName,15} {this.lastName,15} {this.department,15} {this.position,15} {this.salary,10}";
        }

        #endregion

        #region Properties

        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        /// <summary>
        /// Position
        /// </summary>
        public string Position { get { return this.position; } set { this.position = value; } }

        /// <summary>
        /// Departement
        /// </summary>
        public string Department { get { return this.department; } set { this.department = value; } }

        /// <summary>
        /// Salary
        /// </summary>
        public uint Salary { get { return this.salary; } set { this.salary = value; } }

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
