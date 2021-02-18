using System;
using System.Collections.Generic;
using System.Text;

namespace Banking {
    class SavingsI : Account {

        public SavingsI() : base() { }

        public SavingsI(string AcctNbr, string Desc) : base(AcctNbr, Desc) {

        }

        public decimal interestRate { get; set; } = 0.12m;

        // // this was extra and was not needed
        //public decimal Interest(int months) {
        //    return Balance * (interestRate / 12) * months;
        //}

        public void payInterest(int months) {
            var interest = Balance * (interestRate / 12) * months;
            Deposit(interest);
        }


        public SavingsI(string AcctNbr, decimal IntRate) : base(AcctNbr, "New Savings Account") {
            this.interestRate = IntRate;
        
        }


    }
    
}
