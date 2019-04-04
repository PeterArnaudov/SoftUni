namespace Chainblock.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit.Framework;
    using Chainblock;
    using Chainblock.Models;
    using Chainblock.Contracts;
    using System.Linq;

    [TestFixture]
    public class ChainblockTests
    {
        private Blockchain blockchain;

        [SetUp]
        public void AddMethodShouldIncreaseCount()
        {
            this.blockchain = new Blockchain();
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            this.blockchain.Add(transaction);

            Assert.AreEqual(1, this.blockchain.Count);
        }

        [Test]
        public void AddMethodShouldThrowExceptionIfSameId()
        {
            ITransaction transactionTwo = new Transaction(1, TransactionStatus.Unauthorized, "Gosho", "Pesho", 100);

            Assert.Throws<ArgumentException>(() => this.blockchain.Add(transactionTwo));
        }

        [Test]
        public void AddMethodShouldThrowExceptionWhenTransactionIsNull()
        {
            ITransaction transaction = null;

            Assert.Throws<ArgumentException>(() => this.blockchain.Add(transaction));
        }

        [Test]
        public void ContainsMethodShouldReturnTrueIfTransactionIsContained()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);

            Assert.IsTrue(this.blockchain.Contains(transaction));
        }

        [Test]
        public void ContainsMethodShouldReturnFalseIfTransactionIsNotContained()
        {
            ITransaction transaction = new Transaction(3, TransactionStatus.Unauthorized, "Gosho", "Pesho", 100);

            Assert.IsFalse(this.blockchain.Contains(transaction));
        }

        [Test]
        public void ContainsMethodByIdShouldReturnTrueIfTransactionIsContained()
        {
            int id = 1;

            Assert.IsTrue(this.blockchain.Contains(id));
        }

        [Test]
        public void ContainsMethodByIdShouldReturnFalseIfTransactionIsNotContained()
        {
            int id = 3;

            Assert.IsFalse(this.blockchain.Contains(id));
        }

        [Test]
        public void CountPropertyShouldReturnCountCorrectly()
        {
            ITransaction transaction = new Transaction(3, TransactionStatus.Unauthorized, "Gosho", "Pesho", 100);
            this.blockchain.Add(transaction);

            Assert.AreEqual(2, this.blockchain.Count);
        }

        [Test]
        public void ChangeTransactionStatusShouldChangeTransactionStatus()
        {
            ITransaction transaction = new Transaction(2, TransactionStatus.Unauthorized, "Maria", "Ralica", 100);
            this.blockchain.Add(transaction);
            this.blockchain.ChangeTransactionStatus(2, TransactionStatus.Successfull);

            Assert.AreEqual(TransactionStatus.Successfull, this.blockchain.GetById(2).Status);
        }

        [Test]
        public void ChangeTransactionStatusShouldThrowExceptionIfInvalidId()
        {
            Assert.Throws<ArgumentException>(() => this.blockchain.ChangeTransactionStatus(5, TransactionStatus.Failed));
        }

        [Test]
        public void RemoveTransactionByIdShouldRemoveTransaction()
        {
            this.blockchain.RemoveTransactionById(1);

            Assert.AreEqual(0, this.blockchain.Count);
        }

        [Test]
        public void RemoveTransactionByIdShouldThrowExceptionIfWrongId()
        {
            Assert.Throws<InvalidOperationException>(() => this.blockchain.RemoveTransactionById(3));
        }

        [Test]
        public void GetByIdMethodShouldReturnCorrectTransaction()
        {
            ITransaction expectedTransaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);

            Assert.IsTrue(expectedTransaction.CompareTo(this.blockchain.GetById(1)) == 1);
        }

        [Test]
        public void GetByIdMethodShouldThrowExceptionIfWrongId()
        {
            Assert.Throws<InvalidOperationException>(() => this.blockchain.GetById(3));
        }

        [Test]
        public void GetByTransactionStatusMethodShouldReturnCorrectTransactions()
        {
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Aborted, "Maria", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Aborted, "Ralica", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Unauthorized, "Maria", "Ralica", 100);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);

            IEnumerable<ITransaction> expected = new List<ITransaction>
            {
                transactionTwo, transactionOne
            };

            Assert.AreEqual(expected, this.blockchain.GetByTransactionStatus(TransactionStatus.Aborted));
        }

        [Test]
        public void GetByTransactionStatusMethodShouldThrowExceptionWhenNothingFound()
        {
            Assert.Throws<InvalidOperationException>(() => this.blockchain.GetByTransactionStatus(TransactionStatus.Unauthorized));
        }

        [Test]
        public void GetAllSendersWithTransactionStatusMethodShouldReturnCorrectSenders()
        {
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 50);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);

            IEnumerable<string> expected = new List<string>()
            {
                "Svetlio", "Svetlio", "Pesho"
            };

            Assert.AreEqual(expected, this.blockchain.GetAllSendersWithTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void GetAllSendersWithTransactionStatusMethodShouldThrowExceptionIfNoMatch()
        {
            Assert.Throws<InvalidOperationException>(() => this.blockchain.GetAllSendersWithTransactionStatus(TransactionStatus.Failed));
        }

        [Test]
        public void GetAllReceiversWithTransactionStatusMethodShouldReturnCorrectReceiver()
        {
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 50);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);

            IEnumerable<string> expected = new List<string>()
            {
                "Pesho", "Pesho", "Gosho"
            };

            Assert.AreEqual(expected, this.blockchain.GetAllReceiversWithTransactionStatus(TransactionStatus.Successfull));
        }

        [Test]
        public void GetAllReceiversWithTransactionStatusMethodShouldThrowExceptionIfNoMatch()
        {
            Assert.Throws<InvalidOperationException>(() => this.blockchain.GetAllReceiversWithTransactionStatus(TransactionStatus.Failed));
        }

        [Test]
        public void GetAllOrderedByAmountDescendingThenByIdMethodShouldReturnOrderedTransactions()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            List<ITransaction> expected = new List<ITransaction>()
            {
                transaction, transactionThree, transactionFour, transactionTwo, transactionOne
            };

            List<ITransaction> actual = this.blockchain.GetAllOrderedByAmountDescendingThenById().ToList();

            for (int i = 0; i < expected.Count(); i++)
            {
                Assert.IsTrue(actual[i].CompareTo(expected[i]) == 1);
            }
        }

        [Test]
        public void GetBySenderOrderedByAmountDescendingMethodShouldReturnOrderedTransaction()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            IEnumerable<ITransaction> expected = new List<ITransaction>()
            {
                transactionThree, transactionTwo, transactionOne
            };

            Assert.AreEqual(expected, this.blockchain.GetBySenderOrderedByAmountDescending("Svetlio"));
        }

        [Test]
        public void GetByReceiverOrderedByAmountDescendingThenByIdMethodShouldReturnOrderedTransactions()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            IEnumerable<ITransaction> expected = new List<ITransaction>()
            {
                transactionThree, transactionTwo, transactionOne
            };

            Assert.AreEqual(expected, this.blockchain.GetByReceiverOrderedByAmountDescendingThenById("Pesho"));
        }

        [Test]
        public void GetByTransactionStatusAndMaximumAmountMethodShouldReturnOrderedTransactions()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            List<ITransaction> expected = new List<ITransaction>()
            {
                transaction, transactionTwo, transactionOne
            };

            List<ITransaction> actual = this.blockchain.GetByTransactionStatusAndMaximumAmount(TransactionStatus.Successfull, 100).ToList();

            for (int i = 0; i < expected.Count(); i++)
            {
                Assert.IsTrue(actual[i].CompareTo(expected[i]) == 1);
            }
        }

        [Test]
        public void GetByTransactionStatusAndMaximumAmountMethodShouldReturnEmptyCollectionIfNoSuchTransactions()
        {
            Assert.AreEqual(0, this.blockchain.GetByTransactionStatusAndMaximumAmount(TransactionStatus.Aborted, 100).Count());
        }

        [Test]
        public void GetBySenderAndMinimumAmountDescendingShouldReturnOrderedTransactions()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            IEnumerable<ITransaction> expected = new List<ITransaction>()
            {
                transactionThree, transactionTwo
            };

            Assert.AreEqual(expected, this.blockchain.GetBySenderAndMinimumAmountDescending("Svetlio", 25));
        }

        [Test]
        public void GetBySenderAndMinimumAmountDescendingShouldThrowExceptionIfNoSuchTransactions()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            Assert.Throws<InvalidOperationException>(() => this.blockchain.GetBySenderAndMinimumAmountDescending("Svetlio", 200));
        }

        [Test]
        public void GetByReceiverAndAmountRangeShouldReturnCorrectlyOrderedTransactions()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            IEnumerable<ITransaction> expected = new List<ITransaction>()
            {
                transactionThree, transactionTwo
            };

            Assert.AreEqual(expected, this.blockchain.GetByReceiverAndAmountRange("Pesho", 25, 100));
        }

        [Test]
        public void GetByReceiverAndAmountRangeShouldReturnCorrectTransactionsIncludingLowExcludingHigh()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            IEnumerable<ITransaction> expected = new List<ITransaction>()
            {
                transactionTwo, transactionOne
            };

            Assert.AreEqual(expected, this.blockchain.GetByReceiverAndAmountRange("Pesho", 10, 75));
        }

        [Test]
        public void GetByReceiverAndAmountRangeShouldThrowExceptionIfNoSuchTransactions()
        {
            Assert.Throws<InvalidOperationException>(() => this.blockchain.GetByReceiverAndAmountRange("Gosho", 10, 50));
        }

        [Test]
        public void GetAllInAmountRangeShouldReturnCorrectlyOrderedTranscations()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            IEnumerable<ITransaction> expected = new List<ITransaction>()
            {
                transactionOne, transactionTwo
            };
            
            Assert.AreEqual(expected, this.blockchain.GetAllInAmountRange(0, 70));
        }

        [Test]
        public void GetAllInAmountRangeShouldReturnTranscationsIncludedInBoundaries()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            IEnumerable<ITransaction> expected = new List<ITransaction>()
            {
                transactionOne, transactionTwo, transactionThree, transactionFour
            };

            Assert.AreEqual(expected, this.blockchain.GetAllInAmountRange(10, 75));
        }

        [Test]
        public void GetAllInAmountRangeShouldReturnEmptyCollectionWhenNoSuchTransactions()
        {
            ITransaction transaction = new Transaction(1, TransactionStatus.Successfull, "Pesho", "Gosho", 100);
            ITransaction transactionOne = new Transaction(2, TransactionStatus.Successfull, "Svetlio", "Pesho", 10);
            ITransaction transactionTwo = new Transaction(3, TransactionStatus.Successfull, "Svetlio", "Pesho", 50);
            ITransaction transactionThree = new Transaction(4, TransactionStatus.Aborted, "Svetlio", "Pesho", 75);
            ITransaction transactionFour = new Transaction(5, TransactionStatus.Aborted, "Zaharin", "Galio", 75);

            this.blockchain.Add(transactionOne);
            this.blockchain.Add(transactionTwo);
            this.blockchain.Add(transactionThree);
            this.blockchain.Add(transactionFour);

            Assert.AreEqual(0, this.blockchain.GetAllInAmountRange(200, 500).Count());
        }
    }
}
