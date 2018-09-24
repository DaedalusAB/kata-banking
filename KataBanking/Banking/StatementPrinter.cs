using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class StatementPrinter
    {
        public const string HeaderFormat = "Date\t\tAmount\t\tBalance";
        public const string RowFormat = "{0}\t\t{1}\t\t{2}";

        public string Print(IEnumerable<Transaction> transactions)
        {
            if (transactions == null)
                throw new ArgumentNullException(nameof(transactions));

            var sb = new StringBuilder();
            sb.Append(HeaderFormat);
            foreach (var transaction in transactions)
                sb.Append(Environment.NewLine + string.Format(RowFormat, transaction.Date, transaction.Amount, transaction.Balance));


            return sb.ToString();
        }
    }
}