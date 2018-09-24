using System;
using System.Collections.Generic;
using System.Linq;

namespace Banking
{
    internal class Statement
    {
        public int Balance =>
            _transactions.Sum(t => t.Ammount);
        private List<Transaction> _transactions;

        public Statement()
        {
            _transactions = new List<Transaction>();
        }

        public void AddTransaction(int ammount)
        {
            _transactions.Add(new Transaction(DateTime.Now, ammount, Balance));
        }
    }
}