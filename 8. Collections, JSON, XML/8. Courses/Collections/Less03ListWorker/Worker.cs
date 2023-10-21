using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less03ListWorker
{
    struct Worker
    {
        #region Fields

        /// <summary>
        /// firstName
        /// </summary>
        private string firstName;

        /// <summary>
        /// lastName
        /// </summary>
        private string lastName;

        /// <summary>
        /// Position
        /// </summary>
        private string position;

        /// <summary>
        /// Departement
        /// </summary>
        private string departement;

        /// <summary>
        /// Salary
        /// </summary>
        private uint salary;

        #endregion

        #region Constructors

        /// <summary>
        /// Create worker
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="position"></param>
        /// <param name="departement"></param>
        /// <param name="salary"></param>
        public Worker(string FirstName, string LastName, string Position, string Departement, uint Salary)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.position = Position;
            this.departement = Departement;
            this.salary = Salary;
        }

        #endregion

        #region Method

        /// <summary>
        /// Print
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{this.firstName,15} {this.lastName,15} {this.position,15} {this.departement,15} {this.salary,15}";
        }

        #endregion

        #region Proprieties

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
        public string Departement { get { return this.departement; } set { this.departement = value; } }
        
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
                byte workingDays = 25;      // working days by month
                byte workingHours = 8;      // working hours by day
                return ((double)Salary) / workingDays / workingHours;
            }
        }

        #endregion
    }
}
