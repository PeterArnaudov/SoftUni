namespace StorageMasterStructureTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StorageMaster.Entities.Products;
    using StorageMaster.Entities.Vehicles;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void VehicleClassShouldBeAbstract()
        {
            //Assert
            Assert.IsTrue(typeof(Vehicle).IsAbstract, "Vehicle class isn't abstract.");
        }

        [TestMethod]
        public void VehicleShouldHavePrivateListOfProducts()
        {
            //Arrange
            var fields = typeof(Vehicle).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            var list = fields.First();

            //Assert
            Assert.AreEqual(list.FieldType, typeof(List<Product>));
        }

        [TestMethod]
        public void VehicleShouldHaveCapacityProperty()
        {
            //Arrange
            var properties = typeof(Vehicle).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "Capacity"));
        }

        [TestMethod]
        public void VehicleCapacityPropertyShouldReturnInt()
        {
            //Arrange
            var properties = typeof(Vehicle).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var capacityProperty = properties.First(p => p.Name == "Capacity");

            //Assert
            Assert.IsTrue(capacityProperty.PropertyType == typeof(int));
        }

        [TestMethod]
        public void VehicleShouldHaveTrunkProperty()
        {
            //Arrange
            var properties = typeof(Vehicle).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "Trunk"));
        }

        [TestMethod]
        public void VehicleTrunkPropertyShouldReturnIReadOnlyCollectionOfProducts()
        {
            //Arrange
            var properties = typeof(Vehicle).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var trunkProperty = properties.First(p => p.Name == "Trunk");

            //Assert
            Assert.IsTrue(trunkProperty.PropertyType == typeof(IReadOnlyCollection<Product>));
        }

        [TestMethod]
        public void VehicleShouldHaveIsFullProperty()
        {
            //Arrange
            var properties = typeof(Vehicle).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "IsFull"));
        }

        [TestMethod]
        public void VehicleIsFullPropertyShouldReturnBool()
        {
            //Arrange
            var properties = typeof(Vehicle).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var isFullProperty = properties.First(p => p.Name == "IsFull");

            //Assert
            Assert.IsTrue(isFullProperty.PropertyType == typeof(bool));
        }

        [TestMethod]
        public void VehicleShouldHaveIsEmptyProperty()
        {
            //Arrange
            var properties = typeof(Vehicle).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "IsEmpty"));
        }

        [TestMethod]
        public void VehicleIsEmptyPropertyShouldReturnBool()
        {
            //Arrange
            var properties = typeof(Vehicle).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var isEmptyProperty = properties.First(p => p.Name == "IsEmpty");

            //Assert
            Assert.IsTrue(isEmptyProperty.PropertyType == typeof(bool));
        }

        [TestMethod]
        public void VehicleShouldHaveLoadProductMethod()
        {
            //Arrange
            var methods = typeof(Vehicle).GetMethods(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(methods.Any(m =>   m.Name == "LoadProduct"));
        }

        [TestMethod]
        public void VehicleLoadProductMethodShouldReturnVoid()
        {
            //Arrange
            var methods = typeof(Vehicle).GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var loadProductMethod = methods.First(m => m.Name == "LoadProduct");

            //Assert
            Assert.IsTrue(loadProductMethod.ReturnType == typeof(void));
        }

        [TestMethod]
        public void VehicleShouldHaveUnloadMethod()
        {
            //Arrange
            var methods = typeof(Vehicle).GetMethods(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(methods.Any(m => m.Name == "Unload"));
        }

        [TestMethod]
        public void VehicleUnloadMethodShouldReturnProduct()
        {
            //Arrange
            var methods = typeof(Vehicle).GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var unloadMethod = methods.First(m => m.Name == "Unload");

            //Assert
            Assert.IsTrue(unloadMethod.ReturnType == typeof(Product));
        }
    }
}
