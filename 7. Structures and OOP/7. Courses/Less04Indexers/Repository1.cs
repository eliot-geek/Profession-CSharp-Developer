using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less04Indexers
{
    /// <summary>
    /// Repository (one array)
    /// </summary>
    struct Repository1
    {
        /// <summary>
        /// Worker's data base
        /// </summary>
        public Worker[] Workers;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Args">List Of Workers</param>
        public Repository1(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
