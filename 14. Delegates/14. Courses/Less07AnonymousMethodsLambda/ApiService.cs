using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less07AnonymousMethodsLambda
{
    internal class ApiService
    {
        /// <summary>
        /// Gets dummy data from the API service.
        /// </summary>
        /// <returns>A string containing the dummy data.</returns>
        public static string GetData()
        {
            string data = String.Empty;

            for (int i = 0; i < 10; i++)
            {
                data += Guid.NewGuid().ToString();
            }
            return data;
        }
    }
}
