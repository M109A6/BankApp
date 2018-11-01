using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp
{
    enum TransactionType
    {
        Credit,
        Debit
    }
    class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Descrition { get; set; }
        public TransactionType TypeOfTransaction { get; set; }
        public decimal Amount { get; set; }

        [ForeignKey("Account")]
        public int AccountNumber { get; set; }

        public virtual Account Account { get; set; }
    }
}
