using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApp
{
    public static class Bank
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

        public static IEnumerable<Account> GetAllAccounts(string emailAddress)
        {
            return db.Accounts.Where( a => a.EmailAddress == emailAddress);
        }


        public static void Deposit(int accountNumber, decimal amount)
        {
            var account = db.Accounts.SingleOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                throw new ArgumentException("accountNumber", "Invalid account number!");
            }
            account.Deposit(amount);

            var transaction = new Transaction
            {
                Descrition = "Bank Deposit",
                TransactionDate = DateTime.Now,
                TypeOfTransaction = TransactionType.Credit,
                Amount = amount,
                AccountNumber = accountNumber

            };
            db.Transactions.Add(transaction);

            db.SaveChanges();
        }
        public static void Withdraw(int accountNumber, decimal amount)
        {
            var account = db.Accounts.SingleOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                throw new ArgumentException("Invalid account number!", nameof(accountNumber));
            }
            account.Withdraw(amount);

            var transaction = new Transaction
            {
                Descrition = "Bank Withdrawl",
                TransactionDate = DateTime.Now,
                TypeOfTransaction = TransactionType.Debit,
                Amount = amount,
                AccountNumber = accountNumber

            };
            db.Transactions.Add(transaction);

            db.SaveChanges();
        }

        public static IEnumerable<Transaction> GetAllTransactions(int accountNumber)
        {
            return db.Transactions.Where(t => t.AccountNumber == accountNumber).OrderByDescending(t => t.TransactionDate);
        }

        public static Account GetAccountDetails(int accountNumber)
        {
            return db.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
        }

        public static void EditAccount(Account account)
        {
            var oldAccount = Bank.GetAccountDetails(account.AccountNumber);
            oldAccount.EmailAddress = account.EmailAddress;
            oldAccount.AccountType = account.AccountType;
            db.Update(oldAccount);
            db.SaveChanges();
        }

        public static void DeleteAccount(int accountNumber)
        {
            var account = Bank.GetAccountDetails(accountNumber);
            db.Accounts.Remove(account);
            db.SaveChanges();
        }

        public static bool AccountExists(int id)
        {
            return db.Accounts.Any(e => e.AccountNumber == id);
        }

    }
}
