using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less13IndexersDataProvider
{
    /// <summary>
    /// Represents a repository for managing a database of Worker instances.
    /// </summary>
    internal class DataProvider
    {
        /// <summary>
        /// Worker's Database
        /// </summary>
        private Worker[] Workers;

        /// <summary>
        /// Returns an instance of Worker based on the specified index in the database.
        /// Returns null if there is no such instance.
        /// </summary>
        /// <param name="index">Position in the database</param>
        /// <returns>Worker</returns>
        public Worker this[int index]
        {
            get 
            { 
                return this.Workers[index]; 
            }
        }

        /// <summary>
        /// Returns an instance of Worker based on the assumed name in the database.
        /// Returns null if there is no such instance.
        /// </summary>
        /// <param name="Name">Assumed name in the database</param>
        /// <returns>Worker</returns>
        public Worker this[string Name]
        {
            get
            {
                Worker t = null;

                foreach (var e in this.Workers)
                {
                    if (e.FirstName == Name) 
                    { 
                        t = e; 
                        break; 
                    }
                }

                return t;
            }
        }

        /// <summary>
        /// Returns an instance of Worker based on the assumed name and position in the database.
        /// Returns null if there is no such instance.
        /// </summary>
        /// <param name="Name">Assumed name in the database</param>
        /// <param name="Position">Assumed position in the database</param>
        /// <returns>Worker</returns>
        public Worker this[string Name, string Position]
        {
            get
            {
                Worker t = null;

                foreach (var e in this.Workers)
                {
                    if (e.FirstName == Name && e.Position == Position) 
                    { 
                        t = e; 
                        break; 
                    }
                }

                return t;
            }
        }

        /// <summary>
        /// Constructor for the DataProvider class.
        /// </summary>
        /// <param name="Args">List of workers to initialize the database.</param>
        public DataProvider(params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
