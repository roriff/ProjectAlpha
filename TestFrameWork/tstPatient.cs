using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstPatient
    {
        [TestMethod]
        public void InstancePatientOK()
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestPatient);
        }

        /*Testing the attribute PatientID which is an auto generated number*/
        [TestMethod]
        public void PatientIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            Int32 SomePatientID = 1;
            //assign the test data to the property
            TestPatient.PatientID = SomePatientID;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.PatientID, SomePatientID);
        }


        /******** Testing the attribute Title  with the min , max, mid boundaries********/
        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeTitle = "Mr";
            //assign the test data to the property
            TestPatient.Title = SomeTitle;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.Title, SomeTitle);
        }

        [TestMethod]
        public void ValidateTitleMethodOK() // testing that the ValidateTitle() method really exists
        {
            clsPatient TestPatient = new clsPatient();
            //boolean variable to store the result of the validation method
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "Mr";
            //invoke the method ValidateTitle()
            OK = TestPatient.ValidateTitle(SomeTitle);
            //test to see that the result obtained is actually correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinLessOne() // 1 - 1 = 0 character
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with 0 character to assign to the property
            string SomeTitle = "";
            //invoke the method ValidateTitle()
            OK = TestPatient.ValidateTitle(SomeTitle);
            //test to see that the result is actually correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinBoundary() //  can have 1 character minimum
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with one character to assign to the property
            string SomeTitle = "M";
            //invoke the method ValidateTitle()
            OK = TestPatient.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinPlusOne() // can have 1 + 1 = 2 characters
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with two characters to assign to the property
            string SomeTitle = "Mr";
            //invoke the method ValidateTitle()
            OK = TestPatient.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMaxLessOne() // can have 6 - 1 = 5 characters
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with 5 characters to assign to the property
            string SomeTitle = "MrMrM";
            //invoke the method ValidateTitle()
            OK = TestPatient.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMaxBoundary() //  Title can only have 6 characters max
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "MrMrMr";
            //invoke the method
            OK = TestPatient.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TitleMaxPlusOne() // 6 + 1 = 7 characters
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "MrMrMrMrM";
            //invoke the method
            OK = TestPatient.ValidateTitle(SomeTitle);
            //test to see that the result is correct , should not save this data 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TitleMid() //  6 / 2 = 3 characters
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "MrM";
            //invoke the method
            OK = TestPatient.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "";
            //pad the string with w characters
            SomeTitle = SomeTitle.PadRight(50, 'w');
            //invoke the method
            OK = TestPatient.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        /******** Testing for FirstName property of Patient **********/
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeFirstName = "Roger";
            //assign the test data to the property
            TestPatient.FirstName = SomeFirstName;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.FirstName, SomeFirstName);
        }

        // test FirstName for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeFirstName = "";
            string ExpectedReturnMsg = "First Name cannot be blank";
            string FirstNameErrorMsg = TestPatient.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrorMsg, ExpectedReturnMsg);
        }
        // test FirstName for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void FirstNameMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeFirstName = "A";
            string ExpectedReturnMsg = "";
            string FirstNameErrorMsg = TestPatient.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrorMsg, ExpectedReturnMsg);
        }

        // test FirstName for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeFirstName = "Aa";
            string ExpectedReturnMsg = "";
            string FirstNameErrMsg = TestPatient.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);
        }

        // test FirstName for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeFirstName = "";
            SomeFirstName = SomeFirstName.PadLeft(49);
            string ExpectedReturnMsg = "";
            string FirstNameErrMsg = TestPatient.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);
        }

        // test FirstName for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void FirstNameMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeFirstName = "";
            SomeFirstName = SomeFirstName.PadLeft(50);
            string ExpectedReturnMsg = "";
            string FirstNameErrMsg = TestPatient.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);
        }
        // test FirstName for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeFirstName = "";
            SomeFirstName = SomeFirstName.PadLeft(51);
            string ExpectedReturnMsg = "First Name No more than 50 characters";
            string FirstNameErrMsg = TestPatient.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);

        }
        // test FirstName for its extreme max value being 500 characters
        [TestMethod]
        public void FirstNameExtremeMax()
        {        
            clsPatient TestPatient = new clsPatient();
            string SomeFirstName = "";
            SomeFirstName = SomeFirstName.PadLeft(500);
            string ExpectedReturnMsg = "First Name No more than 50 characters";
            string FirstNameErrMsg = TestPatient.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);
        }



        /******** Testing for LastName property of Patient **********/
        [TestMethod]
        public void LastNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeLastName = "Riggs";
            //assign the test data to the property
            TestPatient.LastName = SomeLastName;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.LastName, SomeLastName);
        }

        // test LastName for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLastName = "";
            string ExpectedReturnMsg = "Last Name cannot be blank";
            string LastNameErrorMsg = TestPatient.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrorMsg, ExpectedReturnMsg);
        }
        // test LastName for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void LastNameMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLastName = "A";
            string ExpectedReturnMsg = "";
            string LastNameErrorMsg = TestPatient.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrorMsg, ExpectedReturnMsg);
        }

        // test LastName for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLastName = "Aa";
            string ExpectedReturnMsg = "";
            string LastNameErrMsg = TestPatient.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);
        }

        // test LastName for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLastName = "";
            SomeLastName = SomeLastName.PadLeft(49);
            string ExpectedReturnMsg = "";
            string LastNameErrMsg = TestPatient.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);
        }

        // test LastName for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void LastNameMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLastName = "";
            SomeLastName = SomeLastName.PadLeft(50);
            string ExpectedReturnMsg = "";
            string LastNameErrMsg = TestPatient.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);
        }
        // test LastName for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLastName = "";
            SomeLastName = SomeLastName.PadLeft(51);
            string ExpectedReturnMsg = "Last Name No more than 50 characters";
            string LastNameErrMsg = TestPatient.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);
        }
        // test the extreme max of the LastName
        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLastName = "";
            SomeLastName = SomeLastName.PadLeft(500);
            string ExpectedReturnMsg = "Last Name No more than 50 characters";
            string LastNameErrMsg = TestPatient.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);

        }

        /********** Testing the DateOfBirth Prperty of the Patient *****/
        // Property DateOfBirth
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            DateTime SomeDateOfBirth = Convert.ToDateTime(" 1 jan 1996");
            //assign the test data to the property
            TestPatient.DateOfBirth = SomeDateOfBirth;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.DateOfBirth, SomeDateOfBirth);
        }

        //Test the Min -1 of the date of birth which is 31 dec 1916 as 100 years is too old for a patient
        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateOfBirth = "31 Dec 1915";
            string ExpectedReturnMsg = "Date of Birth should be on or after 1 Jan 1916";
            string DateOfBirthErrMsg = TestPatient.ValidateDateOfBirth(SomeDateOfBirth);
            Assert.AreEqual(DateOfBirthErrMsg, ExpectedReturnMsg);
        }

        //Test the Min of the date of birth which is 1 jan 1916 as 100 years is too old for a patient
        [TestMethod]
        public void DateOfBirthMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateOfBirth = "1 jan 1916";
            string ExpectedReturnMsg = "";
            string DateOfBirthErrMsg = TestPatient.ValidateDateOfBirth(SomeDateOfBirth);
            Assert.AreEqual(DateOfBirthErrMsg, ExpectedReturnMsg);
        }

        //Test the Min + 1  of the date of birth which is 2 jan 1916 as 100 years is too old for a patient
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateOfBirth = "2 jan 1916";
            string ExpectedReturnMsg = "";
            string DateOfBirthErrMsg = TestPatient.ValidateDateOfBirth(SomeDateOfBirth);
            Assert.AreEqual(DateOfBirthErrMsg, ExpectedReturnMsg);
        }

        //Test the Max - 1 of the date of birth which is 31 dec 1995 as children under 18 years is too young for a patient
        [TestMethod]
        public void DateOfBirthMaxMinusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateOfBirth = "31 Dec 1995";
            string ExpectedReturnMsg = "";
            string DateOfBirthErrMsg = TestPatient.ValidateDateOfBirth(SomeDateOfBirth);
            Assert.AreEqual(DateOfBirthErrMsg, ExpectedReturnMsg);
        }

        //Test the Max of the date of birth which is 1 jan 1996 as children under 18 years is too young for a patient
        [TestMethod]
        public void DateOfBirthMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateOfBirth = "1 Jan 1996";
            string ExpectedReturnMsg = "";
            string DateOfBirthErrMsg = TestPatient.ValidateDateOfBirth(SomeDateOfBirth);
            Assert.AreEqual(DateOfBirthErrMsg, ExpectedReturnMsg);
        }

        //Test the Max+1 of the date of birth which is 2 jan 1996 as children under 18 years is too young for a patient
        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateOfBirth = "2 Jan 1996";
            string ExpectedReturnMsg = "Date of Birth should be on or before 1 Jan 1996";
            string DateOfBirthErrMsg = TestPatient.ValidateDateOfBirth(SomeDateOfBirth);
            Assert.AreEqual(DateOfBirthErrMsg, ExpectedReturnMsg);

        }

        /******** Testing for Gender property of Patient **********/
        [TestMethod]
        public void GenderPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeGender = "Female";
            //assign the test data to the property
            TestPatient.Gender = SomeGender;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.Gender, SomeGender);
        }

        // test Gender for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void GenderMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGender = "";
            string ExpectedReturnMsg = "Gender cannot be blank";
            string GenderErrorMsg = TestPatient.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrorMsg, ExpectedReturnMsg);
        }
        // test Gender for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void GenderMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGender = "F";
            string ExpectedReturnMsg = "";
            string GenderErrorMsg = TestPatient.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrorMsg, ExpectedReturnMsg);
        }

        // test Gender for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void GenderMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGender = "Fe";
            string ExpectedReturnMsg = "";
            string GenderErrMsg = TestPatient.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);
        }

        // test Gender for maximum value minus 1 (11 characters). should return blank string (no error message)
        [TestMethod]
        public void GenderMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGender = "";
            SomeGender = SomeGender.PadLeft(11);
            string ExpectedReturnMsg = "";
            string GenderErrMsg = TestPatient.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);
        }

        // test Gender for maximum value (12 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void GenderMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGender = "";
            SomeGender = SomeGender.PadLeft(12);
            string ExpectedReturnMsg = "";
            string GenderErrMsg = TestPatient.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);
        }
        // test Gender for maximum value plus 1 (13 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void GenderMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGender = "";
            SomeGender = SomeGender.PadLeft(13);
            string ExpectedReturnMsg = "Gender No more than 12 characters";
            string GenderErrMsg = TestPatient.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the Gender which is 50 characters
        [TestMethod]
        public void GenderExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGender = "";
            SomeGender = SomeGender.PadLeft(50);
            string ExpectedReturnMsg = "Gender No more than 12 characters";
            string GenderErrMsg = TestPatient.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);
        }


        /**** test for GenderSymbol property which is an image 
         * 
         * HAS BEEN REMOVED ROM SYSTEM AND DATABASE AS IT IS NOT USEFUL , GENDER IS ENOUGH
         * 
        // only one test as data generated by system
        [TestMethod]
        public void GenderSymbolPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeGenderSymbol = "~/images/male.jpg";
            //assign the test data to the property
            TestPatient.GenderSymbol = SomeGenderSymbol;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.GenderSymbol, SomeGenderSymbol);
        }

        ****/


        /******** Testing for Street property of Patient **********/
        [TestMethod]
        public void StreetPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeStreet = "31 Stanton";
            //assign the test data to the property
            TestPatient.Street = SomeStreet;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.Street, SomeStreet);
        }

        // test Street for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void StreetMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeStreet = "";
            string ExpectedReturnMsg = "Street cannot be blank";
            string StreetErrorMsg = TestPatient.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrorMsg, ExpectedReturnMsg);
        }
        // test Street for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void StreetMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeStreet = "S";
            string ExpectedReturnMsg = "";
            string StreetErrorMsg = TestPatient.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrorMsg, ExpectedReturnMsg);
        }

        // test Street for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void StreetMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeStreet = "St";
            string ExpectedReturnMsg = "";
            string StreetErrMsg = TestPatient.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }

        // test Street for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void StreetMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeStreet = "";
            SomeStreet = SomeStreet.PadLeft(49);
            string ExpectedReturnMsg = "";
            string StreetErrMsg = TestPatient.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }

        // test Street for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void StreetMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeStreet = "";
            SomeStreet = SomeStreet.PadLeft(50);
            string ExpectedReturnMsg = "";
            string StreetErrMsg = TestPatient.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }
        // test Street for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void StreetMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeStreet = "";
            SomeStreet = SomeStreet.PadLeft(51);
            string ExpectedReturnMsg = "Street No more than 50 characters";
            string StreetErrMsg = TestPatient.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }
        // test Street for its extreme max value being 500 characters
        [TestMethod]
        public void StreetExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeStreet = "";
            SomeStreet = SomeStreet.PadLeft(500);
            string ExpectedReturnMsg = "Street No more than 50 characters";
            string StreetErrMsg = TestPatient.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for Town property of Patient **********/
        [TestMethod]
        public void TownPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeTown = "Yeoville";
            //assign the test data to the property
            TestPatient.Town = SomeTown;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.Town, SomeTown);
        }

        // test Town for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void TownMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeTown = "";
            string ExpectedReturnMsg = "Town cannot be blank";
            string TownErrorMsg = TestPatient.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrorMsg, ExpectedReturnMsg);
        }
        // test Town for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void TownMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeTown = "Y";
            string ExpectedReturnMsg = "";
            string TownErrorMsg = TestPatient.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrorMsg, ExpectedReturnMsg);
        }

        // test Town for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void TownMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeTown = "St";
            string ExpectedReturnMsg = "";
            string TownErrMsg = TestPatient.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);
        }

        // test Town for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void TownMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeTown = "";
            SomeTown = SomeTown.PadLeft(49);
            string ExpectedReturnMsg = "";
            string TownErrMsg = TestPatient.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);
        }

        // test Town for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void TownMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeTown = "";
            SomeTown = SomeTown.PadLeft(50);
            string ExpectedReturnMsg = "";
            string TownErrMsg = TestPatient.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);
        }
        // test Town for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void TownMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeTown = "";
            SomeTown = SomeTown.PadLeft(51);
            string ExpectedReturnMsg = "Town No more than 50 characters";
            string TownErrMsg = TestPatient.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);

        }
        // test Town for its extreme max value being 500 characters
        [TestMethod]
        public void TownExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeTown = "";
            SomeTown = SomeTown.PadLeft(500);
            string ExpectedReturnMsg = "Town No more than 50 characters";
            string TownErrMsg = TestPatient.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for County property of Patient **********/
        [TestMethod]
        public void CountyPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeCounty = "Leicestershire";
            //assign the test data to the property
            TestPatient.County = SomeCounty;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.County, SomeCounty);
        }

        // test County for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void CountyMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeCounty = "";
            string ExpectedReturnMsg = "";
            string CountyErrorMsg = TestPatient.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrorMsg, ExpectedReturnMsg);
        }
        // test County for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void CountyMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeCounty = "Y";
            string ExpectedReturnMsg = "";
            string CountyErrorMsg = TestPatient.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrorMsg, ExpectedReturnMsg);
        }

        // test County for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void CountyMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeCounty = "St";
            string ExpectedReturnMsg = "";
            string CountyErrMsg = TestPatient.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);
        }

        // test County for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void CountyMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeCounty = "";
            SomeCounty = SomeCounty.PadLeft(49);
            string ExpectedReturnMsg = "";
            string CountyErrMsg = TestPatient.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);
        }

        // test County for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void CountyMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeCounty = "";
            SomeCounty = SomeCounty.PadLeft(50);
            string ExpectedReturnMsg = "";
            string CountyErrMsg = TestPatient.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);
        }
        // test County for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void CountyMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeCounty = "";
            SomeCounty = SomeCounty.PadLeft(51);
            string ExpectedReturnMsg = "County No more than 50 characters";
            string CountyErrMsg = TestPatient.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);

        }
        // test County for its extreme max value being 500 characters
        [TestMethod]
        public void CountyExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeCounty = "";
            SomeCounty = SomeCounty.PadLeft(500);
            string ExpectedReturnMsg = "County No more than 50 characters";
            string CountyErrMsg = TestPatient.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);
        }


        /******** Testing for PostCode property of Patient **********/
        [TestMethod]
        public void PostCodePropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomePostCode = "LE3 7GH";
            //assign the test data to the property
            TestPatient.PostCode = SomePostCode;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.PostCode, SomePostCode);
        }

        // test PostCode for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void PostCodeMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomePostCode = "";
            string ExpectedReturnMsg = "PostCode cannot be blank";
            string PostCodeErrorMsg = TestPatient.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrorMsg, ExpectedReturnMsg);
        }
        // test PostCode for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void PostCodeMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomePostCode = "L";
            string ExpectedReturnMsg = "";
            string PostCodeErrorMsg = TestPatient.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrorMsg, ExpectedReturnMsg);
        }

        // test PostCode for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomePostCode = "LE";
            string ExpectedReturnMsg = "";
            string PostCodeErrMsg = TestPatient.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);
        }

        // test PostCode for maximum value minus 1 (9 characters). should return blank string (no error message)
        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomePostCode = "";
            SomePostCode = SomePostCode.PadLeft(9);
            string ExpectedReturnMsg = "";
            string PostCodeErrMsg = TestPatient.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);
        }

        // test PostCode for maximum value (10 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void PostCodeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomePostCode = "";
            SomePostCode = SomePostCode.PadLeft(10);
            string ExpectedReturnMsg = "";
            string PostCodeErrMsg = TestPatient.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);
        }
        // test PostCode for maximum value plus 1 (11 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomePostCode = "";
            SomePostCode = SomePostCode.PadLeft(11);
            string ExpectedReturnMsg = "PostCode No more than 10 characters";
            string PostCodeErrMsg = TestPatient.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the PostCode which is 50 characters
        [TestMethod]
        public void PostCodeExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomePostCode = "";
            SomePostCode = SomePostCode.PadLeft(50);
            string ExpectedReturnMsg = "PostCode No more than 10 characters";
            string PostCodeErrMsg = TestPatient.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for LandlineNo property of Patient **********/
        [TestMethod]
        public void LandlineNoPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeLandlineNo = "01162342635";
            //assign the test data to the property
            TestPatient.LandlineNo = SomeLandlineNo;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.LandlineNo, SomeLandlineNo);
        }

        // test LandlineNo for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void LandlineNoMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLandlineNo = "";
            string ExpectedReturnMsg = "";
            string LandlineErrorMsg = TestPatient.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrorMsg, ExpectedReturnMsg);
        }
        // test LandlineNo for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void LandlineNoMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLandlineNo = "0";
            string ExpectedReturnMsg = "";
            string LandlineErrorMsg = TestPatient.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrorMsg, ExpectedReturnMsg);
        }

        // test LandlineNo for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void LandlineNoMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLandlineNo = "01";
            string ExpectedReturnMsg = "";
            string LandlineErrMsg = TestPatient.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);
        }

        // test LandlineNo for maximum value minus 1 (14 characters). should return blank string (no error message)
        [TestMethod]
        public void LandlineNoMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLandlineNo = "";
            SomeLandlineNo = SomeLandlineNo.PadLeft(14);
            string ExpectedReturnMsg = "";
            string LandlineErrMsg = TestPatient.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);
        }

        // test LandlineNo for maximum value (15 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void LandlineNoMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLandlineNo = "";
            SomeLandlineNo = SomeLandlineNo.PadLeft(15);
            string ExpectedReturnMsg = "";
            string LandlineErrMsg = TestPatient.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);
        }
        // test LandlineNo for maximum value plus 1 (16 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void LandlineNoMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLandlineNo = "";
            SomeLandlineNo = SomeLandlineNo.PadLeft(16);
            string ExpectedReturnMsg = "LandLineNo No more than 15 characters";
            string LandlineErrMsg = TestPatient.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the landline which is 50 characters
        [TestMethod]
        public void LandlineExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeLandlineNo = "";
            SomeLandlineNo = SomeLandlineNo.PadLeft(50);
            string ExpectedReturnMsg = "LandLineNo No more than 15 characters";
            string LandlineErrMsg = TestPatient.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for MobileNo property of Patient **********/
        [TestMethod]
        public void MobileNoPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeMobileNo = "07762342635";
            //assign the test data to the property
            TestPatient.MobileNo = SomeMobileNo;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.MobileNo, SomeMobileNo);
        }

        // test MobileeNo for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void MobileNoMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeMobileNo = "";
            string ExpectedReturnMsg = "";
            string MobileErrorMsg = TestPatient.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrorMsg, ExpectedReturnMsg);
        }
        // test MobileNo for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void MobileNoMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeMobileNo = "0";
            string ExpectedReturnMsg = "";
            string MobileErrorMsg = TestPatient.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrorMsg, ExpectedReturnMsg);
        }

        // test MobileNo for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void MobileNoMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeMobileNo = "01";
            string ExpectedReturnMsg = "";
            string MobileErrMsg = TestPatient.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrMsg, ExpectedReturnMsg);
        }

        // test MobileNo for maximum value minus 1 (14 characters). should return blank string (no error message)
        [TestMethod]
        public void MobileNoMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeMobileNo = "";
            SomeMobileNo = SomeMobileNo.PadLeft(14);
            string ExpectedReturnMsg = "";
            string MobileNoErrMsg = TestPatient.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileNoErrMsg, ExpectedReturnMsg);
        }

        // test MobileNo for maximum value (15 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void MobileNoMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeMobileNo = "";
            SomeMobileNo = SomeMobileNo.PadLeft(15);
            string ExpectedReturnMsg = "";
            string MobileErrMsg = TestPatient.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrMsg, ExpectedReturnMsg);
        }
        // test MobileNo for maximum value plus 1 (16 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void MobileNoMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeMobileNo = "";
            SomeMobileNo = SomeMobileNo.PadLeft(16);
            string ExpectedReturnMsg = "MobileNo No more than 15 characters";
            string MobileErrMsg = TestPatient.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the MobileNo which is 50 characters
        [TestMethod]
        public void MobileExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeMobileNo = "";
            SomeMobileNo = SomeMobileNo.PadLeft(50);
            string ExpectedReturnMsg = "MobileNo No more than 15 characters";
            string MobileNoErrMsg = TestPatient.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileNoErrMsg, ExpectedReturnMsg);
        }


        /*****  Testing for DateAdmitted Property of the Patient *****/
        // only test as the date is generated by the system as the actual day date when the patient is admitted
        [TestMethod] 
        public void DateAdmitted() 
        {
            clsPatient TestPatient = new clsPatient();
            TestPatient.DateAdmitted = DateTime.Now;
        }

        // Test the Min of dateAdmitted
        [TestMethod]
        public void DateAdmittedMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateAdmitted = Convert.ToString(DateTime.Today);
            //SomeDateAdmitted = TestPatient.DateAdmitted;
            string ExpectedReturnMsg = "";
            string DateAdmittedErrMsg = TestPatient.ValidateDateAdmitted(SomeDateAdmitted);
            Assert.AreEqual(DateAdmittedErrMsg, ExpectedReturnMsg);
        }


        // Test the Max of DateAdmitted
        [TestMethod]
        public void DateAdmittedMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateAdmitted = Convert.ToString(DateTime.Today);
            string ExpectedReturnMsg = "";
            string DateAdmittedErrMsg = TestPatient.ValidateDateAdmitted(SomeDateAdmitted);
            Assert.AreEqual(DateAdmittedErrMsg, ExpectedReturnMsg);

        }

       /**
        //Test the Max+1 of DateAdmitted
        [TestMethod]
        public void DateAdmittedMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateAdmitted = Convert.ToString(DateTime.Now.AddDays(1));
            string ExpectedReturnMsg = "DateAdmitted can't be after today";
            string DateAdmittedErrMsg = TestPatient.ValidateDateAdmitted(SomeDateAdmitted);
            Assert.AreEqual(DateAdmittedErrMsg, ExpectedReturnMsg);

        }
         **/
          


        /*****  Testing for DateDischarged Property of the Patient , only two tests as the dateDischarged can only 
         * be blank or must be greater than date admitted is generated by the system as the actual day date when the patient is admitted **/

        // Test the Min of date Discharged
        [TestMethod]
        public void DateDischargedMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateDischarged = Convert.ToString(DateTime.Now);
            //SomeDateDischarged = TestPatient.DateDischarged;
            string ExpectedReturnMsg = "";
            string DateDischargedErrMsg = TestPatient.ValidateDateDischarged(SomeDateDischarged);
            Assert.AreEqual(DateDischargedErrMsg, ExpectedReturnMsg);
        }

        // Test the Max of date discharged
        [TestMethod]
        public void DateDischargedMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateDischarged = Convert.ToString(DateTime.Now);
            string ExpectedReturnMsg = "";
            string DateDischargedErrMsg = TestPatient.ValidateDateDischarged(SomeDateDischarged);
            Assert.AreEqual(DateDischargedErrMsg, ExpectedReturnMsg);

        }

        
        // Test the Max+1 of date discharged
        [TestMethod]
        public void DateDischargedMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeDateDischarged = Convert.ToString(DateTime.Now.AddDays(1));
            string ExpectedReturnMsg = "";
            string DateDischargedErrMsg = TestPatient.ValidateDateDischarged(SomeDateDischarged);
            Assert.AreEqual(DateDischargedErrMsg, ExpectedReturnMsg);

        }
        

        /******** Testing for Occupation property of Patient **********/
        [TestMethod]
        public void OccupationPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeOccupation = "Carpenter";
            //assign the test data to the property
            TestPatient.Occupation = SomeOccupation;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.Occupation, SomeOccupation);
        }

        // test  for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void OccupationMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeOccupation = "";
            string ExpectedReturnMsg = "";
            string OccupationErrorMsg = TestPatient.ValidateOccupation(SomeOccupation);
            Assert.AreEqual(OccupationErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void OccupationMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeOccupation = "C";
            string ExpectedReturnMsg = "";
            string OccupationErrorMsg = TestPatient.ValidateOccupation(SomeOccupation);
            Assert.AreEqual(OccupationErrorMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void OccupationMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeOccupation = "Ca";
            string ExpectedReturnMsg = "";
            string OccupationErrMsg = TestPatient.ValidateOccupation(SomeOccupation);
            Assert.AreEqual(OccupationErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void OccupationMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeOccupation = "";
            SomeOccupation = SomeOccupation.PadLeft(49);
            string ExpectedReturnMsg = "";
            string OccupationErrMsg = TestPatient.ValidateOccupation(SomeOccupation);
            Assert.AreEqual(OccupationErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void OccupationMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeOccupation = "";
            SomeOccupation = SomeOccupation.PadLeft(50);
            string ExpectedReturnMsg = "";
            string OccupationErrMsg = TestPatient.ValidateOccupation(SomeOccupation);
            Assert.AreEqual(OccupationErrMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void OccupationMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeOccupation = "";
            SomeOccupation = SomeOccupation.PadLeft(51);
            string ExpectedReturnMsg = "Occupation No more than 50 characters";
            string OccupationErrMsg = TestPatient.ValidateOccupation(SomeOccupation);
            Assert.AreEqual(OccupationErrMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 500 characters
        [TestMethod]
        public void OccupationExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeOccupation = "";
            SomeOccupation = SomeOccupation.PadLeft(500);
            string ExpectedReturnMsg = "Occupation No more than 50 characters";
            string OccupationErrMsg = TestPatient.ValidateOccupation(SomeOccupation);
            Assert.AreEqual(OccupationErrMsg, ExpectedReturnMsg);
        }


        /******** Testing for NextOfKin property of Patient **********/
        [TestMethod]
        public void NextOfKinPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeKin = "James";
            //assign the test data to the property
            TestPatient.NextOfKin = SomeKin;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.NextOfKin, SomeKin);
        }

        // test  for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void NextOfKinMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKin = "";
            string ExpectedReturnMsg = "";
            string NextOfKinErrorMsg = TestPatient.ValidateNextOfKin(SomeKin);
            Assert.AreEqual(NextOfKinErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void NextOfKinMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKin = "C";
            string ExpectedReturnMsg = "";
            string NextOfKinErrorMsg = TestPatient.ValidateNextOfKin(SomeKin);
            Assert.AreEqual(NextOfKinErrorMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void NextOfKinMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKin = "Ca";
            string ExpectedReturnMsg = "";
            string NextOfKinErrMsg = TestPatient.ValidateNextOfKin(SomeKin);
            Assert.AreEqual(NextOfKinErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 (99 characters).  should return blank string (no error message)
        [TestMethod]
        public void NextOfKinMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKin = "";
            SomeKin = SomeKin.PadLeft(99);
            string ExpectedReturnMsg = "";
            string NextOfKinErrMsg = TestPatient.ValidateNextOfKin(SomeKin);
            Assert.AreEqual(NextOfKinErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value (100 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void NextOfKinMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKin = "";
            SomeKin = SomeKin.PadLeft(100);
            string ExpectedReturnMsg = "";
            string NextOfKinErrMsg = TestPatient.ValidateNextOfKin(SomeKin);
            Assert.AreEqual(NextOfKinErrMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 (101 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void NextOfKinMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKin = "";
            SomeKin = SomeKin.PadLeft(101);
            string ExpectedReturnMsg = "Next Of Kin No more than 100 characters";
            string NextOfKinErrMsg = TestPatient.ValidateNextOfKin(SomeKin);
            Assert.AreEqual(NextOfKinErrMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 500 characters
        [TestMethod]
        public void NextOfKinExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKin = "";
            SomeKin = SomeKin.PadLeft(500);
            string ExpectedReturnMsg = "Next Of Kin No more than 100 characters";
            string NextOfKinErrMsg = TestPatient.ValidateNextOfKin(SomeKin);
            Assert.AreEqual(NextOfKinErrMsg, ExpectedReturnMsg);
        }


        /******** Testing for NextOfKinPhoneNo property of Patient **********/
        [TestMethod]
        public void NextOfKinPhoneNoPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeKinPhoneNo = "01156256527";
            //assign the test data to the property
            TestPatient.NextOfKinPhoneNo = SomeKinPhoneNo;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.NextOfKinPhoneNo, SomeKinPhoneNo);
        }

        // test  for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void NextOfKinPhoneNoMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKinPhoneNo = "";
            string ExpectedReturnMsg = "";
            string NextOfKinPhoneNoErrorMsg = TestPatient.ValidateNextOfKinPhoneNo(SomeKinPhoneNo);
            Assert.AreEqual(NextOfKinPhoneNoErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void NextOfKinPhoneNoMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKinPhoneNo = "0";
            string ExpectedReturnMsg = "";
            string NextOfKinPhoneNoErrorMsg = TestPatient.ValidateNextOfKinPhoneNo(SomeKinPhoneNo);
            Assert.AreEqual(NextOfKinPhoneNoErrorMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void NextOfKinMinPhoneNoPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKinPhoneNo = "01";
            string ExpectedReturnMsg = "";
            string NextOfKinPhoneNoErrMsg = TestPatient.ValidateNextOfKinPhoneNo(SomeKinPhoneNo);
            Assert.AreEqual(NextOfKinPhoneNoErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 (39 characters).  should return blank string (no error message)
        [TestMethod]
        public void NextOfKinPhoneNoMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKinPhoneNo = "";
            SomeKinPhoneNo = SomeKinPhoneNo.PadLeft(39);
            string ExpectedReturnMsg = "";
            string NextOfKinPhoneNoErrMsg = TestPatient.ValidateNextOfKinPhoneNo(SomeKinPhoneNo);
            Assert.AreEqual(NextOfKinPhoneNoErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value (40 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void NextOfKinPhoneNoMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKinPhoneNo = "";
            SomeKinPhoneNo = SomeKinPhoneNo.PadLeft(40);
            string ExpectedReturnMsg = "";
            string NextOfKinPhoneNoErrMsg = TestPatient.ValidateNextOfKinPhoneNo(SomeKinPhoneNo);
            Assert.AreEqual(NextOfKinPhoneNoErrMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 (41 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void NextOfKinMaxPhoneNoPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKinPhoneNo = "";
            SomeKinPhoneNo = SomeKinPhoneNo.PadLeft(41);
            string ExpectedReturnMsg = "Next Of Kin PhoneNo No more than 40 characters";
            string NextOfKinPhoneNoErrMsg = TestPatient.ValidateNextOfKinPhoneNo(SomeKinPhoneNo);
            Assert.AreEqual(NextOfKinPhoneNoErrMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 500 characters
        [TestMethod]
        public void NextOfKinPhoneNoExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeKinPhoneNo = "";
            SomeKinPhoneNo = SomeKinPhoneNo.PadLeft(500);
            string ExpectedReturnMsg = "Next Of Kin PhoneNo No more than 40 characters";
            string NextOfKinPhoneNoErrMsg = TestPatient.ValidateNextOfKinPhoneNo(SomeKinPhoneNo);
            Assert.AreEqual(NextOfKinPhoneNoErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for GP Details property of Patient **********/
        [TestMethod]
        public void GPDetailsPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeGPDetails = "General Practice Saffron";
            //assign the test data to the property
            TestPatient.GPDetails = SomeGPDetails;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.GPDetails, SomeGPDetails);
        }

        // test  for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void GPDetailsMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGPDetails = "";
            string ExpectedReturnMsg = "";
            string GPDetailsErrorMsg = TestPatient.ValidateGPDetails(SomeGPDetails);
            Assert.AreEqual(GPDetailsErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void GPDetailsMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGPDetails = "G";
            string ExpectedReturnMsg = "";
            string GPDetailsErrMsg = TestPatient.ValidateGPDetails(SomeGPDetails);
            Assert.AreEqual(GPDetailsErrMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void GPDetailsMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGPDetails = "Ge";
            string ExpectedReturnMsg = "";
            string GPDetailsErrMsg = TestPatient.ValidateGPDetails(SomeGPDetails);
            Assert.AreEqual(GPDetailsErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 (499 characters).  should return blank string (no error message)
        [TestMethod]
        public void GPDetailsMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGPDetails = "";
            SomeGPDetails = SomeGPDetails.PadLeft(499);
            string ExpectedReturnMsg = "";
            string GPDetailsErrMsg = TestPatient.ValidateGPDetails(SomeGPDetails);
            Assert.AreEqual(GPDetailsErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value (500 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void GPDetailsMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGPDetails = "";
            SomeGPDetails = SomeGPDetails.PadLeft(500);
            string ExpectedReturnMsg = "";
            string GPDetailsErrMsg = TestPatient.ValidateGPDetails(SomeGPDetails);
            Assert.AreEqual(GPDetailsErrMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 (501 characters).  should return error msg as 300 characters max
        [TestMethod]
        public void GPDetailsMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGPDetails = "";
            SomeGPDetails = SomeGPDetails.PadLeft(501);
            string ExpectedReturnMsg = "GP Details No more than 500 characters";
            string GPDetailsErrMsg = TestPatient.ValidateGPDetails(SomeGPDetails);
            Assert.AreEqual(GPDetailsErrMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 1000 characters
        [TestMethod]
        public void GPdetailsExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeGPDetails = "";
            SomeGPDetails = SomeGPDetails.PadLeft(1000);
            string ExpectedReturnMsg = "GP Details No more than 500 characters";
            string GPDetailsErrMsg = TestPatient.ValidateGPDetails(SomeGPDetails);
            Assert.AreEqual(GPDetailsErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for Notes property of Patient **********/
        [TestMethod]
        public void NotesPropertyOK()
        {
            // create an instance of the class we want to create
            clsPatient TestPatient = new clsPatient();
            //create some test data to assign to the property
            string SomeNotes = "James is very distressed";
            //assign the test data to the property
            TestPatient.Notes = SomeNotes;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestPatient.Notes, SomeNotes);
        }

        // test  for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void NotesMinLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeNotes = "";
            string ExpectedReturnMsg = "";
            string NotesErrorMsg = TestPatient.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void NotesMin()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeNotes = "C";
            string ExpectedReturnMsg = "";
            string NotesErrMsg = TestPatient.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void NotesMinPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeNotes = "Ca";
            string ExpectedReturnMsg = "";
            string NotesErrMsg = TestPatient.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 (999 characters).  should return blank string (no error message)
        [TestMethod]
        public void NotesMaxLessOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeNotes = "";
            SomeNotes = SomeNotes.PadLeft(999);
            string ExpectedReturnMsg = "";
            string NotesErrMsg = TestPatient.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value (1000 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void NotesMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeNotes = "";
            SomeNotes = SomeNotes.PadLeft(1000);
            string ExpectedReturnMsg = "";
            string NotesErrMsg = TestPatient.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 (1001 characters).  should return error msg as 1000 characters max
        [TestMethod]
        public void NotesMaxPlusOne()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeNotes = "";
            SomeNotes = SomeNotes.PadLeft(1001);
            string ExpectedReturnMsg = "Notes No more than 1000 characters";
            string NotesErrMsg = TestPatient.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 3000 characters
        [TestMethod]
        public void NotesExtremeMax()
        {
            clsPatient TestPatient = new clsPatient();
            string SomeNotes = "";
            SomeNotes = SomeNotes.PadLeft(3000);
            string ExpectedReturnMsg = "Notes No more than 1000 characters";
            string NotesErrMsg = TestPatient.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);
        }

        /**** Test WardNo Property ****/
        // only one test as data generated by system
        [TestMethod]
        public void WardNo()
        {
            clsPatient TestPatient = new clsPatient();
            TestPatient.WardNo = 1;
        }

        /*** Test TreatmentID Property ***/
        // only one test as data generated by system
        [TestMethod]
        public void TreatmentID()
        {
            clsPatient TestPatient = new clsPatient();
            TestPatient.TreatmentID = 1;
        }


    }
}


