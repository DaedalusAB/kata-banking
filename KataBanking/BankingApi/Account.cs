using Banking;

namespace BankingApi
{
    public class Account
    {
        private Statement Statement { get; }
        private StatementPrinter Printer { get; }

        public Account(Statement statement, StatementPrinter printer)
        {
            Statement = statement;
            Printer = printer;
        }

        public void Deposit(int amount)
        {
            Statement.Deposit(amount);
        }

        public void Withdraw(int amount)
        {
            Statement.Withdraw(amount);
        }

        public string PrintStatement()
        {
            return Printer.Print(Statement);
        }
    }
}
