namespace Chainblock.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Transaction : ITransaction
    {
        public Transaction(int id, TransactionStatus status, string from, string to, double amount)
        {
            this.Id = id;
            this.Status = status;
            this.From = from;
            this.To = to;
            this.Amount = amount;
        }

        public int Id { get; set; }

        public TransactionStatus Status { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public double Amount { get; set; }

        public int CompareTo(ITransaction other)
        {
            if (this.Id == other.Id
                && this.Status == other.Status
                && this.From == other.From
                && this.To == other.To
                && this.Amount == other.Amount)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
