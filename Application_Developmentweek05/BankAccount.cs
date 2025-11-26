using System;

namespace OOP_Workshop
{
    public class BankAccount
    {
        // Private fields
        private string accountNumber;
        private double balance;

        // Public properties
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Balance cannot be negative or zero");
                }
                balance = value;
            }
        }

        // Constructor
        public BankAccount(string accNumber, double initialBalance)
        {
            accountNumber = accNumber;
            Balance = initialBalance;
        }

        // Methods
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive");
                return;
            }
            balance += amount;
            Console.WriteLine($"Deposited: ${amount}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount}");
        }
    }
}