using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp
{
    static class Bank
    {
        private static BankModel db = new BankModel();
        /// <summary>
        /// Create an account in the back
        /// </summary>
        /// <param name="emailAddress">Email Address associated to the account.</param>
        /// <param name="accountType">Type of account.</param>
        /// <param name="initialAmount">Initial amount deposited into the account.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException" />
        public static Account CreateAccount(string emailAddress, TypeOfAccount accountType = TypeOfAccount.Checking, decimal initialAmount=0)
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                throw new ArgumentNullException(nameof(emailAddress), "Email address is required!");
            }

            var account = new Account
            {
                EmailAddress = emailAddress,
                AccountType = accountType
            };

            if(initialAmount > 0)
            {
                account.Deposit(initialAmount);
            }
            db.Accounts.Add(account);
            db.SaveChanges();
            return account;
        }

        public static IEnumerable<Account> GetAllAccounts()
        {
            return db.Accounts;
        }


        public static void Deposit(int accountNumber, decimal amount)
        {
            var account = db.Accounts.SingleOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                throw new ArgumentException("accountNumber", "Invalid account number!");
            }
            account.Deposit(amount);
        }
        public static void Withdraw(int accountNumber, decimal amount)
        {
            var account = db.Accounts.SingleOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                throw new ArgumentException("Invalid account number!", nameof(accountNumber));
            }
            account.Withdraw(amount);
        }
    }
}
