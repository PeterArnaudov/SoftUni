namespace StorageMasterBusinessLogicTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StorageMaster.Core;
    using StorageMaster.Entities.Products;
    using StorageMaster.Entities.Storage;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    [TestClass]
    public class StorageMasterTests
    {
        [TestMethod]
        public void StorageMasterConstructorShouldCreate()
        {
            //Arrange
            StorageMaster sm = (StorageMaster)Activator.CreateInstance(typeof(StorageMaster));

            //Assert
            Assert.IsTrue(sm.GetType() == typeof(StorageMaster));
        }

        [TestMethod]
        public void StorageMasterAddProductMethodShouldWorkCorrectly()
        {
            //Assert
            var sm = (StorageMaster)Activator.CreateInstance(typeof(StorageMaster));
            var productsPool = typeof(StorageMaster).GetField("productsPool", BindingFlags.NonPublic | BindingFlags.Instance);
            var productsPoolValue = (Dictionary<string, Stack<Product>>)productsPool.GetValue(sm);
            var addProductMethod = typeof(StorageMaster).GetMethod("AddProduct");
            string productType = "Gpu";
            double price = 22.5;

            //Act
            addProductMethod.Invoke(sm, new object[] { productType, price });

            //Assert
            Assert.IsTrue(productsPoolValue.ContainsKey(productType));
        }

        [TestMethod]
        public void StorageMasterAddProductMethodShouldReturnString()
        {
            //Arrange
            var addProductMethod = typeof(StorageMaster).GetMethod("AddProduct");

            //Assert
            Assert.IsTrue(addProductMethod.ReturnType == typeof(string));
        }

        [TestMethod]
        public void StorageMasterAddProductShouldReturnCorrectString()
        {
            //Assert
            var sm = (StorageMaster)Activator.CreateInstance(typeof(StorageMaster));
            var productsPool = typeof(StorageMaster).GetField("productsPool", BindingFlags.NonPublic | BindingFlags.Instance);
            var productsPoolValue = (Dictionary<string, Stack<Product>>)productsPool.GetValue(sm);
            var addProductMethod = typeof(StorageMaster).GetMethod("AddProduct");
            string productType = "Gpu";
            double price = 22.5;

            //Act
            var actual = addProductMethod.Invoke(sm, new object[] { productType, price });

            //Assert
            string expected = $"Added {productType} to pool";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StorageMasterRegisterStorageShouldWorkCorrectly()
        {
            //Arrange
            var sm = (StorageMaster)Activator.CreateInstance(typeof(StorageMaster));
            var storageRegistry = sm.GetType().GetField("storageRegistry", BindingFlags.NonPublic | BindingFlags.Instance);
            var storageRegistryValue = (Dictionary<string, Storage>)storageRegistry.GetValue(sm);
            var registerStorageMethod = typeof(StorageMaster).GetMethod("RegisterStorage");
            string storageType = "Warehouse";
            string storageName = "Name";

            //Act
            registerStorageMethod.Invoke(sm, new object[] { storageType, storageName });

            //Assert
            Assert.IsTrue(storageRegistryValue.ContainsKey(storageName));
        }
        
        [TestMethod]
        public void StorageMasterRegisterStorageShouldReturnString()
        {
            //Arrange
            var sm = (StorageMaster)Activator.CreateInstance(typeof(StorageMaster));
            var storageRegistry = sm.GetType().GetField("storageRegistry", BindingFlags.NonPublic | BindingFlags.Instance);
            var storageRegistryValue = (Dictionary<string, Storage>)storageRegistry.GetValue(sm);
            var registerStorageMethod = typeof(StorageMaster).GetMethod("RegisterStorage");
            string storageType = "Warehouse";
            string storageName = "Name";

            //Act
            var actual = registerStorageMethod.Invoke(sm, new object[] { storageType, storageName });

            //Assert
            Assert.IsTrue(actual.GetType() == typeof(string));
        }

        [TestMethod]
        public void StorageMasterRegisterStorageShouldReturnCorrectString()
        {
            //Arrange
            var sm = (StorageMaster)Activator.CreateInstance(typeof(StorageMaster));
            var storageRegistry = sm.GetType().GetField("storageRegistry", BindingFlags.NonPublic | BindingFlags.Instance);
            var storageRegistryValue = (Dictionary<string, Storage>)storageRegistry.GetValue(sm);
            var registerStorageMethod = typeof(StorageMaster).GetMethod("RegisterStorage");
            string storageType = "Warehouse";
            string storageName = "Name";

            //Act
            var actual = registerStorageMethod.Invoke(sm, new object[] { storageType, storageName });

            //Assert
            string expected = "Registered Name";
            Assert.AreEqual(expected, actual);
        }
    }
}
