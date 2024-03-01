using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Core
    {
        public event Action<string> Information;

        public ObservableCollection<BankDep> bank;

        Random rnd = new Random();

        public ObservableCollection<BankDep> CreateBank()
        {
            bank = new ObservableCollection<BankDep>();

            bank.Add(new IndividBank());
            AddClientsToBank(rnd.Next(10, 20));
            return bank;
        }

        void AddClientsToBank(int individ)
        {
            for (int i = 0; i < individ; i++)
            {
                CreateClientsCollection<Individual>((int)BankDepartment.IndividualBank);
            }
        }

        void CreateClientsCollection<T>(int bankDep) where T : Client, new()
        {
            bank[bankDep].Clients.Add(new T());
        }

        public bool CheckAmount(Client client, uint amount)
        {
            bool result = client.Money >= amount;
            return result;
        }

        public void TransferFunds(Client sender, Client recipient, uint amount)
        {
            sender.Money -= amount;
            recipient.Money += amount;
            Information?.Invoke($"Transfered ${amount} from {sender.Name} to {recipient.Name}");
        }

        public void MakeDeposit(Client client, uint amount)
        {
            client.Money -= amount;
            client.AccountType = AccountType.DepositAccount;
            client.IsOpen = Open.Yes;
            client.DepositAmount += amount;
            Information?.Invoke($"Deposit Account was created and ${amount} was made by {client.Name}");
        }

        public void NonDeposit(Client client, uint amount)
        {
            client.Money -= amount;
            client.AccountType = AccountType.NonDepositAccount;
            client.IsOpen = Open.Yes;
            client.DepositAmount += amount;
            Information?.Invoke($"Non Deposit Account was created and ${amount} was made by {client.Name}");
        }

        public void FillBalance(Client client, uint amount)
        {
            client.Money += amount;
            client.IsLoan = Loan.Yes;
            Information?.Invoke($"{client.Name} received ${amount}");
        }

        public bool checkFundsPositive(bool result)
        {
            if (!result)
            {
                throw new InsufficientFundsException("Insufficient Funds!");
            }
            else
                return true;
        }

        public bool checkWrongAmount(bool result)
        {
            if (!result)
            {
                throw new WrongAmountException("Wrong Amount!");
            }
            else
                return true;
        }
    }
}
