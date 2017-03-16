using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstFoodPayment
    {
        [TestMethod]
        public void FoodPaymentInstanceOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //test to see if the data works
            Assert.IsNotNull(AFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "Ten Pounds";
            AFoodPayment.FoodPayment = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.FoodPayment, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            Int32 TestData = 21;
            //assign the data to the property
            AFoodPayment.FoodPaymentID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AFoodPayment.FoodPaymentID, TestData);
        }

        [TestMethod]
        public void FoodPaymentCardNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "5151516561356565";
            AFoodPayment.FoodPaymentCardNumber = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.FoodPaymentCardNumber, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentCardVerificationCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "565";
            AFoodPayment.FoodPaymentCardVerificationCode = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.FoodPaymentCardVerificationCode, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentAccountNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "";
            AFoodPayment.FoodPaymentAccountNumber = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.FoodPaymentAccountNumber, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentNameOnCardPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "MR V R THOMAS";
            AFoodPayment.FoodPaymentNameOnCard = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.FoodPaymentNameOnCard, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentExpiryDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "MR V R THOMAS";
            AFoodPayment.FoodPaymentExpiryDate = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.FoodPaymentExpiryDate, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentSortCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "MR V R THOMAS";
            AFoodPayment.FoodPaymentSortCode = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.FoodPaymentSortCode, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentStaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "MR V R THOMAS";
            AFoodPayment.FoodPaymentStaffID = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.FoodPaymentStaffID, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentValidMethodOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFoodPayment = "Steak";
            //invoke the method
            OK = AFoodPayment.Valid(SomeFoodPayment);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
