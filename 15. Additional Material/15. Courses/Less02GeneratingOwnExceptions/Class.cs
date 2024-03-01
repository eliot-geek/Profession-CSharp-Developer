using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less02GeneratingOwnExceptions
{
    /// <summary>
    /// A static class containing a method for demonstration purposes.
    /// </summary>
    internal static class Class
    {
        /// <summary>
        /// A method that simulates different exceptions being thrown based on user input.
        /// </summary>
        public static void Method()
        {
            Console.Write("Data: ");

            if (Console.ReadLine() == "error")
            {
                throw new DataException();
            }

            //throw new IndexOutOfRangeException();
            //throw new FormatException();
            //throw new DivideByZeroException();
        }
    }
}
