using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class Account
    {
        private readonly List<Transaction> _transactions;

        private const string Header = "Date\t\tAmmount\t\tBalance";

        private int Balance =>
            _transactions.Any()
                ? _transactions.Last().Ammount
                : 0;

        public Account()
        {
            _transactions = new List<Transaction>();
        }

        public void Deposit(int ammount) =>
           _transactions.Add(new Transaction(DateTime.Now, ammount, Balance + ammount));

        public void Withdraw(int ammount)
        {
            var balance = Balance;

            if (balance < ammount)
            {
                throw new ArgumentException(nameof(ammount));
            }

            _transactions.Add(new Transaction(DateTime.Now, -ammount, balance - ammount));
        }

        public string PrintStatement()
        {
            var sb = new StringBuilder();
            sb.Append(Header + Environment.NewLine);

            foreach (var transaction in _transactions)
                sb.Append(transaction + Environment.NewLine);

            return sb.ToString();
        }
    }
}
