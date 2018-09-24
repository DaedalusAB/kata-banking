using System;

namespace Banking
{
    public class Account
    {
        private Statement Statement { get; }
        public int Balance =>
            Statement.Balance;

        public Account()
        {
            Statement = new Statement();
        }

        public void Deposit(int amount)
        {
            Statement.AddTransaction(amount);
        }

        public void Withdraw(int withdrwAmount)
        {
            if(Statement.Balance < withdrwAmount) 
                throw new Exception();

            Statement.AddTransaction(-withdrwAmount);
        }
    }
}