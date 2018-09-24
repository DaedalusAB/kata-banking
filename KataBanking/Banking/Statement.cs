using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class Statement
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

        public string PrintStatement()
        {
            var sb = new StringBuilder();
            sb.Append("Date\t\tAmount\t\tBalance" + Environment.NewLine);
            foreach (var transaction in _transactions)
            {
                sb.Append(transaction.Date + "\t\t" + transaction.Amount + "\t\t" + transaction.Balance + Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}