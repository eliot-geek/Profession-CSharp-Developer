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
    struct Repository3
    {
        /// <summary>
        /// Worker's data base
        /// </summary>
        private Worker[] Workers;

        /// <summary>
        /// Index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get { return this.Workers[index].Print(); }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Args"></param>
        public Repository3(params Worker[] Args)
        {
            Workers = Args;
        }

    }
}
