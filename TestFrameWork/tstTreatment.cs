using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstTreatment
    {
        [TestMethod]
        public void InstanceTreatmentOK()
        {
            //create an instance of the class we want to create
            clsTreatment TestTreatment = new clsTreatment();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestTreatment);
        }

        /*Testing the attribute TreatmentID */
        [TestMethod]
        public void TreatmentIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsTreatment TestTreatment = new clsTreatment();
            //create some test data to assign to the property
            Int32 SomeTreatmentID = 1;
            //assign the test data to the property
            TestTreatment.TreatmentID = SomeTreatmentID;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestTreatment.TreatmentID, SomeTreatmentID);
        }

        /******** Testing for Treatment type. this will be a drop down list 
         * So just need to test the attribute is OK **********/
        [TestMethod]
        public void TreatmentTypePropertyOK()
        {
            // create an instance of the class we want to create
            clsTreatment TestTreatment = new clsTreatment();
            //create some test data to assign to the property
            string SomeTreatmentType = "Physical";
            //assign the test data to the property
            TestTreatment.TreatmentType = SomeTreatmentType;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestTreatment.TreatmentType, SomeTreatmentType);
        }

        /******** Testing for Medical condition. this will be a drop down list 
         * So just need to test the attribute is OK **********/
        [TestMethod]
        public void MedicationConditionPropertyOK()
        {
            // create an instance of the class we want to create
            clsTreatment TestTreatment = new clsTreatment();
            //create some test data to assign to the property
            string SomeMedicalCondition = "Mental Breakdown";
            //assign the test data to the property
            TestTreatment.MedicalCondition = SomeMedicalCondition;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestTreatment.MedicalCondition, SomeMedicalCondition);
        }


        /******** Testing for MedicationGiven property **********/
        [TestMethod]
        public void MedicationGivenPropertyOK()
        {
            // create an instance of the class we want to create
            clsTreatment TestTreatment = new clsTreatment();
            //create some test data to assign to the property
            string SomeMedication = "olanzapine";
            //assign the test data to the property
            TestTreatment.MedicationGiven = SomeMedication;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestTreatment.MedicationGiven, SomeMedication);
        }

        // test MedicationGiven for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void MedicationGivenMinLessOne()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeMedication= "";
            string ExpectedReturnMsg = "";
            string MedicationErrorMsg = TestTreatment.ValidateMedication(SomeMedication);
            Assert.AreEqual(MedicationErrorMsg, ExpectedReturnMsg);
        }
        // test MedicationGiven for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void MedicationGivenMin()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeMedication = "o";
            string ExpectedReturnMsg = "";
            string MedicationErrorMsg = TestTreatment.ValidateMedication(SomeMedication);
            Assert.AreEqual(MedicationErrorMsg, ExpectedReturnMsg);
        }

        // test MedicationGiven for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void MedicationGivenMinPlusOne()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeMedication = "oz";
            string ExpectedReturnMsg = "";
            string MedicationErrMsg = TestTreatment.ValidateMedication(SomeMedication);
            Assert.AreEqual(MedicationErrMsg, ExpectedReturnMsg);
        }

        // test MedicationGiven for maximum value minus 1 (49 characters). should return blank string (no error message)
        [TestMethod]
        public void MedicationGivenMaxLessOne()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeMedication = "";
            SomeMedication = SomeMedication.PadLeft(49);
            string ExpectedReturnMsg = "";
            string MedicationErrMsg = TestTreatment.ValidateMedication(SomeMedication);
            Assert.AreEqual(MedicationErrMsg, ExpectedReturnMsg);
        }

        // test MedicationGiven for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void MedicationGivenMax()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeMedication = "";
            SomeMedication = SomeMedication.PadLeft(50);
            string ExpectedReturnMsg = "";
            string MedicationErrMsg = TestTreatment.ValidateMedication(SomeMedication);
            Assert.AreEqual(MedicationErrMsg, ExpectedReturnMsg);
        }
        // test MedicationGiven for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void MedicationGivenMaxPlusOne()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeMedication = "";
            SomeMedication = SomeMedication.PadLeft(51);
            string ExpectedReturnMsg = "Medication No more than 50 characters";
            string MedicationErrMsg = TestTreatment.ValidateMedication(SomeMedication);
            Assert.AreEqual(MedicationErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max  which is 500 characters
        [TestMethod]
        public void MedicationGivenExtremeMax()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeMedication = "";
            SomeMedication = SomeMedication.PadLeft(500);
            string ExpectedReturnMsg = "Medication No more than 50 characters";
            string MedicationErrMsg = TestTreatment.ValidateMedication(SomeMedication);
            Assert.AreEqual(MedicationErrMsg, ExpectedReturnMsg);
        }


        /******** Testing for Treatment Comments property **********/
        [TestMethod]
        public void CommentsPropertyOK()
        {
            // create an instance of the class we want to create
            clsTreatment TestTreatment = new clsTreatment();
            //create some test data to assign to the property
            string SomeComments = "This treatement can trigger a heart attacks";
            //assign the test data to the property
            TestTreatment.Comments = SomeComments;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestTreatment.Comments, SomeComments);
        }

        // test Comments for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void CommentsMinLessOne()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeComments = "";
            string ExpectedReturnMsg = "";
            string CommentsErrorMsg = TestTreatment.ValidateComments(SomeComments);
            Assert.AreEqual(CommentsErrorMsg, ExpectedReturnMsg);
        }
        // test Comments for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void CommentsMin()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeComments = "t";
            string ExpectedReturnMsg = "";
            string CommentsErrorMsg = TestTreatment.ValidateComments(SomeComments);
            Assert.AreEqual(CommentsErrorMsg, ExpectedReturnMsg);
        }

        // test Comments for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void CommentsMinPlusOne()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeComments = "Th";
            string ExpectedReturnMsg = "";
            string CommentsErrMsg = TestTreatment.ValidateComments(SomeComments);
            Assert.AreEqual(CommentsErrMsg, ExpectedReturnMsg);
        }

        // test Comments for maximum value minus 1 (999 characters). should return blank string (no error message)
        [TestMethod]
        public void CommentsMaxLessOne()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeComments = "";
            SomeComments = SomeComments.PadLeft(999);
            string ExpectedReturnMsg = "";
            string CommentsErrMsg = TestTreatment.ValidateComments(SomeComments);
            Assert.AreEqual(CommentsErrMsg, ExpectedReturnMsg);
        }

        // test Comments for maximum value (1000 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void CommentsMax()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeComments = "";
            SomeComments = SomeComments.PadLeft(1000);
            string ExpectedReturnMsg = "";
            string CommentsErrMsg = TestTreatment.ValidateComments(SomeComments);
            Assert.AreEqual(CommentsErrMsg, ExpectedReturnMsg);
        }
        // test Comments for maximum value plus 1 (1001 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void CommentsMaxPlusOne()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeComments = "";
            SomeComments = SomeComments.PadLeft(1001);
            string ExpectedReturnMsg = "Comments No more than 1000 characters";
            string CommentsErrMsg = TestTreatment.ValidateComments(SomeComments);
            Assert.AreEqual(CommentsErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max  which is 3000 characters
        [TestMethod]
        public void CommentsExtremeMax()
        {
            clsTreatment TestTreatment = new clsTreatment();
            string SomeComments = "";
            SomeComments = SomeComments.PadLeft(3000);
            string ExpectedReturnMsg = "Comments No more than 1000 characters";
            string CommentsErrMsg = TestTreatment.ValidateComments(SomeComments);
            Assert.AreEqual(CommentsErrMsg, ExpectedReturnMsg);
        }
    }
}
