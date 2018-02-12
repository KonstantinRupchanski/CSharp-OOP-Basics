using System;

namespace L02.BankAccountMethods
{
    public class BankAccount
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {ID}, balance {Balance}";
        }
    }
}
