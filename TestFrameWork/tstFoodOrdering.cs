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
        public void FoodPaymentPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodOrdering = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodOrdering = "Ten Pounds";
            AFoodOrdering.FoodOrdering = SomeFoodOrdering;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodOrdering.FoodOrdering, SomeFoodOrdering);
        }
    }
}
