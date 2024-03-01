using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Extensions
    {
        public static void AddMoney(this Client client, uint amount)
        {
            client.Money += amount;
        }

        public static void DeductMoney(this Client client, uint amount)
        {
            client.Money -= amount;
        }

        public static void MakeDeposit(this Client client, uint amount)
        {
            client.Money -= amount;
            client.DepositAmount += amount;
        }
    }
}
