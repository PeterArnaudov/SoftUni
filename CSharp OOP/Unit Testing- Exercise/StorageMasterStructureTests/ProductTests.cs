namespace StorageMasterStructureTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StorageMaster.Entities.Products;
    using StorageMaster.Entities.Storage;
    using StorageMaster.Entities.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ProductClassShouldBeAbstract()
        {
            //Assert
            Assert.IsTrue(typeof(Product).IsAbstract);
        }

        [TestMethod]
        public void ProductShouldHaveFieldOfTypeDouble()
        {
            //Arrange
            var fields = typeof(Product).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(fields.Any(f => f.FieldType == typeof(double)));
        }

        [TestMethod]
        public void ProductShouldHavePriceProperty()
        {
            //Arrange
            var properties = typeof(Product).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "Price"));
        }

        [TestMethod]
        public void ProductPricePropertyShouldReturnDouble()
        {
            //Arrange
            var priceProperty = typeof(Product).GetProperties(BindingFlags.Public | BindingFlags.Instance).First(p => p.Name == "Price");

            //Assert
            Assert.IsTrue(priceProperty.PropertyType == typeof(double));
        }

        [TestMethod]
        public void ProductShouldHaveWeightProperty()
        {
            //Arrange
            var properties = typeof(Product).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "Weight"));
        }

        [TestMethod]
        public void ProductWeightPropertyShouldReturnDouble()
        {
            //Arrange
            var weightProperty = typeof(Product).GetProperties(BindingFlags.Public | BindingFlags.Instance).First(p => p.Name == "Price");

            //Assert
            Assert.IsTrue(weightProperty.PropertyType == typeof(double));
        }
    }
}
