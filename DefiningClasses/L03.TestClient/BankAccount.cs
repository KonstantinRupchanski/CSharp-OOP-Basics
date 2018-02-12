using System;
using System.Collections.Generic;
using System.Text;

namespace L03.TestClient
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
            if (Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{ID}, balance {Balance:F2}";
        }
    }
}
