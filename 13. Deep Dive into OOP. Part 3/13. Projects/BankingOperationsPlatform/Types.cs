namespace BankingOperationsPlatform
{
    /// <summary>
    /// Enumeration representing different departments in a bank.
    /// </summary>
    public enum BankDepartment
    {
        IndividualBank,
        BusinessBank,
        VipBank
    }

    /// <summary>
    /// Enumeration representing the type of deposit associated with a client's account.
    /// </summary>
    public enum DepositType
    {
        No,
        Simple,
        Capitalization
    }

    /// <summary>
    /// Enumeration representing the credit score status of a client.
    /// </summary>
    public enum CreditScore
    {
        No,
        Yes
    }

    /// <summary>
    /// Enumeration representing the availability of a loan for a client.
    /// </summary>
    public enum Loan
    {
        No,
        Yes
    }

    /// <summary>
    /// Enumeration representing the availability of a deposit for a client.
    /// </summary>
    public enum Deposit
    {
        No,
        Yes
    }
}
