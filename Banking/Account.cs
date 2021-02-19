using System;
using System.Collections.Generic;
using System.Text;
using Banking.Exceptions;
namespace Banking {

    class Account {
        public string AccountNumber { get; private set; }
        //public string RoutingNumber { get; set; }
        public string Description { get; set; }
        //public string AccountType { get; set; }
        public decimal Balance { get; private set; } = 0;

        public void Deposit(decimal amount) {
            if (amount <= 0) {
                throw new AmountMustBePositiveException("Amount less then zero");
            }

                Balance += amount;
            }
        public void Withdraw(decimal amount) {
            if(amount < 0) {
                return;
            }
            if (Balance >= amount) {
                Balance -= amount;


            } else {
                throw new InsufficientFundsException(Balance, amount);
            }
        }
        //new changes added here that helps improve the program class
        public Account() : this("DefActt0", "Default Account Description") { } // this will call a different contructors within the class
       
        public Account(string acctNbr, string desc = "New Account") {
            AccountNumber = acctNbr;
            Description = desc;
        }

    }
    
}
