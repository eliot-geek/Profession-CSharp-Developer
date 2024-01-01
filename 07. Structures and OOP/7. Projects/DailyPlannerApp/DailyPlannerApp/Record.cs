using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlannerApp
{
    public class Record
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Topic
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Print
        /// </summary>
        /// <returns>A formatted string representation of the Record object.</returns>
        public override string ToString()
        {
            return $"{{Id: {Id,2},  Topic: {Topic,7},  Body: {Body,20},  Name: {Name,10},  Date: {Date,15}}}";
        }
    }

}
