using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less03SomethingException
{
    internal class SomethingException1 : Exception
    {
        public SomethingException1(string Msg) : base(Msg)
        {

        }
    }
}
