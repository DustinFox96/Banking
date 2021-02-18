using Banking.Exceptions;
using System;

namespace Banking {
    class Program {
        static void Main(string[] args) {

            //var sav1 = new Savings();
            var sav1 = new SavingsI();
            sav1.Deposit(50);
            sav1.Withdraw(20);
            try {
                //sav1.Withdraw(50);
                sav1.Deposit(-10);
                sav1.Withdraw(-10);
            } catch (AmountMustBePositiveException ambpex) { 
                Console.WriteLine(ambpex.Message);
            

            } catch (InsufficientFundsException ifex) {
                Console.WriteLine(ifex.Message);
                return;
            }
            sav1.Deposit(70);
            Console.WriteLine($"savings balance is {sav1.Balance}");
            sav1.payInterest(3);
            Console.WriteLine($"savings balance is {sav1.Balance}");



            /*
            var acct1 = new Account("Acct101, Dustin's Account");
            //acct1.AccountNumber = "100"; // we no longer need this line due to the changes we made on the Account class.
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
            */

        }
    }
}
