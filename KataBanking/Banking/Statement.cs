using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Banking
{
    public class Statement : IEnumerable<Transaction>
    {
        public int Balance =>
            _transactions.Sum(t => t.Amount);

        private readonly List<Transaction> _transactions;

        public Statement()
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

        public IEnumerator<Transaction> GetEnumerator()
        {
            return _transactions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}