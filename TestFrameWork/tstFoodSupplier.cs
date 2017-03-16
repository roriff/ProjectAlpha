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
            string SomeFoodSupplier = "A La Carte";
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

        [TestMethod]
        public void FoodSupplierAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "25 Halford Street";
            //assign the data to the property
            AFoodSupplier.FoodSupplierAddress = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierAddress, SomeFoodSupplier);
        }
        [TestMethod]
        public void FoodSupplierPostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "LE56 HJT";
            //assign the data to the property
            AFoodSupplier.FoodSupplierPostCode = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierPostCode, SomeFoodSupplier);
        }
        [TestMethod]
        public void FoodSupplierCityPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "Leicester";
            //assign the data to the property
            AFoodSupplier.FoodSupplierCity = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierCity, SomeFoodSupplier);
        }
        [TestMethod]
        public void FoodSupplierCountyPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "Leicestershire";
            //assign the data to the property
            AFoodSupplier.FoodSupplierCounty = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierCounty, SomeFoodSupplier);
        }
        [TestMethod]
        public void FoodSupplierRegionPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "Leicestershire";
            //assign the data to the property
            AFoodSupplier.FoodSupplierRegion = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierRegion, SomeFoodSupplier);
        }
        [TestMethod]
        public void FoodSupplierPhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "0116 2354673";
            //assign the data to the property
            AFoodSupplier.FoodSupplierPhoneNo = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierPhoneNo, SomeFoodSupplier);
        }
        [TestMethod]
        public void FoodSupplierMobileNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "07456784563";
            //assign the data to the property
            AFoodSupplier.FoodSupplierMobileNo = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierMobileNo, SomeFoodSupplier);
        }
        [TestMethod]
        public void FoodSupplierEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //create some test data to assign to the property
            string SomeFoodSupplier = "tomjones@hotmail.co.uk";
            //assign the data to the property
            AFoodSupplier.FoodSupplierEmail = SomeFoodSupplier;
            //test to see that the two values are the same
            Assert.AreEqual(AFoodSupplier.FoodSupplierEmail, SomeFoodSupplier);
        }
        [TestMethod]
        public void FoodSupplierValidMethodOK()
        {
            //create an instance of the class we want to create
            clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFoodSupplier = "Steak";
            //invoke the method
            OK = AFoodSupplier.Valid(SomeFoodSupplier);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
