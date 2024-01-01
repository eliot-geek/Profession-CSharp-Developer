using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less02Structures
{
    /// <summary>
    /// Worker's structure
    /// </summary>
    struct Worker
    {
        /// <summary>
        /// Position
        /// </summary>
        public string Position;

        /// <summary>
        /// Salary
        /// </summary>
        public uint Salary;
        
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName;
        
        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName;
        
        /// <summary>
        /// Date Of Birth
        /// </summary>
        public DateTime DateOfBirth;

        /// <summary>
        /// Print Worker's data
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"Position: {Position} Salary: {Salary} First Name: {FirstName} Last Name: {LastName} DateOfBirth: {DateOfBirth.ToShortDateString()} ";
        }

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Salary"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="DateOfBirth"></param>
        public Worker(string Position, uint Salary, string FirstName, string LastName, DateTime DateOfBirth)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        }

        #endregion

        #region Constructor v 1.0

        ///// <summary>
        ///// Constructor
        ///// </summary>
        ///// <param name="Position"></param>
        ///// <param name="Salary"></param>
        ///// <param name="FirstName"></param>
        ///// <param name="LastName"></param>
        ///// <param name="DateOfBirth"></param>
        //public Worker(string Position, uint Salary, string FirstName, string LastName)
        //{
        //    this.Position = Position;
        //    this.Salary = Salary;
        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //    this.DateOfBirth = new DateTime(1900, 3, 4, 0, 0, 0);
        //}


        ///// <summary>
        ///// Constructor
        ///// </summary>
        ///// <param name="Position"></param>
        ///// <param name="Salary"></param>
        ///// <param name="FirstName"></param>
        ///// <param name="LastName"></param>
        ///// <param name="DateOfBirth"></param>
        //public Worker(string Position, string FirstName, string LastName)
        //{
        //    this.Position = Position;
        //    this.Salary = 0;
        //    this.FirstName = FirstName;
        //    this.LastName = LastName;
        //    this.DateOfBirth = new DateTime(1900, 3, 4, 0, 0, 0);
        //}


        ///// <summary>
        ///// Constructor
        ///// </summary>
        ///// <param name="Position"></param>
        ///// <param name="FirstName"></param>
        ///// <param name="LastName"></param>
        //public Worker(string Position, string FirstName)
        //{
        //    this.Position = Position;
        //    this.Salary = 0;
        //    this.FirstName = FirstName;
        //    this.LastName = String.Empty;
        //    this.DateOfBirth = new DateTime(1900, 3, 4, 0, 0, 0);
        //}


        ///// <summary>
        ///// Constructor
        ///// </summary>
        ///// <param name="FirstName"></param>
        //public Worker(string FirstName)
        //{
        //    this.Position = String.Empty;
        //    this.Salary = 0;
        //    this.FirstName = FirstName;
        //    this.LastName = String.Empty;
        //    this.DateOfBirth = new DateTime(1900, 3, 4, 0, 0, 0);
        //}

        #endregion

        #region Constructor v 2.0

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Salary"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        public Worker(string Position, uint Salary, string FirstName, string LastName) :
            this(Position, Salary, FirstName, LastName, new DateTime(1990, 2, 3, 0, 0, 0))
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Salary"></param>
        /// <param name="FirstName"></param>
        public Worker(string Position, uint Salary, string FirstName) :
            this(Position, Salary, FirstName, String.Empty, new DateTime(1990, 2, 3, 0, 0, 0))
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="FirstName"></param>
        public Worker(string Position, string FirstName) :
            this(Position, 0, FirstName, String.Empty, new DateTime(1990, 2, 3, 0, 0, 0))
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="FirstName"></param>
        public Worker(string FirstName) :
            this(String.Empty, 0, FirstName, String.Empty, new DateTime(1990, 2, 3, 0, 0, 0))
        {

        }

        #endregion

    }
}
