using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace BankingOperationsPlatform
{
    internal class Core
    {
        /// <summary>
        /// Represents the banking system containing three departments: individual, business, and VIP.
        /// </summary>
        public ObservableCollection<BankDep> bank;

        /// <summary>
        /// Random number generator instance.
        /// </summary>
        Random rnd = new Random();

        /// <summary>
        /// Creates the bank structure with three departments: individual, business, and VIP.
        /// </summary>
        /// <returns>An ObservableCollection containing the bank departments.</returns>
        public ObservableCollection<BankDep> CreateBank()
        {
            // Initialize the bank collection
            bank = new ObservableCollection<BankDep>();

            // Create three main departments
            bank.Add(new IndividBank());
            bank.Add(new BusinessBank());
            bank.Add(new VipBank());

            // Add random clients to each department
            AddClientsToBank(rnd.Next(10, 30), rnd.Next(10, 30), rnd.Next(10, 30));

            return bank;
        }


        /// <summary>
        /// Adds clients to the bank departments.
        /// </summary>
        /// <param name="individ">The number of individual clients to add.</param>
        /// <param name="business">The number of business clients to add.</param>
        /// <param name="vip">The number of VIP clients to add.</param>
        void AddClientsToBank(int individ, int business, int vip)
        {
            // Add individual clients to the individual department
            for (int i = 0; i < individ; i++)
            {
                CreateClientsCollection<Individual>((int)BankDepartment.IndividualBank);
            }

            // Add business clients to the business department
            for (int i = 0; i < business; i++)
            {
                CreateClientsCollection<Business>((int)BankDepartment.BusinessBank);
            }

            // Add VIP clients to the VIP department
            for (int i = 0; i < vip; i++)
            {
                CreateClientsCollection<Vip>((int)BankDepartment.VipBank);
            }
        }

        /// <summary>
        /// Adds clients to the specified bank department.
        /// </summary>
        /// <typeparam name="T">The type of client to add.</typeparam>
        /// <param name="bankDep">The index of the bank department in the bank collection.</param>
        void CreateClientsCollection<T>(int bankDep) where T : Client, new()
        {
            bank[bankDep].Clients.Add(new T());
        }

        /// <summary>
        /// Checks if the client has enough money to make a transfer.
        /// </summary>
        /// <param name="client">The client initiating the transfer.</param>
        /// <param name="amount">The amount of money to transfer.</param>
        /// <returns>True if the client has enough money, otherwise false.</returns>
        public bool CheckSuffAmount(Client client, uint amount)
        {
            bool result = client.Money >= amount;
            return result;
        }

        /// <summary>
        /// Transfers funds from one client to another.
        /// </summary>
        /// <param name="sender">The client sending the funds.</param>
        /// <param name="recipient">The client receiving the funds.</param>
        /// <param name="amount">The amount of money to transfer.</param>
        public void TransferFunds(Client sender, Client recipient, uint amount)
        {
            sender.Money -= amount;
            recipient.Money += amount;
        }


        /// <summary>
        /// Makes a simple deposit without capitalization.
        /// </summary>
        /// <param name="client">The client making the deposit.</param>
        /// <param name="amount">The amount of money to deposit.</param>
        public void MakeSimpleDeposit(Client client, uint amount)
        {
            client.Money -= amount;
            client.DepositType = DepositType.Simple;
            client.IsDeposit = Deposit.Yes;
            client.DepositAmount += amount;
        }

        /// <summary>
        /// Makes a deposit with capitalization.
        /// </summary>
        /// <param name="client">The client making the deposit.</param>
        /// <param name="amount">The amount of money to deposit.</param>
        public void MakeCapitalizedDeposit(Client client, uint amount)
        {
            client.Money -= amount;
            client.DepositType = DepositType.Capitalization;
            client.IsDeposit = Deposit.Yes;
            client.DepositAmount += amount;
        }

        /// <summary>
        /// Obtains a loan for the client.
        /// </summary>
        /// <param name="client">The client obtaining the loan.</param>
        /// <param name="amount">The amount of money to loan.</param>
        public void GetLoan(Client client, uint amount)
        {
            client.Money += amount;
            client.IsLoan = Loan.Yes;
        }

        /// <summary>
        /// Calculates the monthly interest for the client's deposit.
        /// </summary>
        /// <param name="client">The client whose deposit interest is being calculated.</param>
        /// <returns>An array containing the deposit balance for each month.</returns>
        public double[] DepositInfo(Client client)
        {
            int deposit = (int) client.DepositAmount;
            double[] months = new double[12];
            int rate = client.DepositRate;

            // Simple interest
            if (client.DepositType == DepositType.Simple)
            {
                for (int i = 0; i < months.Length; i++)
                {
                    if (i == 0)
                    {
                        months[i] = (((double)deposit / 100 * rate) / 12) + deposit;
                        Math.Round(months[i], 2);
                        months[i] = Math.Round(months[i], 2);
                        continue;
                    }

                    months[i] = (((double)deposit / 100 * rate) / 12) + months[i-1];
                    Math.Round(months[i], 2);
                    months[i] = Math.Round(months[i], 2);
                }
            }

            // Capitalized interest
            else
            {
                for (int i = 0; i < months.Length; i++)
                {
                    if (i == 0)
                    {
                        months[i] = (((double)deposit / 100 * rate) / 12) + deposit;
                        Math.Round(months[i], 2);
                        months[i] = Math.Round(months[i], 2);
                        continue;
                    }

                    months[i] = ((months[i-1] / 100 * rate) / 12) + months[i-1];
                    months[i] = Math.Round(months[i], 2);
                }
            }

            return months;
        }
    }
}
