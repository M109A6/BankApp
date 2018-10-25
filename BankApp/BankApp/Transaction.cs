using System;
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
    }
}
