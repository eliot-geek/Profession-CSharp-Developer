using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less03SomethingException
{
    internal class SomethingException : Exception
    {
        public string SomethingMessage { get; set; }

        public SomethingException(string Msg)
        {
            this.SomethingMessage = Msg;
        }


        // public override string HelpLink { get => base.HelpLink; set => base.HelpLink = value; } // F12 every virtual it's okay


        public SomethingException(string Msg, int Code) : base(Msg)
        {
            this.SomethingMessage = Msg;
            this.ErrorCode = Code;

            //ErrorCode = Code;
        }

        public int ErrorCode { get; set; }

    }

    //internal class MyClassException : SomethingException
    //{

    //}
}
