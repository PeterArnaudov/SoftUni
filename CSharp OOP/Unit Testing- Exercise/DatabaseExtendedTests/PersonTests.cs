namespace DatabaseExtendedTests
{
    using DatabaseExtended;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void IdPropertyShouldThrowExceptionWithNegativeId()
        {
            //Arrange
            const long Id = -5;
            const string Username = "Username";

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Person(Id, Username), "ID cannot be negative or 0.", "Constructor Id property validation doesn't throw exception.");
        }

        [TestMethod]
        public void UsernamePropertyShouldThrowExceptionWithEmptyUsername()
        {
            //Arrange
            const long Id = 5;
            const string Username = "";

            //Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Person(Id, Username), "Username cannot be null or empty.", "Constructor Username property validation doesn't throw exception.");
        }
    }
}
