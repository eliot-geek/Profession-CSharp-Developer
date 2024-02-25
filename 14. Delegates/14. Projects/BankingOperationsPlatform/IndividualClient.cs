using System;

namespace BankingOperationsPlatform
{
    /// <summary>
    /// Represents an individual client.
    /// </summary>
    public class Individual : Client
    {
        /// <summary>
        /// Gets or sets the loan interest rate for the individual client.
        /// </summary>
        public override int LoanRate { get; set; } = 15;

        /// <summary>
        /// Gets or sets the deposit interest rate for the individual client.
        /// </summary>
        public override int DepositRate { get; set; } = 5;

        /// <summary>
        /// Gets or sets the status of the individual client.
        /// </summary>
        public override string Status { get; set; } = "Individual";

        /// <summary>
        /// Initializes a new instance of the <see cref="Individual"/> class with a default name.
        /// </summary>
        public Individual() : base($"Individual Client-{Guid.NewGuid().ToString().Substring(0, 5)}") { }
    }
}