using System;
using System.Collections.Generic;
using System.Text;

namespace BankingOperationsPlatform
{
    public abstract class Client
    {
        /// <summary>
        /// Represents a random number generator used for generating random scores and cash amounts.
        /// </summary>
        static Random rnd = new Random();

        /// <summary>
        /// Generates a random score between 0 and 2.
        /// </summary>
        int randScore = rnd.Next(0, 3);

        /// <summary>
        /// Generates a random cash amount between 0 and 9999.
        /// </summary>
        private int randCash = rnd.Next(0, 10000);

        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the amount of money.
        /// </summary>
        public uint Money { get; set; }

        /// <summary>
        /// Gets or sets the status of the loan.
        /// </summary>
        public Loan IsLoan { get; set; }

        /// <summary>
        /// Gets or sets the loan interest rate.
        /// </summary>
        public abstract int LoanRate { get; set; }

        /// <summary>
        /// Gets or sets the status of the deposit.
        /// </summary>
        public Deposit IsDeposit { get; set; }

        /// <summary>
        /// Gets or sets the deposit interest rate.
        /// </summary>
        public abstract int DepositRate { get; set; }

        /// <summary>
        /// Gets or sets the type of deposit.
        /// </summary>
        public DepositType DepositType { get; set; }

        /// <summary>
        /// Gets or sets the amount of deposit.
        /// </summary>
        public uint DepositAmount { get; set; }

        /// <summary>
        /// Gets or sets the credit score.
        /// </summary>
        public CreditScore CreditScore { get; set; }

        /// <summary>
        /// Gets or sets the status of the client.
        /// </summary>
        public abstract string Status { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class with the specified name.
        /// If no name is provided, a default name "RandomClient" is used.
        /// </summary>
        /// <param name="name">The name of the client.</param>
        public Client(string name = "RandomClient")
        {
            Name = name;

            // Determine the credit score based on random score generated
            switch (randScore)
            {
                // 0 and 1 represent poor credit score (66% probability)
                case 0:
                case 1:
                    CreditScore = CreditScore.No;
                    break;
                
                    // 2 represents good credit score (33% probability)
                default:
                    CreditScore = CreditScore.Yes;

                                            // Adjust loan and deposit rates for clients with good credit score
                    LoanRate -= 3;          // Additional rate reduction for good clients
                    DepositRate += 3;       // Additional rate increase for good clients
                    break;
            }

            // Initialize money with a random cash amount
            Money = (uint)randCash;
        }

    }
}

