namespace DatabaseExtendedTests
{
    using DatabaseExtended;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class DatabaseTests
    {
        private const long ValidId = 123;
        private const long InvalidId = -5;
        private const string ValidUsername = "Username";
        private const string InvalidUsername = "";

        private Database db = new Database();

        [TestInitialize]
        public void AddMethodShouldAddPerson()
        {
            //Act
            this.db.Add(ValidId, ValidUsername);

            //Assert
            int expectedCount = 1;
            Assert.AreEqual(expectedCount, this.db.People.Count, "Add method doesn't add enitity.");
        }

        [TestMethod]
        public void AddMethodShouldThrowExceptionIfPersonAvailableWithTheSameId()
        {
            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => this.db.Add(ValidId, ValidUsername + ValidUsername), "Person with the same ID exists.", "Add method doesn't throw exception.");
        }

        [TestMethod]
        public void AddMethodShouldThrowExceptionIfPersonAvailableWithTheSameUsername()
        {
            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => this.db.Add(ValidId + ValidId, ValidUsername), "Person with the same ID exists.", "Add method doesn't throw exception.");
        }

        [TestMethod]
        public void RemoveMethodShouldRemovePersonWithGivenId()
        {
            //Act
            this.db.Remove(ValidId);

            //Assert
            int expectedCount = 0;
            Assert.AreEqual(expectedCount, this.db.People.Count, "Remove method doesn't remove entities.");
        }

        [TestMethod]
        public void RemoveMethodShouldRemovePersonWithGivenUsername()
        {
            //Act
            this.db.Remove(ValidUsername);

            //Assert
            int expectedCount = 0;
            Assert.AreEqual(expectedCount, this.db.People.Count, "Remove method doesn't remove entities.");
        }

        [TestMethod]
        public void RemoveMethodShouldThrowExceptionWhenPersonWithGivenIdIsNotFound()
        {
            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => this.db.Remove(ValidId + ValidId), "Person with this ID doesn't exist.", "Remove method doesn't throw exception.");
        }

        [TestMethod]
        public void RemoveMethodShouldThrowExceptionWhenPersonWithGivenUsernameIsNotFound()
        {
            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => this.db.Remove(ValidUsername + ValidUsername), "Person with this username doesn't exist.", "Remove method doesn't throw exception.");
        }

        [TestMethod]
        public void FindByIdMethodShouldReturnPerson()
        {
            Person expectedPerson = new Person(ValidId, ValidUsername);

            //Act
            Person actualPerson = this.db.FindById(ValidId);

            //Assert
            Assert.IsTrue(expectedPerson.Id == actualPerson.Id && expectedPerson.Username == actualPerson.Username, "FindById method doesn't return enity.");
        }

        [TestMethod]
        public void FindByIdMethodShouldThrowExceptionWithInvalidId()
        {
            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => this.db.FindById(InvalidId), "ID cannot be negative or 0.", "FindById method doesn't throw exception.");
        }

        [TestMethod]
        public void FindByIdMethodShouldThrowExceptionWhenNoSuchPersonFound()
        {
            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => this.db.FindById(ValidId + ValidId), "Person with this ID doesn't exist.", "FindById method doesn't throw exception.");
        }

        [TestMethod]
        public void FindByUsernameMethodShouldReturnPerson()
        {
            //Arrange
            Person expectedPerson = new Person(ValidId, ValidUsername);

            //Act
            Person actualPerson = this.db.FindByUsername(ValidUsername);

            //Assert
            Assert.IsTrue(expectedPerson.Id == actualPerson.Id && expectedPerson.Username == actualPerson.Username, "FindById method doesn't return enity.");
        }

        [TestMethod]
        public void FindByUsernameMethodShouldThrowExceptionWithInvalidUsername()
        {
            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => this.db.FindByUsername(InvalidUsername), "Username cannot be null or empty.", "FindByUsername method doesn't throw exception.");
        }

        [TestMethod]
        public void FindByUsernameMethodShouldThrowExceptionWhenNoSuchPersonFound()
        {
            //Act & Assert
            Assert.ThrowsException<InvalidOperationException>(() => this.db.FindByUsername(ValidUsername + ValidUsername), "Person with this username doesn't exist.", "FindByUsername method doesn't throw exception.");
        }
    }
}
