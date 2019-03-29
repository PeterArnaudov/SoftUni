namespace CustomLinkedListTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CustomLinkedList;
    using System;

    [TestClass]
    public class CustomLinkedListTests
    {
        private DynamicList<int> linkedList;

        [TestInitialize]
        [TestMethod]
        public void AddMethodShouldAddEntity()
        {
            //Arrange
            linkedList = new DynamicList<int>();

            //Act
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);

            //Assert
            int expectedCount = 3;
            Assert.AreEqual(expectedCount, this.linkedList.Count, "Add method doesn't add entity.");
        }

        [TestMethod]
        public void CountPropertyShouldReturnTheCountOfEntities()
        {
            //Act
            int actualCount = this.linkedList.Count;

            //Assert
            int expectedCount = 3;
            Assert.AreEqual(expectedCount, this.linkedList.Count, "Add method doesn't add entity.");
        }

        [TestMethod]
        public void AccessingValidIndexShouldReturnEntityValueCorrectly()
        {
            //Act
            int expectedValue = 4;
            this.linkedList.Add(expectedValue);
            int actualValue = linkedList[this.linkedList.Count - 1];

            //Assert
            Assert.AreEqual(expectedValue, actualValue, "Accessing index doesn't return value correctly.");
        }

        [TestMethod]
        public void AccessingInvalidIndexShouldThrowException()
        {
            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => this.linkedList[this.linkedList.Count], "Invalid index: " + this.linkedList.Count, "Invalid indexes are accessible.");
        }

        [TestMethod]
        public void SettingValueAtValidIndexShouldBePossible()
        {
            //Act
            int expectedValue = 0;
            this.linkedList[this.linkedList.Count - 1] = expectedValue;

            //Assert
            Assert.AreEqual(expectedValue, this.linkedList[this.linkedList.Count - 1], "Setting value at valid index isn't correct.");
        }

        [TestMethod]
        public void SettingValueAtInvalidIndexShouldThrowException()
        {
            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => this.linkedList[this.linkedList.Count] = 5, "Invalid index: " + this.linkedList.Count, "Invalid indexes are accessible.");
        }

        [TestMethod]
        public void RemoveAtMethodShouldThrowExceptionWhenAccessingInvalidIndex()
        {
            //Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => this.linkedList.RemoveAt(this.linkedList.Count), "Invalid index: " + this.linkedList.Count, "Invalid indexes are accessible.");
        }

        [TestMethod]
        public void RemoveAtMethodShouldRemoveEntityCorrectly()
        {
            //Arrange
            DynamicList<int> original = this.linkedList;

            //Act
            this.linkedList.RemoveAt(this.linkedList.Count - 1);

            //Assert
            for (int i = 0; i < this.linkedList.Count - 1; i++)
            {
                Assert.AreEqual(original[i], this.linkedList[i], "RemoveAt doesn't remove entity correctly.");
            }
        }

        [TestMethod]
        public void RemoveAtMethodShouldReturnEntityCorrectly()
        {
            //Arrange
            int expected = this.linkedList[0];

            //Act
            int actual = this.linkedList.RemoveAt(0);

            //Assert
            Assert.AreEqual(expected, actual, "RemoveAt doesn't return entity correctly.");
        }

        [TestMethod]
        public void RemoveMethodShouldDecreaseCount()
        {
            //Arrange
            int expectedCount = this.linkedList.Count - 1;
            int element = this.linkedList[1];

            //Act
            this.linkedList.Remove(element);

            //Assert
            Assert.AreEqual(expectedCount, this.linkedList.Count, "Remove doesn't decrease count.");
        }

        [TestMethod]
        public void RemoveMethodShouldShiftEntities()
        {
            //Arrange
            int element = this.linkedList[1];
            int expectedNextElement = this.linkedList[2];

            //Act
            this.linkedList.Remove(element);

            //Assert
            Assert.AreEqual(expectedNextElement, this.linkedList[1], "Remove doesn't shift entities.");
        }

        [TestMethod]
        public void RemoveMethodReturnsIndexCorrectly()
        {
            //Arrange
            int index = 1;
            int element = this.linkedList[index];

            //Act
            int actual = this.linkedList.Remove(element);

            //Assert
            Assert.AreEqual(index, actual, "Remove doesn't return element's index correctly.");
        }

        [TestMethod]
        public void RemoveMethodReturnsCorrectValueWhenNoEntityFound()
        {
            //Act
            int notExistingElement = 5;
            int actual = this.linkedList.Remove(notExistingElement);

            //Assert
            int expected = -1;
            Assert.AreEqual(expected, actual, "Remove doesn't return correct value when no element is found.");
        }

        [TestMethod]
        public void IndexOfMethodShouldReturnCorrectIndexOfElement()
        {
            //Act
            int index = 1;
            int element = this.linkedList[index];
            int actual = this.linkedList.IndexOf(element);

            //Assert
            Assert.AreEqual(index, actual, "IndexOf doesn't return index correctly.");
        }

        [TestMethod]
        public void IndexOfMethodReturnsCorrectValueWhenElementNotFound()
        {
            //Act
            int notExistingElement = 5;
            int actual = this.linkedList.IndexOf(notExistingElement);

            //Assert
            int expected = -1;
            Assert.AreEqual(expected, actual, "IndexOf doesn't return correct value when no element is found.");
        }

        [TestMethod]
        public void ContainsMethodShouldReturnTrueWhenElementIsFound()
        {
            //Arrange
            int existingElement = this.linkedList[0];

            //Act
            bool actual = this.linkedList.Contains(existingElement);

            //Assert
            Assert.AreEqual(true, actual, "Contains doesn't return correct value.");
        }

        [TestMethod]
        public void ContainsMethodShouldReturnFalseWhenElementIsNotFound()
        {
            //Arrange
            int notExistingElement = 5;

            //Act
            bool actual = this.linkedList.Contains(notExistingElement);

            //Assert
            Assert.AreEqual(false, actual, "Contains doesn't return correct value.");
        }
    }
}
