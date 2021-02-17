using System;
using System.Collections.Generic;
using System.Text;
// class made using compostion take better notes on this with becca 
namespace Banking {
    class Savings {
        public decimal InterestRate { get; set; } = 0.012m;  //I = B * (IR/12) * n

        private decimal Interest(int months) { // this method could also be set to private once everything is set up and done, have becca explain this.
            return account.Balance * (InterestRate / 12) * months;
        }
        public void payInterest(int months) {
            var interest = Interest(months);
            Deposit(interest);
        }

        public Account account { get; set; }

        public decimal Balance {
            get { return account.Balance; }
        }

        public void Deposit(decimal amount) {
            account.Deposit(amount);
        }

        public void Withdraw(decimal amount) {
            account.Withdraw(amount);
        }

        public Savings() {
            this.account = new Account("4", "Savings Account");
        }




    }
}





