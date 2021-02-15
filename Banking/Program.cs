using System;

namespace Banking {
    class Program {
        static void Main(string[] args) {


            var acct1 = new Account();
            acct1.AccountNumber = "100";
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Deposit(200);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Withdraw(30);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Withdraw(230);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Deposit(-200);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");
            acct1.Withdraw(-200);
            Console.WriteLine($"Account {acct1.AccountNumber} balance is {acct1.Balance}");

        }
    }
}
