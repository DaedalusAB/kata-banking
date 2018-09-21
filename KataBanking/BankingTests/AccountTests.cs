using System;
using System.Runtime.Serialization;
using Banking;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace BankingTests
{
    public class AccountTests
    {
        private const string DateTimeFormat = "dd/MM/yyyy";
        private readonly ITestOutputHelper _output;

        public AccountTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void DepositMoneyIntoAccount()
        {
            var account = new Account();
            var ammount = 100;
            account.Deposit(ammount);

            Assert.Contains(
                StatementLine(DateTime.Now, ammount, ammount),
                account.PrintStatement()
                );
        }

        [Fact]
        public void DepositMoneyIntoAccountTwice()
        {
            var account = new Account();
            var ammount1 = 100;
            var ammount2 = 200;
            account.Deposit(ammount1);
            account.Deposit(ammount2);

            Assert.Contains(
                StatementLine(DateTime.Now, ammount1, ammount1),
                account.PrintStatement()
                );
            Assert.Contains(
                StatementLine(DateTime.Now, ammount2, ammount1 + ammount2),
                account.PrintStatement()
                );
        }

        [Fact]
        public void WithdrawMoneyFromAccoun_WhenThereIsEnoughMoney()
        {
            var account = new Account();
            var ammount1 = 100;
            var ammount2 = 50;
            account.Deposit(ammount1);
            account.Withdraw(ammount2);

            Assert.Contains(
                StatementLine(DateTime.Now, ammount1, ammount1),
                account.PrintStatement()
            );
            Assert.Contains(
                StatementLine(DateTime.Now, -ammount2, ammount1 - ammount2),
                account.PrintStatement()
            );

           _output.WriteLine(account.PrintStatement());
        }

        private static string StatementLine(DateTime date, int ammount, int balance)
        {
            return $"{date.ToString(DateTimeFormat)}\t\t{ammount.ToStringWithSign()}\t\t{balance}";
        }
    }
}
