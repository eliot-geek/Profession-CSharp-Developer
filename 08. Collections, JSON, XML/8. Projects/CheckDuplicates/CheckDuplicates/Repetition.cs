using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDuplicates
{
    /// <summary>
    /// Checking Duplicates 
    /// </summary>
    internal class Repetition
    {
        /// <summary>
        /// Add Numbers To HashSet
        /// </summary>
        /// <param name="set"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool AddNumberToSet(HashSet<int> set, int number)
        {
            if (set.Contains(number))
            {
                return false;
            }
            set.Add(number);
            return true;
        }
    }
}
