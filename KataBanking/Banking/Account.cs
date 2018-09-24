using System;
using System.Collections.Generic;

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

        public void Deposit(int ammount)
        {
            Statement.AddTransaction(ammount);
        }

        public void Withdraw(int withdrwAmmount)
        {
            if(Statement.Balance < withdrwAmmount) 
                throw new Exception();

            Statement.AddTransaction(-withdrwAmmount);
        }
    }
}