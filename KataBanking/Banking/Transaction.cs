using System;

namespace Banking
{
    internal class Transaction
    {
        private const string DateTimeFormat = "dd/MM/yyyy";

        public DateTime Date { get; }
        public int Ammount { get; }
        public int Balance { get; }

        public Transaction(DateTime date, int ammount, int balance)
        {
            Date = date;
            Ammount = ammount;
            Balance = balance;
        }

        public override string ToString()
        {
            return$"{Date.ToString(DateTimeFormat)}\t\t{Ammount.ToStringWithSign()}\t\t{Balance}";
        }
    }
}