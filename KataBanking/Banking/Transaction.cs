using System;

namespace Banking
{
    internal class Transaction
    {
        public DateTime Date { get; }
        public int Amount { get; }
        public int Balance { get; }

        public Transaction(DateTime date, int amount, int balance)
        {
            Date = date;
            Amount = amount;
            Balance = balance;
        }
    }
}