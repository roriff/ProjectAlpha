using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstFoodSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //test to see if this works
            Assert.IsNotNull(AFoodSupplier);
        }

        [TestMethod]
        public void FoodSupplierPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create soem test data to assign to the property
            string SomeFoodSupplier = "Steak";
            //assign the data to the property
            AFoodSupplier.FoodSupplier = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplier, SomeFoodSupplier);
        }

        [TestMethod]
        public void FoodSupplierIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            Int32 TestData = 21;
            //assign the data to the property
            AFoodSupplier.FoodSupplierID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierID, TestData);
        }

        [TestMethod]
        public void FoodSupplierNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "Walkers";
            //assign the data to the property
            AFoodSupplier.FoodSupplierName = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierName, SomeFoodSupplier);
        }

        public void FoodSupplierAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "Walkers";
            //assign the data to the property
            AFoodSupplier.FoodSupplierAddress = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierAddress, SomeFoodSupplier);
        }
    }
}
