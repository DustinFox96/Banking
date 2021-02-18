using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions {

    class InsufficientFundsException : Exception {

        public decimal AccountBalance { get; set; }
        public decimal AmountToWithdraw { get; set; }

        public InsufficientFundsException(decimal balance, decimal amount)
            : base($"Current balance is {balance}, withdraw amount is {amount}") {
            AccountBalance = balance;
            AmountToWithdraw = amount;
        }
        public InsufficientFundsException() 
            : base() { }
        public InsufficientFundsException(string Message)
            : base(Message) { }
        public InsufficientFundsException(string Message, Exception InnerException)
            : base(Message, InnerException) { }
    }
}
