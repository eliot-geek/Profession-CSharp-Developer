using System;

namespace BankingOperationsPlatform
{
    /// <summary>
    /// Represents a VIP client in the banking system.
    /// </summary>
    internal class Vip : Client
    {
        /// <summary>
        /// Gets or sets the loan rate for the VIP client.
        /// </summary>
        public override int LoanRate { get; set; } = 5;

        /// <summary>
        /// Gets or sets the deposit rate for the VIP client.
        /// </summary>
        public override int DepositRate { get; set; } = 15;

        /// <summary>
        /// Gets or sets the status of the client as VIP.
        /// </summary>
        public override string Status { get; set; } = "VIP";

        /// <summary>
        /// Initializes a new instance of the <see cref="Vip"/> class with a generated name.
        /// </summary>
        public Vip() : base($"VIP Client-{Guid.NewGuid().ToString().Substring(0, 5)}") { }
    }
}