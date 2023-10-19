using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less04Indexers
{
    /// <summary>
    /// Repository
    /// </summary>
    struct Repository2
    {
        /// <summary>
        /// Worker's data base
        /// </summary>
        private Worker[] Workers;

        /// <summary>
        /// For index (array) properties
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Worker this[int index]
        {
            get { return Workers[index]; }
            set { Workers[index] = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Args"></param>
        public Repository2(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
