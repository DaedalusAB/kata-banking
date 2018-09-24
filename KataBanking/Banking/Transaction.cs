using System;

namespace Banking
{
    internal class Transaction
    {
        public DateTime Date { get; }
        public int Ammount { get; }
        public int Balance { get; }

        public Transaction(DateTime date, int ammount, int balance)
        {
            Date = date;
            Ammount = ammount;
            Balance = balance;
        }
    }
}