using System;

namespace Banking
{
    public class Transaction
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