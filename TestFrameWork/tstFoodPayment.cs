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
            AFoodPayment.PaymentID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AFoodPayment.PaymentID, TestData);
        }

        [TestMethod]
        public void FoodPaymentCardNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "5151516561356565";
            AFoodPayment.CardNumber = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.CardNumber, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentCardVerificationCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "565";
            AFoodPayment.CardVerificationCode = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.CardVerificationCode, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentAccountNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "";
            AFoodPayment.AccountNumber = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.AccountNumber, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentNameOnCardPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "MR V R THOMAS";
            AFoodPayment.NameOnCard = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.NameOnCard, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentExpiryDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "MR V R THOMAS";
            AFoodPayment.ExpiryDate = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.ExpiryDate, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentSortCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "MR V R THOMAS";
            AFoodPayment.SortCode = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.SortCode, SomeFoodPayment);
        }

        [TestMethod]
        public void FoodPaymentStaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //create some test data to assign to the property
            string SomeFoodPayment = "MR V R THOMAS";
            AFoodPayment.StaffID = SomeFoodPayment;
            //test to see if the two values are the same
            Assert.AreEqual(AFoodPayment.StaffID, SomeFoodPayment);
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

        [TestMethod]
        public void FoodPaymentMinLessOne()
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

        [TestMethod]
        public void FoodPaymentMinBoundaryOK()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFoodPayment = "a";
            //invoke the method
            OK = AFoodPayment.Valid(SomeFoodPayment);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodPaymentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFoodPayment = "aa";
            //invoke the method
            OK = AFoodPayment.Valid(SomeFoodPayment);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodPaymentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFoodPayment = "abcdefghijabcdefghijabcdefghijabcdefghij";
            //invoke the method
            OK = AFoodPayment.Valid(SomeFoodPayment);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodPaymentMaxBoundary()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFoodPayment = "abcdefghijabcdefghijabcdefghijabcdefghij";
            //invoke the method
            OK = AFoodPayment.Valid(SomeFoodPayment);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void FoodPaymentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsFoodPayment AFoodPayment = new clsFoodPayment();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to asisgn to the property
            string SomeFoodPayment = "abcdefghijabcdefghijabcdefghijabcdefghij";
            //invoke the method
            OK = AFoodPayment.Valid(SomeFoodPayment);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
