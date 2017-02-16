using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstWard
    {
        [TestMethod]
        public void InstanceWardOK()
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestWard);
        }


        [TestMethod]
        public void WardNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //create some test data to assign to the property
            Int32 SomeWardNo = 1;
            //assign the test data to the property
            TestWard.WardNo= SomeWardNo;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestWard.WardNo, SomeWardNo);
        }

        [TestMethod]
        public void WardNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //create some test data to assign to the property
            string SomeWard = "Ward 1";
            //assign the test data to the property
            TestWard.WardName = SomeWard;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestWard.WardName, SomeWard);
        }

        [TestMethod]
        public void ValidateWardMethodOK() // testing that the ValidateWard() method really exists
        {
            clsWard TestWard = new clsWard();
            //boolean variable to store the result of the validation method
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeWard = "Ward 1";
            //invoke the method ValidateWard()
            OK = TestWard.ValidateWard(SomeWard);
            //test to see that the result obtained is actually correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WardNameMinLessOne() // 1 - 1 = 0 character
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with o character to assign to the property
            string SomeWard = "";
            //invoke the method ValidateWard()
            OK = TestWard.ValidateWard(SomeWard);
            //test to see that the result is actually correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void WardNameMinBoundary() //  ward can have 1 character minimum
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with one character to assign to the property
            string SomeWard = "w";
            //invoke the method ValidateWard()
            OK = TestWard.ValidateWard(SomeWard);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WardNameMinPlusOne() // 1 + 1 = 2 characters
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with two characters to assign to the property
            string SomeWard = "wa";
            //invoke the method ValidateWard()
            OK = TestWard.ValidateWard(SomeWard);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WardNameMaxLessOne() // 20 - 1 = 19 characters
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with 19 characters to assign to the property
            string SomeWard = "wardwardwardwardwar";
            //invoke the method ValidateWard()
            OK = TestWard.ValidateWard(SomeWard);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WardNameMaxBoundary() //  ward name can only have 20 characters max
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeWard = "wardwardwardwardward";
            //invoke the method
            OK = TestWard.ValidateWard(SomeWard);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void WardNameMaxPlusOne() // 20 + 1 = 21 characters
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeWard = "wardwardwardwardwardw";
            //invoke the method
            OK = TestWard.ValidateWard(SomeWard);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void WardNameMid() //  20 / 2 = 10 characters
        {
            //create an instance of the class we want to create
            clsWard TestWard = new clsWard();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeWard = "wardwardwa";
            //invoke the method
            OK = TestWard.ValidateWard(SomeWard);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void WardNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsWard TestWard= new clsWard();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeWard = "";
            //pad the string with w characters
            SomeWard = SomeWard.PadRight(500, 'w');
            //invoke the method
            OK = TestWard.ValidateWard(SomeWard);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

    }
}
