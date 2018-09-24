using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class StatementPrinter
    {
        public const string Header = "Date\t\tAmount\t\tBalance";
        public const string Format = "{0}\t\t{1}\t\t{2}";

        public string Print(IEnumerable<Transaction> transactions)
        {
            if (transactions == null)
                throw new ArgumentNullException(nameof(transactions));

            var sb = new StringBuilder();
            sb.Append(Header);
            foreach (var transaction in transactions)
                sb.Append(Environment.NewLine + string.Format(Format, transaction.Date, transaction.Amount, transaction.Balance));


            return sb.ToString();
        }
    }
}