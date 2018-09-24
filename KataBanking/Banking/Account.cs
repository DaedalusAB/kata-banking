using System;
using System.Collections.Generic;
using System.Linq;

namespace Banking
{
    public class Account
    {
        public int Balance =>
            _transactions.Sum(t => t.Amount);
        private readonly List<Transaction> _transactions;

        public Account()
        {
            _transactions = new List<Transaction>();
        }

        public void Deposit(int amount)
        {
            _transactions.Add(new Transaction(DateTime.Now, amount, Balance));
        }

        public void Withdraw(int amount)
        {
            if(Balance < amount) 
                throw new Exception();

            _transactions.Add(new Transaction(DateTime.Now, -amount, Balance));
        }
    }
}