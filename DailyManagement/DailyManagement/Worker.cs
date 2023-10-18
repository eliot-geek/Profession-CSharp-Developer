using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyManagement
{
    struct Worker
    {
        /// <summary>
        /// Identifiant
        /// </summary>
        private int ID;

        /// <summary>
        /// DateAndTime
        /// </summary>
        private DateTime DateAndTime;

        /// <summary>
        /// FullName
        /// </summary>
        private string FullName;

        /// <summary>
        /// Age
        /// </summary>
        private int Age;

        /// <summary>
        /// Height
        /// </summary>
        private float Height;

        /// <summary>
        /// DateOfBirth
        /// </summary>
        private DateTime DateOfBirth;

        /// <summary>
        /// PlaceOfBirth
        /// </summary>
        private string PlaceOfBirth;

        /// <summary>
        /// Add worker
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="dateAndTime"></param>
        /// <param name="fullName"></param>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="placeOfBirth"></param>
        public Worker(int iD, DateTime dateAndTime, string fullName, int age, float height, DateTime dateOfBirth, string placeOfBirth)
        {
            ID = iD;
            DateAndTime = dateAndTime;
            FullName = fullName;
            Age = age;
            Height = height;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
        }


        /// <summary>
        /// ID
        /// </summary>
        public int iD { get { return ID; } set { ID = value; } }
        
        /// <summary>
        /// Date and Time
        /// </summary>
        public DateTime dateAndTime { get { return DateAndTime; } set { DateAndTime = value; } }
        
        /// <summary>
        /// FullName
        /// </summary>
        public string fullName { get { return FullName; } set { FullName = value; } }
        
        /// <summary>
        /// Age
        /// </summary>
        public int age { get { return Age; } set { Age = value; } }
        
        /// <summary>
        /// height
        /// </summary>
        public float height { get { return Height; } set { Height = value; } }
        
        /// <summary>
        /// DateOfBirth
        /// </summary>
        public DateTime dateOfBirth { get { return DateOfBirth; } set { DateOfBirth = value; } }
        
        /// <summary>
        /// PlaceOfBith
        /// </summary>
        public string placeOfBirth { get { return PlaceOfBirth; } set { PlaceOfBirth = value; } }

    }
}
