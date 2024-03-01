using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Individual : Client
    {
        public override int LoanRate { get; set; } = 15;
        public override int DepositRate { get; set; } = 5;
        public override string Status { get; set; } = "Customers";

        public Individual() : base($"Customers-{Guid.NewGuid().ToString().Substring(0, 5)}") { }
    }
}
