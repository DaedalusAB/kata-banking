using System;
using System.Collections.Generic;
using System.Linq;

namespace Banking
{
    internal class Statement
    {
        public int Balance =>
            _transactions.Sum(t => t.Amount);
        private readonly List<Transaction> _transactions;

        public Statement()
        {
            _transactions = new List<Transaction>();
        }

        public void AddTransaction(int amount)
        {
            _transactions.Add(new Transaction(DateTime.Now, amount, Balance));
        }
    }
}