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
    public class StorageTests
    {
        [TestMethod]
        public void StorageClassShouldBeAbstract()
        {
            //Assert
            Assert.IsTrue(typeof(Storage).IsAbstract, "Storage class isn't abstract.");
        }

        [TestMethod]
        public void StorageShouldHaveFieldWithVehicleArray()
        {
            //Arrange
            var fields = typeof(Storage).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(fields.Any(f => f.FieldType == typeof(Vehicle[])));
        }

        [TestMethod]
        public void StorageShouldHaveFieldWithListOfProduct()
        {
            //Arrange
            var fields = typeof(Storage).GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(fields.Any(f => f.FieldType == typeof(List<Product>)));
        }

        [TestMethod]
        public void StorageShouldHaveNameProperty()
        {
            //Arrange
            var properties = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "Name"));
        }

        [TestMethod]
        public void StorageNamePropertyShouldReturnString()
        {
            //Arrange
            var nameProperty = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance).First(p => p.Name == "Name");

            //Assert
            Assert.IsTrue(nameProperty.PropertyType == typeof(string));
        }

        [TestMethod]
        public void StorageShouldHaveCapacityProperty()
        {
            //Arrange
            var properties = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "Capacity"));
        }

        [TestMethod]
        public void StorageCapacityPropertyShouldReturnInt()
        {
            //Arrange
            var capacityProperty = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance).First(p => p.Name == "Capacity");

            //Assert
            Assert.IsTrue(capacityProperty.PropertyType == typeof(int));
        }

        [TestMethod]
        public void StorageShouldHaveGarageSlotsProperty()
        {
            //Arrange
            var properties = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "GarageSlots"));
        }

        [TestMethod]
        public void StorageGarageSlotsPropertyShouldReturnInt()
        {
            //Arrange
            var garageSlotsProperty = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance).First(p => p.Name == "GarageSlots");

            //Assert
            Assert.IsTrue(garageSlotsProperty.PropertyType == typeof(int));
        }

        [TestMethod]
        public void StorageShouldHaveIsFullProperty()
        {
            //Arrange
            var properties = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "IsFull"));
        }

        [TestMethod]
        public void StorageIsFullPropertyShouldReturnBool()
        {
            //Arrange
            var isFullProperty = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance).First(p => p.Name == "IsFull");

            //Assert
            Assert.IsTrue(isFullProperty.PropertyType == typeof(bool));
        }

        [TestMethod]
        public void StorageShouldHaveGarageProperty()
        {
            //Arrange
            var properties = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "Garage"));
        }

        [TestMethod]
        public void StorageGaragePropertyShouldReturnIReadOnlyCollectionOfVehicle()
        {
            //Arrange
            var garageProperty = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance).First(p => p.Name == "Garage");

            //Assert
            Assert.IsTrue(garageProperty.PropertyType == typeof(IReadOnlyCollection<Vehicle>));
        }

        [TestMethod]
        public void StorageShouldHaveProductsProperty()
        {
            //Arrange
            var properties = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(properties.Any(p => p.Name == "Products"));
        }

        [TestMethod]
        public void StorageProductsPropertyShouldReturnIReadOnlyCollectionOfProduct()
        {
            //Arrange
            var productsProperty = typeof(Storage).GetProperties(BindingFlags.Public | BindingFlags.Instance).First(p => p.Name == "Products");

            //Assert
            Assert.IsTrue(productsProperty.PropertyType == typeof(IReadOnlyCollection<Product>));
        }

        [TestMethod]
        public void StorageShouldHaveGetVehicleMethod()
        {
            //Arrange
            var methods = typeof(Storage).GetMethods(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(methods.Any(m => m.Name == "GetVehicle"));
        }

        [TestMethod]
        public void StorageGetVehicleMethodShouldReturnVehicle()
        {
            //Arrange
            var getVehicleMethod = typeof(Storage).GetMethods(BindingFlags.Public | BindingFlags.Instance).First(m => m.Name == "GetVehicle");

            //Assert
            Assert.IsTrue(getVehicleMethod.ReturnType == typeof(Vehicle));
        }

        [TestMethod]
        public void StorageShouldHaveSendVehicleToMethod()
        {
            //Arrange
            var methods = typeof(Storage).GetMethods(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(methods.Any(m => m.Name == "SendVehicleTo"));
        }

        [TestMethod]
        public void StorageSendVehicleToMethodShouldReturnInt()
        {
            //Arrange
            var sendVehicleToMethod = typeof(Storage).GetMethods(BindingFlags.Public | BindingFlags.Instance).First(m => m.Name == "SendVehicleTo");

            //Assert
            Assert.IsTrue(sendVehicleToMethod.ReturnType == typeof(int));
        }

        [TestMethod]
        public void StorageShouldHaveUnloadVehicleMethod()
        {
            //Arrange
            var methods = typeof(Storage).GetMethods(BindingFlags.Public | BindingFlags.Instance);

            //Assert
            Assert.IsTrue(methods.Any(m => m.Name == "UnloadVehicle"));
        }

        [TestMethod]
        public void StorageUnloadVehicleMethodShouldReturnInt()
        {
            //Arrange
            var unloadVehicleMethod = typeof(Storage).GetMethods(BindingFlags.Public | BindingFlags.Instance).First(m => m.Name == "UnloadVehicle");

            //Assert
            Assert.IsTrue(unloadVehicleMethod.ReturnType == typeof(int));
        }
    }
}
