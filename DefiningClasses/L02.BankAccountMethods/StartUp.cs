using System;

namespace L02.BankAccountMethods
{
    public class StartUp
    {
        public static void Main()
        {
            var acc = new BankAccount();
            acc.ID = 1;
            acc.Deposit(15);
            acc.Withdraw(10);

            Console.WriteLine(acc);
        }
    }
}
