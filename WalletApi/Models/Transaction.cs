using System;

namespace WalletApi.Models
{

    public class Transaction
    {
        public Transaction()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string WalletId { get; set; }
        public TransactionType Type { get; set; }
        public long WalletBalance { get; set; }
        public long Amount { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public long Timestamp { get; set; }
    }
    public enum TransactionType
    {
        Deposit,
        Withdrawal,
    }
}