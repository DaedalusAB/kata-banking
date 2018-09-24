using System;
using Banking;
using Xunit;

namespace BankingTests
{
    public class AccountTests
    {
        [Fact]
        public void NewAccountBalanceIsZero()
        {
            var account = new Account();

            Assert.Equal(0, account.Balance);
        }

        [Fact]
        public void DepositIntoAccountOnce()
        {
            var account = new Account();

            account.Deposit(100);

            Assert.Equal(100, account.Balance);
        }

        [Fact]
        public void DepositIntoAccountTwice()
        {
            var account = new Account();
            var ammount = 100;

            account.Deposit(ammount);
            account.Deposit(ammount);

            Assert.Equal(ammount + ammount, account.Balance);
        }

        [Fact]
        public void WithdrawFromAccount()
        {
            var account = new Account();
            var depositAmmount = 100;
            var withdrwAmmount = 50;

            account.Deposit(depositAmmount);
            account.Withdraw(withdrwAmmount);

            Assert.Equal(depositAmmount - withdrwAmmount, account.Balance);
        }

        [Fact]
        public void TryToWithdrawWhenThereAreInsuficientFounds()
        {
            var account = new Account();
            Assert.Throws<Exception>(() => account.Withdraw(100));
        }
    }
}
