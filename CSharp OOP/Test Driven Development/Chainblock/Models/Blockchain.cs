namespace Chainblock.Models
{
    using Chainblock.Contracts;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Blockchain : IChainblock
    {
        private List<ITransaction> transactions;

        public Blockchain()
        {
            this.transactions = new List<ITransaction>();
        }

        public int Count => this.transactions.Count;

        public void Add(ITransaction tx)
        {
            if (tx == null)
            {
                throw new ArgumentException("Transaction cannot be null!");
            }
            else if (this.transactions.Any(t => t.Id == tx.Id))
            {
                throw new ArgumentException("Transaction with this ID already exists!");
            }
            else
            {
                this.transactions.Add(tx);
            }
        }

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            ITransaction transaction = this.transactions.FirstOrDefault(t => t.Id == id);

            if (transaction == null)
            {
                throw new ArgumentException($"No transaction with ID ${id}!");
            }
            else
            {
                transaction.Status = newStatus;
            }
        }

        public bool Contains(ITransaction tx)
        {
            if (this.transactions.Any(t => t.CompareTo(tx) == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Contains(int id)
        {
            if (this.transactions.Any(t => t.Id == id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            return this.transactions.Where(t => t.Amount >= lo && t.Amount <= hi).ToList();
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            return this.transactions
                .OrderByDescending(t => t.Amount)
                .ThenBy(t => t.Id)
                .ToList();
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            if (this.transactions.Any(t => t.Status == status))
            {
                List<string> receivers = this.transactions
                    .Where(t => t.Status == status)
                    .Select(t => t.To)
                    .ToList();

                Dictionary<string, int> receivedCount = new Dictionary<string, int>();
                List<string> orderedReceivers = new List<string>();

                foreach (var receiver in receivers)
                {
                    if (!receivedCount.ContainsKey(receiver))
                    {
                        receivedCount.Add(receiver, 0);
                    }

                    receivedCount[receiver]++;
                }

                receivedCount = receivedCount
                    .OrderByDescending(s => s.Value)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                foreach (var receiver in receivedCount)
                {
                    for (int i = 0; i < receiver.Value; i++)
                    {
                        orderedReceivers.Add(receiver.Key);
                    }
                }

                return orderedReceivers;
            }
            else
            {
                throw new InvalidOperationException($"No transactions found with status {status}!");
            }
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            if (this.transactions.Any(t => t.Status == status))
            {
                List<string> senders = this.transactions
                    .Where(t => t.Status == status)
                    .Select(t => t.From)
                    .ToList();

                Dictionary<string, int> sentCount = new Dictionary<string, int>();
                List<string> orderedSenders = new List<string>();

                foreach (var sender in senders)
                {
                    if (!sentCount.ContainsKey(sender))
                    {
                        sentCount.Add(sender, 0);
                    }

                    sentCount[sender]++;
                }

                sentCount = sentCount
                    .OrderByDescending(s => s.Value)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                foreach (var sender in sentCount)
                {
                    for (int i = 0; i < sender.Value; i++)
                    {
                        orderedSenders.Add(sender.Key);
                    }
                }

                return orderedSenders;
            }
            else
            {
                throw new InvalidOperationException($"No transactions found with status {status}!");
            }
        }

        public ITransaction GetById(int id)
        {
            ITransaction transaction = this.transactions.FirstOrDefault(t => t.Id == id);

            if (transaction == null)
            {
                throw new InvalidOperationException($"No transaction with ID {id} found!");
            }
            else
            {
                return transaction;
            }
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            List<ITransaction> transactions = this.transactions
                .Where(t => t.To == receiver && t.Amount >= lo && t.Amount < hi)
                .OrderByDescending(t => t.Amount)
                .ThenBy(t => t.Id)
                .ToList();

            if (transactions.Count == 0)
            {
                throw new InvalidOperationException("There are no such transactions!");
            }
            else
            {
                return transactions;
            }
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountDescendingThenById(string receiver)
        {
            List<ITransaction> transactions = this.transactions
                .Where(t => t.To == receiver)
                .OrderByDescending(t => t.Amount)
                .ThenBy(t => t.Id)
                .ToList();

            if (transactions.Count == 0)
            {
                throw new InvalidOperationException("There are no such transactions!");
            }
            else
            {
                return transactions;
            }
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            List<ITransaction> transactions = this.transactions
                .Where(t => t.From == sender && t.Amount > amount)
                .OrderByDescending(t => t.Amount)
                .ToList();

            if (transactions.Count == 0)
            {
                throw new InvalidOperationException("There are no such transactions!");
            }
            else
            {
                return transactions;
            }
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            List<ITransaction> transactions = this.transactions
                .Where(t => t.From == sender)
                .OrderByDescending(t => t.Amount)
                .ToList();

            if (transactions.Count == 0)
            {
                throw new InvalidOperationException("There are no such transactions!");
            }
            else
            {
                return transactions;
            }
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            List<ITransaction> transactions = this.transactions
                .Where(t => t.Status == status)
                .OrderByDescending(t => t.Amount)
                .ToList();

            if (transactions.Count == 0)
            {
                throw new InvalidOperationException("There are no such transactions!");
            }
            else
            {
                return transactions;
            }
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            List<ITransaction> transactions = this.transactions
                .Where(t => t.Status == status && t.Amount <= amount)
                .OrderByDescending(t => t.Amount)
                .ToList();

            return transactions;
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            foreach (var transaction in this.transactions)
            {
                yield return transaction;
            }
        }

        public void RemoveTransactionById(int id)
        {
            ITransaction transaction = this.transactions.FirstOrDefault(t => t.Id == id);

            if (transaction == null)
            {
                throw new InvalidOperationException($"Transaction with ID {id} doesn't exist!");
            }

            this.transactions.Remove(transaction);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
