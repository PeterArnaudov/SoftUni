namespace DatabaseTests
{
    using Database;
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DatabaseTests
    {
        private const int DatabaseCapacity = 16;

        private Database db = new Database();

        [TestMethod]
        public void ConstructorShouldThrowExceptionWithMoreThanSixteenIntegers()
        {
            //Arrange
            int[] array = new int[DatabaseCapacity + 1] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            string exceptionMessage = string.Empty;

            //Act
            try
            {
                Database database = new Database(array);
            }
            catch (InvalidOperationException ioe)
            {
                exceptionMessage = ioe.Message;
            }

            //Assert
            string expectedExceptionMessage = "Cannot initialize a Database class with more than 16 elements.";
            Assert.AreEqual(expectedExceptionMessage, exceptionMessage, "Database constructor doesn't throw exception.");
        }

        [TestMethod]
        public void AddMethodShouldThrowExceptionIfDatabaseIsFull()
        {
            //Arrange
            this.AddNumbers(DatabaseCapacity);

            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => this.db.Add(17), "Cannot add more elements.", "Add method doesn't throw exception.");
        }

        [TestMethod]
        public void RemoveMethodShouldThrowExceptionWhenDatabaseIsEmpty()
        {
            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => this.db.Remove(), "Cannot remove elements from an empty Database.", "Remove method doesn't throw exception.");
        }

        [TestMethod]
        public void FetchMethodShouldReturnTheDatabaseAsArrayCorrectly()
        {
            //Arrange
            this.AddNumbers(DatabaseCapacity);

            //Act
            int[] actualResult = this.db.Fetch();

            //Assert
            int[] expcetedResult = new int[DatabaseCapacity] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            for (int i = 0; i < expcetedResult.Length; i++)
            {
                Assert.AreEqual(expcetedResult[i], actualResult[i], "Fetch method doesn't return correctly.");
            }
        }

        private void AddNumbers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                this.db.Add(i);
            }
        }
    }
}
