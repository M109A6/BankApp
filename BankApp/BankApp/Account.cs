using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{   

    enum TypeOfAccount
    {
        Savings,
        Checking,
        CD,
        Loan
    }

    /// <summary>
    /// Defines an account for a bank.
    /// </summary>
    class Account
    {
        private static int lastAccountNumber = 0;

        #region Properties
        /// <summary>
        /// Account number of the account
        /// </summary>
        public int AccountNumber { get; }
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }
        public TypeOfAccount AccountType { get; set; }
        public DateTime CreatedDate { get;  }
        #endregion

        #region Constructors

        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }

        #endregion

        /// <summary>
        /// Deposit money into my account.
        /// </summary>
        /// <param name="amount"></param>
        #region Methods

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
       
        }
        #endregion
    }
}
