using System;
using System.Collections.Generic;
using Banking;
using Xunit;

namespace BankingTests
{
    public class StatementPrinterTests
    {
        [Fact]
        public void PrintEmptyStatement()
        {
            var printer = new StatementPrinter();
            var transactions = new List<Transaction>();

            var printedStatement = printer.Print(transactions);
            var expectedStatement = StatementPrinter.HeaderFormat;

            Assert.Equal(expectedStatement, printedStatement);
        }

        [Fact]
        public void PrintStatementWithOneTransaction()
        {
            var ammount = 100;
            var transaction = new Transaction(DateTime.Now, ammount, ammount);
            var transactions = new List<Transaction>()
            {
                transaction
            };
            var printer = new StatementPrinter();

            var printedStatement = printer.Print(transactions);
            var expectedStatement = 
                StatementPrinter.HeaderFormat 
                + Environment.NewLine + PrintedTransaction(transaction);


            Assert.Equal(expectedStatement, printedStatement);
        }

        [Fact]
        public void PrintStatementWithTwoTransactions()
        {
            var depositAmount = 100;
            var withdrawAmount = -50;
            var depositTransaction = new Transaction(DateTime.Now, depositAmount, depositAmount);
            var withdrawTransaction = new Transaction(DateTime.Now, withdrawAmount, depositAmount + withdrawAmount);
            var transactions = new List<Transaction>()
            {
                depositTransaction,
                withdrawTransaction
            };
            var printer = new StatementPrinter();

            var printedStatement = printer.Print(transactions);
            var expectedStatement = 
                StatementPrinter.HeaderFormat
                + Environment.NewLine + PrintedTransaction(depositTransaction)
                + Environment.NewLine + PrintedTransaction(withdrawTransaction);


            Assert.Equal(expectedStatement, printedStatement);
        }

        private string PrintedTransaction(Transaction transaction)
        {
            return string.Format(StatementPrinter.RowFormat, transaction.Date, transaction.Amount, transaction.Balance);
        }
    }
}
