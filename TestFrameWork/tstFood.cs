using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstFood
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the we want to create
            clsFood AFood = new clsFood();
            //test to see if this works
            Assert.IsNotNull(AFood);
        }

        [TestMethod]
        public void FoodPropertyOK()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //create soem test data to assign to the property
            string SomeFood = "Steak";
            //assign the data to the property
            AFood.Food = SomeFood;
            //test to see that the two values are the same
            Assert.AreEqual(AFood.Food, SomeFood);
        }

        [TestMethod]
        public void FoodIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //create some test data to assign to the property
            Int32 TestData = 21;
            //assign the data to the property
            AFood.FoodID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AFood.FoodID, TestData);
        }

        [TestMethod]
        public void FoodNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //create some test data to assign to the property
            string SomeFood = "Steak";
            //assign the data to the property
            AFood.FoodName = SomeFood;
            //test to see that the two values are the same
            Assert.AreEqual(AFood.FoodName, SomeFood);
        }

        [TestMethod]
        public void FoodPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //create some test data to assign to the property
            string SomeFood = "Steak";
            //assign the data to the property
            AFood.FoodPrice = SomeFood;
            //test to see that the two values are the same
            Assert.AreEqual(AFood.FoodPrice, SomeFood);
        }

        [TestMethod]
        public void FoodQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //create some test data to assign to the property
            string SomeFood = "Steak";
            //assign the data to the property
            AFood.Quantity = SomeFood;
            //test to see that the two values are the same
            Assert.AreEqual(AFood.Quantity, SomeFood);
        }
        [TestMethod]
        public void FoodValidMethodOK()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFood = "Steak";
            //invoke the method
            OK = AFood.Valid(SomeFood);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodMinLessOne()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFood = "AA";
            //invoke the method
            OK = AFood.Valid(SomeFood);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodMinBoundary()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFood = "a";
            //invoke the method
            OK = AFood.Valid(SomeFood);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFood = "aa";
            //invoke the method
            OK = AFood.Valid(SomeFood);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFood = "abcdefghijabcdefghijabcdefghijabcdefghij";
            //invoke the method
            OK = AFood.Valid(SomeFood);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodMaxBoundary()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFood = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghijabcdefghij";
            //invoke the method
            OK = AFood.Valid(SomeFood);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFood AFood = new clsFood();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFood = "abcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            OK = AFood.Valid(SomeFood);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
