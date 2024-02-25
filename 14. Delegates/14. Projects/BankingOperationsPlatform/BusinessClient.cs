using System;

namespace BankingOperationsPlatform
{
    /// <summary>
    /// Represents a business client.
    /// </summary>
    internal class Business : Client
    {
        /// <summary>
        /// Gets or sets the loan interest rate for the business client.
        /// </summary>
        public override int LoanRate { get; set; } = 10;

        /// <summary>
        /// Gets or sets the deposit interest rate for the business client.
        /// </summary>
        public override int DepositRate { get; set; } = 10;

        /// <summary>
        /// Gets or sets the status of the client.
        /// </summary>
        public override string Status { get; set; } = "Business";

        /// <summary>
        /// Initializes a new instance of the <see cref="Business"/> class.
        /// </summary>
        public Business() : base($"Business Client-{Guid.NewGuid().ToString().Substring(0, 5)}") { }
    }

}