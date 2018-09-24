using System;
using Banking;
using Xunit;

namespace BankingTests
{
    public class StatementTests
    {
        [Fact]
        public void NewStatementBalanceIsZero()
        {
            var statement = new Statement();

            Assert.Equal(0, statement.Balance);
        }

        [Fact]
        public void DepositOnce()
        {
            var statement = new Statement();

            statement.Deposit(100);

            Assert.Equal(100, statement.Balance);
        }

        [Fact]
        public void DepositTwice()
        {
            var statement = new Statement();
            var ammount = 100;

            statement.Deposit(ammount);
            statement.Deposit(ammount);

            Assert.Equal(ammount + ammount, statement.Balance);
        }

        [Fact]
        public void Withdraw()
        {
            var statement = new Statement();
            var depositAmmount = 100;
            var withdrwAmmount = 50;

            statement.Deposit(depositAmmount);
            statement.Withdraw(withdrwAmmount);

            Assert.Equal(depositAmmount - withdrwAmmount, statement.Balance);
        }

        [Fact]
        public void WithdrawWhenThereAreInsuficientFounds()
        {
            var statement = new Statement();
            Assert.Throws<Exception>(() => statement.Withdraw(100));
        }
    }
}
