using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class InsufficientFundsException : ApplicationException
    {
        public InsufficientFundsException(string message) : base(message)
        {

        }
    }

    public class WrongAmountException : ApplicationException
    {
        public WrongAmountException(string message) : base(message)
        {

        }
    }
}
