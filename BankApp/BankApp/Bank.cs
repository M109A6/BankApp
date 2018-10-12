using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp
{
    static class Bank
    {
        private static List<Account> accounts = new List<Account>();
        /// <summary>
        /// Create an account in the back
        /// </summary>
        /// <param name="emailAddress">Email Address associasted to the account.</param>
        /// <param name="accountType">Type of account.</param>
        /// <param name="initialAmount">Initial amount deposited into the account.</param>
        /// <returns></returns>
        public static Account CreateAccount(string emailAddress, TypeOfAccount accountType = TypeOfAccount.Checking, decimal initialAmount=0)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                AccountType = accountType
            };

            if(initialAmount > 0)
            {
                account.Deposit(initialAmount);
            }
            accounts.Add(account);
            return account;
        }

        public static IEnumerable<Account> GetAllAccounts()
        {
            return accounts;
        }


        public static void Deposit(int accountNumber, decimal amount)
        {
            accounts.SingleOrDefault(a => a.AccountNumber == accountNumber);
        }
    }
}
