using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Client
    {
        static Random rnd = new Random();

        int randScore = rnd.Next(0, 3);
        
        private int randCash = rnd.Next(0, 10000);

        public string Name { get; set; }
        public uint Money { get; set; }
        public Loan IsLoan { get; set; }
        public abstract int LoanRate { get; set; }
        public Open IsOpen { get; set; }
        public abstract int DepositRate { get; set; }
        public AccountType AccountType { get; set; }
        public uint DepositAmount { get; set; }
        public CreditScore CreditScore { get; set; }
        public abstract string Status { get; set; }

        public Client(string name = "RandomClient")
        {
            Name = name;

            switch (randScore)
            {
                case 0:
                case 1:
                    CreditScore = CreditScore.No;
                    break;
            }
            Money = (uint)randCash;
        }
    }
}
