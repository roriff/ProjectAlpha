using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstFoodOrdering
    {
        [TestMethod]
        public void FoodOrderingInstanceOK()
        {
            //create an instance of the class we want to create
            clsFoodOrdering AFoodOrdering = new clsFoodOrdering();
            //test to see if the data works
            Assert.IsNotNull(AFoodOrdering);
        }

        [TestMethod]
        public void FoodOrderingPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodOrdering = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodOrdering = "1";
            AFoodOrdering.FoodOrdering = SomeFoodOrdering;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodOrdering.FoodOrdering, SomeFoodOrdering);
        }

        [TestMethod]
        public void FoodIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodOrdering AFoodOrdering = new clsFoodOrdering();
            //create some test data to assign to the property
            Int32 TestData = 21;
            //assign the data to the property
            AFoodOrdering.FoodOrderingID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AFoodOrdering.FoodOrderingID, TestData);
        }

        [TestMethod]
        public void RestaurantIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodOrdering AFoodOrdering = new clsFoodOrdering();
            //create some test data to assign to the property
            Int32 TestData = 21;
            //assign the data to the property
            AFoodOrdering.RestaurantID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AFoodOrdering.RestaurantID, TestData);
        }

        [TestMethod]
        public void FoodOrderingValidMethodOK()
        {
            //create an instance of the class we want to create
            clsFoodOrdering AFood = new clsFoodOrdering();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFoodOrdering = "Order 1";
            //invoke the method
            OK = AFood.Valid(SomeFoodOrdering);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
