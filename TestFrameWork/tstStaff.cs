using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceStaffOK()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestStaff);
        }

        /*Testing the attribute StaffID which is an auto generated number*/
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 SomeStaffID = 1;
            //assign the test data to the property
            TestStaff.StaffID = SomeStaffID;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.StaffID, SomeStaffID);
        }


        /******** Testing the attribute Title  with the min , max, mid boundaries********/
        [TestMethod]
        public void TitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeTitle = "Mr";
            //assign the test data to the property
            TestStaff.Title = SomeTitle;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.Title, SomeTitle);
        }

        [TestMethod]
        public void ValidateTitleMethodOK() // testing that the ValidateTitle() method really exists
        {
            clsStaff TestStaff = new clsStaff();
            //boolean variable to store the result of the validation method
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "Mr";
            //invoke the method ValidateTitle()
            OK = TestStaff.ValidateTitle(SomeTitle);
            //test to see that the result obtained is actually correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinLessOne() // 1 - 1 = 0 character
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with 0 character to assign to the property
            string SomeTitle = "";
            //invoke the method ValidateTitle()
            OK = TestStaff.ValidateTitle(SomeTitle);
            //test to see that the result is actually correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinBoundary() //  can have 1 character minimum
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with one character to assign to the property
            string SomeTitle = "M";
            //invoke the method ValidateTitle()
            OK = TestStaff.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMinPlusOne() // can have 1 + 1 = 2 characters
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with two characters to assign to the property
            string SomeTitle = "Mr";
            //invoke the method ValidateTitle()
            OK = TestStaff.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMaxLessOne() // can have 6 - 1 = 5 characters
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data with 5 characters to assign to the property
            string SomeTitle = "MrMrM";
            //invoke the method ValidateTitle()
            OK = TestStaff.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleMaxBoundary() //  Title can only have 6 characters max
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "MrMrMr";
            //invoke the method
            OK = TestStaff.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TitleMaxPlusOne() // 6 + 1 = 7 characters
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "MrMrMrMrM";
            //invoke the method
            OK = TestStaff.ValidateTitle(SomeTitle);
            //test to see that the result is correct , should not save this data 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TitleMid() //  6 / 2 = 3 characters
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "MrM";
            //invoke the method
            OK = TestStaff.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeTitle = "";
            //pad the string with w characters
            SomeTitle = SomeTitle.PadRight(50, 'w');
            //invoke the method
            OK = TestStaff.ValidateTitle(SomeTitle);
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }


        /******** Testing for FirstName property of Staff **********/
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeFirstName = "Roger";
            //assign the test data to the property
            TestStaff.FirstName = SomeFirstName;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.FirstName, SomeFirstName);
        }

        // test FirstName for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeFirstName = "";
            string ExpectedReturnMsg = "First Name cannot be blank";
            string FirstNameErrorMsg = TestStaff.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrorMsg, ExpectedReturnMsg);
        }
        // test FirstName for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void FirstNameMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeFirstName = "A";
            string ExpectedReturnMsg = "";
            string FirstNameErrorMsg = TestStaff.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrorMsg, ExpectedReturnMsg);
        }

        // test FirstName for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeFirstName = "Aa";
            string ExpectedReturnMsg = "";
            string FirstNameErrMsg = TestStaff.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);
        }

        // test FirstName for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeFirstName = "";
            SomeFirstName = SomeFirstName.PadLeft(49);
            string ExpectedReturnMsg = "";
            string FirstNameErrMsg = TestStaff.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);
        }

        // test FirstName for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void FirstNameMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeFirstName = "";
            SomeFirstName = SomeFirstName.PadLeft(50);
            string ExpectedReturnMsg = "";
            string FirstNameErrMsg = TestStaff.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);
        }
        // test FirstName for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeFirstName = "";
            SomeFirstName = SomeFirstName.PadLeft(51);
            string ExpectedReturnMsg = "First Name No more than 50 characters";
            string FirstNameErrMsg = TestStaff.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);

        }
        // test FirstName for its extreme max value being 500 characters
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeFirstName = "";
            SomeFirstName = SomeFirstName.PadLeft(500);
            string ExpectedReturnMsg = "First Name No more than 50 characters";
            string FirstNameErrMsg = TestStaff.ValidateFirstName(SomeFirstName);
            Assert.AreEqual(FirstNameErrMsg, ExpectedReturnMsg);
        }



        /******** Testing for LastName property of Staff **********/
        [TestMethod]
        public void LastNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeLastName = "Riggs";
            //assign the test data to the property
            TestStaff.LastName = SomeLastName;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.LastName, SomeLastName);
        }

        // test LastName for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLastName = "";
            string ExpectedReturnMsg = "Last Name cannot be blank";
            string LastNameErrorMsg = TestStaff.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrorMsg, ExpectedReturnMsg);
        }
        // test LastName for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void LastNameMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLastName = "A";
            string ExpectedReturnMsg = "";
            string LastNameErrorMsg = TestStaff.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrorMsg, ExpectedReturnMsg);
        }

        // test LastName for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLastName = "Aa";
            string ExpectedReturnMsg = "";
            string LastNameErrMsg = TestStaff.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);
        }

        // test LastName for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLastName = "";
            SomeLastName = SomeLastName.PadLeft(49);
            string ExpectedReturnMsg = "";
            string LastNameErrMsg = TestStaff.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);
        }

        // test LastName for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void LastNameMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLastName = "";
            SomeLastName = SomeLastName.PadLeft(50);
            string ExpectedReturnMsg = "";
            string LastNameErrMsg = TestStaff.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);
        }
        // test LastName for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLastName = "";
            SomeLastName = SomeLastName.PadLeft(51);
            string ExpectedReturnMsg = "Last Name No more than 50 characters";
            string LastNameErrMsg = TestStaff.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);
        }
        // test the extreme max of the LastName
        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsStaff TestStaff= new clsStaff();
            string SomeLastName = "";
            SomeLastName = SomeLastName.PadLeft(500);
            string ExpectedReturnMsg = "Last Name No more than 50 characters";
            string LastNameErrMsg = TestStaff.ValidateLastName(SomeLastName);
            Assert.AreEqual(LastNameErrMsg, ExpectedReturnMsg);

        }

        /******** Testing for Gender property **********/
        [TestMethod]
        public void GenderPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeGender = "Female";
            //assign the test data to the property
            TestStaff.Gender = SomeGender;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.Gender, SomeGender);
        }

        // test Gender for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void GenderMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeGender = "";
            string ExpectedReturnMsg = "Gender cannot be blank";
            string GenderErrorMsg = TestStaff.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrorMsg, ExpectedReturnMsg);
        }
        // test Gender for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void GenderMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeGender = "F";
            string ExpectedReturnMsg = "";
            string GenderErrorMsg = TestStaff.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrorMsg, ExpectedReturnMsg);
        }

        // test Gender for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void GenderMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeGender = "Fe";
            string ExpectedReturnMsg = "";
            string GenderErrMsg = TestStaff.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);
        }

        // test Gender for maximum value minus 1 (11 characters). should return blank string (no error message)
        [TestMethod]
        public void GenderMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeGender = "";
            SomeGender = SomeGender.PadLeft(11);
            string ExpectedReturnMsg = "";
            string GenderErrMsg = TestStaff.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);
        }

        // test Gender for maximum value (12 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void GenderMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeGender = "";
            SomeGender = SomeGender.PadLeft(12);
            string ExpectedReturnMsg = "";
            string GenderErrMsg = TestStaff.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);
        }
        // test Gender for maximum value plus 1 (13 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void GenderMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeGender = "";
            SomeGender = SomeGender.PadLeft(13);
            string ExpectedReturnMsg = "Gender No more than 12 characters";
            string GenderErrMsg = TestStaff.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the Gender which is 50 characters
        [TestMethod]
        public void GenderExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeGender = "";
            SomeGender = SomeGender.PadLeft(50);
            string ExpectedReturnMsg = "Gender No more than 12 characters";
            string GenderErrMsg = TestStaff.ValidateGender(SomeGender);
            Assert.AreEqual(GenderErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for UserName property **********/
        [TestMethod]
        public void UserNamePropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeUserName = "rriff";
            //assign the test data to the property
            TestStaff.UserName = SomeUserName;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.UserName, SomeUserName);
        }

        // test UserName for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void UserNameMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeUserName = "";
            string ExpectedReturnMsg = "";
            string UserNameErrorMsg = TestStaff.ValidateUserName(SomeUserName);
            Assert.AreEqual(UserNameErrorMsg, ExpectedReturnMsg);
        }
        // test UserName for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void UserNameMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeUserName = "r";
            string ExpectedReturnMsg = "";
            string UserNameErrorMsg = TestStaff.ValidateUserName(SomeUserName);
            Assert.AreEqual(UserNameErrorMsg, ExpectedReturnMsg);
        }

        // test UserName for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void UserNameMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeUserName = "th";
            string ExpectedReturnMsg = "";
            string UserNameErrMsg = TestStaff.ValidateUserName(SomeUserName);
            Assert.AreEqual(UserNameErrMsg, ExpectedReturnMsg);
        }

        // test UserName for maximum value minus 1 (11 characters). should return blank string (no error message)
        [TestMethod]
        public void UserNameMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeUserName = "";
            SomeUserName = SomeUserName.PadLeft(11);
            string ExpectedReturnMsg = "";
            string UserNameErrMsg = TestStaff.ValidateUserName(SomeUserName);
            Assert.AreEqual(UserNameErrMsg, ExpectedReturnMsg);
        }

        // test UserName for maximum value (12 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void UserNameMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeUserName = "";
            SomeUserName = SomeUserName.PadLeft(12);
            string ExpectedReturnMsg = "";
            string UserNameErrMsg = TestStaff.ValidateUserName(SomeUserName);
            Assert.AreEqual(UserNameErrMsg, ExpectedReturnMsg);
        }
        // test UserName for maximum value plus 1 (13 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeUserName = "";
            SomeUserName = SomeUserName.PadLeft(13);
            string ExpectedReturnMsg = "UserName No more than 12 characters";
            string UserNameErrMsg = TestStaff.ValidateUserName(SomeUserName);
            Assert.AreEqual(UserNameErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the UserName which is 50 characters
        [TestMethod]
        public void UserNameExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeUserName = "";
            SomeUserName = SomeUserName.PadLeft(50);
            string ExpectedReturnMsg = "UserName No more than 12 characters";
            string UserNameErrMsg = TestStaff.ValidateUserName(SomeUserName);
            Assert.AreEqual(UserNameErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for Password property **********/
        [TestMethod]
        public void PasswordPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomePassword = "roriff1";
            //assign the test data to the property
            TestStaff.Password = SomePassword;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.Password, SomePassword);
        }

        // test Password for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void PasswordMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePassword = "";
            string ExpectedReturnMsg = "";
            string PasswordErrorMsg = TestStaff.ValidatePassword(SomePassword);
            Assert.AreEqual(PasswordErrorMsg, ExpectedReturnMsg);
        }
        // test Password for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void PasswordMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePassword = "r";
            string ExpectedReturnMsg = "";
            string PasswordErrorMsg = TestStaff.ValidatePassword(SomePassword);
            Assert.AreEqual(PasswordErrorMsg, ExpectedReturnMsg);
        }

        // test Password for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePassword = "th";
            string ExpectedReturnMsg = "";
            string PasswordErrMsg = TestStaff.ValidatePassword(SomePassword);
            Assert.AreEqual(PasswordErrMsg, ExpectedReturnMsg);
        }

        // test Password for maximum value minus 1 (7 characters). should return blank string (no error message)
        [TestMethod]
        public void PasswordMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePassword = "";
            SomePassword = SomePassword.PadLeft(7);
            string ExpectedReturnMsg = "";
            string PasswordErrMsg = TestStaff.ValidatePassword(SomePassword);
            Assert.AreEqual(PasswordErrMsg, ExpectedReturnMsg);
        }

        // test Password for maximum value (8 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void PasswordMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePassword = "";
            SomePassword = SomePassword.PadLeft(8);
            string ExpectedReturnMsg = "";
            string PasswordErrMsg = TestStaff.ValidatePassword(SomePassword);
            Assert.AreEqual(PasswordErrMsg, ExpectedReturnMsg);
        }
        // test Password for maximum value plus 1 (9 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePassword = "";
            SomePassword = SomePassword.PadLeft(9);
            string ExpectedReturnMsg = "Password No more than 8 characters";
            string PasswordErrMsg = TestStaff.ValidatePassword(SomePassword);
            Assert.AreEqual(PasswordErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the UserName which is 50 characters
        [TestMethod]
        public void PaswordExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePassword = "";
            SomePassword = SomePassword.PadLeft(50);
            string ExpectedReturnMsg = "Password No more than 8 characters";
            string PasswordErrMsg = TestStaff.ValidatePassword(SomePassword);
            Assert.AreEqual(PasswordErrMsg, ExpectedReturnMsg);
        }


        /******** Testing for Industry sector.. this will be a drop down list 
         * So just need to test the attribute is OK **********/
        [TestMethod]
        public void IndustrySectorPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeIndustry = "Hopistal";
            //assign the test data to the property
            TestStaff.IndustrySector = SomeIndustry;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.IndustrySector, SomeIndustry);
        }

        /******** Testing for Position property **********/
        [TestMethod]
        public void PositionPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomePosition = "Doctor";
            //assign the test data to the property
            TestStaff.Position = SomePosition;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.Position, SomePosition);
        }

        // test Position for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void PositionMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePosition = "";
            string ExpectedReturnMsg = "Position cannot be blank";
            string PositionErrorMsg = TestStaff.ValidatePosition(SomePosition);
            Assert.AreEqual(PositionErrorMsg, ExpectedReturnMsg);
        }
        // test Position for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void PositionMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePosition = "D";
            string ExpectedReturnMsg = "";
            string PositionErrorMsg = TestStaff.ValidatePosition(SomePosition);
            Assert.AreEqual(PositionErrorMsg, ExpectedReturnMsg);
        }

        // test Position for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void PositionMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePosition = "Do";
            string ExpectedReturnMsg = "";
            string PositionErrMsg = TestStaff.ValidatePosition(SomePosition);
            Assert.AreEqual(PositionErrMsg, ExpectedReturnMsg);
        }

        // test Position for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void PositionMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePosition = "";
            SomePosition = SomePosition.PadLeft(49);
            string ExpectedReturnMsg = "";
            string PositionErrMsg = TestStaff.ValidatePosition(SomePosition);
            Assert.AreEqual(PositionErrMsg, ExpectedReturnMsg);
        }

        // test Position for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void PositionMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePosition = "";
            SomePosition = SomePosition.PadLeft(50);
            string ExpectedReturnMsg = "";
            string PositionErrMsg = TestStaff.ValidatePosition(SomePosition);
            Assert.AreEqual(PositionErrMsg, ExpectedReturnMsg);
        }
        // test Position for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void PositionMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePosition = "";
            SomePosition = SomePosition.PadLeft(51);
            string ExpectedReturnMsg = "Position No more than 50 characters";
            string PositionErrMsg = TestStaff.ValidatePosition(SomePosition);
            Assert.AreEqual(PositionErrMsg, ExpectedReturnMsg);
        }
        // test Position for its extreme max value being 500 characters
        [TestMethod]
        public void PositionExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePosition = "";
            SomePosition = SomePosition.PadLeft(500);
            string ExpectedReturnMsg = "Position No more than 50 characters";
            string PositionErrMsg = TestStaff.ValidatePosition(SomePosition);
            Assert.AreEqual(PositionErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for Highest qualification property **********/
        [TestMethod]
        public void HighestQualificationPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeQualification = "Phd";
            //assign the test data to the property
            TestStaff.HighestQualification = SomeQualification;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.HighestQualification, SomeQualification);
        }

        // test Highest qualification for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void HighestQualificationMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeQualification = "";
            string ExpectedReturnMsg = "";
            string QualificationErrorMsg = TestStaff.ValidateQualification(SomeQualification);
            Assert.AreEqual(QualificationErrorMsg, ExpectedReturnMsg);
        }
        // test HighestQualification for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void HighestQualificationMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeQualification = "P";
            string ExpectedReturnMsg = "";
            string QualificatioErrorMsg = TestStaff.ValidateQualification(SomeQualification);
            Assert.AreEqual(QualificatioErrorMsg, ExpectedReturnMsg);
        }

        // test HighestQualification for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void HighestQualificationMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeQualification = "Ph";
            string ExpectedReturnMsg = "";
            string QualificationErrMsg = TestStaff.ValidateQualification(SomeQualification);
            Assert.AreEqual(QualificationErrMsg, ExpectedReturnMsg);
        }

        // test  HighestQualification for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void HighestQualificationMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeQualification = "";
            SomeQualification = SomeQualification.PadLeft(49);
            string ExpectedReturnMsg = "";
            string QualificationErrMsg = TestStaff.ValidateQualification(SomeQualification);
            Assert.AreEqual(QualificationErrMsg, ExpectedReturnMsg);
        }

        // test HighestQualification for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void HighestQualificationMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeQualification = "";
            SomeQualification = SomeQualification.PadLeft(50);
            string ExpectedReturnMsg = "";
            string QualificationErrMsg = TestStaff.ValidateQualification(SomeQualification);
            Assert.AreEqual(QualificationErrMsg, ExpectedReturnMsg);
        }
        // test HighestQualification for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void HighestQualificationMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeQualification = "";
            SomeQualification = SomeQualification.PadLeft(51);
            string ExpectedReturnMsg = "Qualification No more than 50 characters";
            string QualificationErrMsg = TestStaff.ValidateQualification(SomeQualification);
            Assert.AreEqual(QualificationErrMsg, ExpectedReturnMsg);

        }
        // test HighestQualification for its extreme max value being 500 characters
        [TestMethod]
        public void HighestQualificationExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeQualification = "";
            SomeQualification = SomeQualification.PadLeft(500);
            string ExpectedReturnMsg = "Qualification No more than 50 characters";
            string QualificationErrMsg = TestStaff.ValidateQualification(SomeQualification);
            Assert.AreEqual(QualificationErrMsg, ExpectedReturnMsg);
        }


        /******** Testing for Street property **********/
        [TestMethod]
        public void StreetPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeStreet = "31 Stanton";
            //assign the test data to the property
            TestStaff.Street = SomeStreet;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.Street, SomeStreet);
        }

        // test Street for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void StreetMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeStreet = "";
            string ExpectedReturnMsg = "Street cannot be blank";
            string StreetErrorMsg = TestStaff.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrorMsg, ExpectedReturnMsg);
        }
        // test Street for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void StreetMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeStreet = "S";
            string ExpectedReturnMsg = "";
            string StreetErrorMsg = TestStaff.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrorMsg, ExpectedReturnMsg);
        }

        // test Street for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void StreetMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeStreet = "St";
            string ExpectedReturnMsg = "";
            string StreetErrMsg = TestStaff.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }

        // test Street for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void StreetMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeStreet = "";
            SomeStreet = SomeStreet.PadLeft(49);
            string ExpectedReturnMsg = "";
            string StreetErrMsg = TestStaff.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }

        // test Street for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void StreetMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeStreet = "";
            SomeStreet = SomeStreet.PadLeft(50);
            string ExpectedReturnMsg = "";
            string StreetErrMsg = TestStaff.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }
        // test Street for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void StreetMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeStreet = "";
            SomeStreet = SomeStreet.PadLeft(51);
            string ExpectedReturnMsg = "Street No more than 50 characters";
            string StreetErrMsg = TestStaff.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }
        // test Street for its extreme max value being 500 characters
        [TestMethod]
        public void StreetExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeStreet = "";
            SomeStreet = SomeStreet.PadLeft(500);
            string ExpectedReturnMsg = "Street No more than 50 characters";
            string StreetErrMsg = TestStaff.ValidateStreet(SomeStreet);
            Assert.AreEqual(StreetErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for Town property **********/
        [TestMethod]
        public void TownPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeTown = "Yeoville";
            //assign the test data to the property
            TestStaff.Town = SomeTown;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.Town, SomeTown);
        }

        // test Town for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void TownMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeTown = "";
            string ExpectedReturnMsg = "Town cannot be blank";
            string TownErrorMsg = TestStaff.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrorMsg, ExpectedReturnMsg);
        }
        // test Town for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void TownMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeTown = "Y";
            string ExpectedReturnMsg = "";
            string TownErrorMsg = TestStaff.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrorMsg, ExpectedReturnMsg);
        }

        // test Town for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void TownMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeTown = "St";
            string ExpectedReturnMsg = "";
            string TownErrMsg = TestStaff.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);
        }

        // test Town for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void TownMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeTown = "";
            SomeTown = SomeTown.PadLeft(49);
            string ExpectedReturnMsg = "";
            string TownErrMsg = TestStaff.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);
        }

        // test Town for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void TownMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeTown = "";
            SomeTown = SomeTown.PadLeft(50);
            string ExpectedReturnMsg = "";
            string TownErrMsg = TestStaff.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);
        }
        // test Town for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void TownMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeTown = "";
            SomeTown = SomeTown.PadLeft(51);
            string ExpectedReturnMsg = "Town No more than 50 characters";
            string TownErrMsg = TestStaff.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);

        }
        // test Town for its extreme max value being 500 characters
        [TestMethod]
        public void TownExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeTown = "";
            SomeTown = SomeTown.PadLeft(500);
            string ExpectedReturnMsg = "Town No more than 50 characters";
            string TownErrMsg = TestStaff.ValidateTown(SomeTown);
            Assert.AreEqual(TownErrMsg, ExpectedReturnMsg);
        }



        /******** Testing for County property **********/
        [TestMethod]
        public void CountyPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeCounty = "Leicestershire";
            //assign the test data to the property
            TestStaff.County = SomeCounty;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.County, SomeCounty);
        }

        // test County for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void CountyMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeCounty = "";
            string ExpectedReturnMsg = "";
            string CountyErrorMsg = TestStaff.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrorMsg, ExpectedReturnMsg);
        }
        // test County for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void CountyMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeCounty = "Y";
            string ExpectedReturnMsg = "";
            string CountyErrorMsg = TestStaff.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrorMsg, ExpectedReturnMsg);
        }

        // test County for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void CountyMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeCounty = "St";
            string ExpectedReturnMsg = "";
            string CountyErrMsg = TestStaff.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);
        }

        // test County for maximum value minus 1 (49 characters).  should return blank string (no error message)
        [TestMethod]
        public void CountyMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeCounty = "";
            SomeCounty = SomeCounty.PadLeft(49);
            string ExpectedReturnMsg = "";
            string CountyErrMsg = TestStaff.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);
        }

        // test County for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void CountyMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeCounty = "";
            SomeCounty = SomeCounty.PadLeft(50);
            string ExpectedReturnMsg = "";
            string CountyErrMsg = TestStaff.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);
        }
        // test County for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void CountyMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeCounty = "";
            SomeCounty = SomeCounty.PadLeft(51);
            string ExpectedReturnMsg = "County No more than 50 characters";
            string CountyErrMsg = TestStaff.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);

        }
        // test County for its extreme max value being 500 characters
        [TestMethod]
        public void CountyExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeCounty = "";
            SomeCounty = SomeCounty.PadLeft(500);
            string ExpectedReturnMsg = "County No more than 50 characters";
            string CountyErrMsg = TestStaff.ValidateCounty(SomeCounty);
            Assert.AreEqual(CountyErrMsg, ExpectedReturnMsg);
        }


        /******** Testing for PostCode property  **********/
        [TestMethod]
        public void PostCodePropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomePostCode = "LE3 7GH";
            //assign the test data to the property
            TestStaff.PostCode = SomePostCode;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.PostCode, SomePostCode);
        }

        // test PostCode for blank string. should return error msg as it is a required attribute
        [TestMethod]
        public void PostCodeMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePostCode = "";
            string ExpectedReturnMsg = "PostCode cannot be blank";
            string PostCodeErrorMsg = TestStaff.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrorMsg, ExpectedReturnMsg);
        }
        // test PostCode for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void PostCodeMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePostCode = "L";
            string ExpectedReturnMsg = "";
            string PostCodeErrorMsg = TestStaff.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrorMsg, ExpectedReturnMsg);
        }

        // test PostCode for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePostCode = "LE";
            string ExpectedReturnMsg = "";
            string PostCodeErrMsg = TestStaff.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);
        }

        // test PostCode for maximum value minus 1 (9 characters). should return blank string (no error message)
        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePostCode = "";
            SomePostCode = SomePostCode.PadLeft(9);
            string ExpectedReturnMsg = "";
            string PostCodeErrMsg = TestStaff.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);
        }

        // test PostCode for maximum value (10 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void PostCodeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePostCode = "";
            SomePostCode = SomePostCode.PadLeft(10);
            string ExpectedReturnMsg = "";
            string PostCodeErrMsg = TestStaff.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);
        }
        // test PostCode for maximum value plus 1 (11 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePostCode = "";
            SomePostCode = SomePostCode.PadLeft(11);
            string ExpectedReturnMsg = "PostCode No more than 10 characters";
            string PostCodeErrMsg = TestStaff.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the PostCode which is 50 characters
        [TestMethod]
        public void PostCodeExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomePostCode = "";
            SomePostCode = SomePostCode.PadLeft(50);
            string ExpectedReturnMsg = "PostCode No more than 10 characters";
            string PostCodeErrMsg = TestStaff.ValidatePostCode(SomePostCode);
            Assert.AreEqual(PostCodeErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for LandlineNo property **********/
        [TestMethod]
        public void LandlineNoPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeLandlineNo = "01162342635";
            //assign the test data to the property
            TestStaff.LandlineNo = SomeLandlineNo;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.LandlineNo, SomeLandlineNo);
        }

        // test LandlineNo for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void LandlineNoMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLandlineNo = "";
            string ExpectedReturnMsg = "";
            string LandlineErrorMsg = TestStaff.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrorMsg, ExpectedReturnMsg);
        }
        // test LandlineNo for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void LandlineNoMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLandlineNo = "0";
            string ExpectedReturnMsg = "";
            string LandlineErrorMsg = TestStaff.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrorMsg, ExpectedReturnMsg);
        }

        // test LandlineNo for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void LandlineNoMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLandlineNo = "01";
            string ExpectedReturnMsg = "";
            string LandlineErrMsg = TestStaff.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);
        }

        // test LandlineNo for maximum value minus 1 (14 characters). should return blank string (no error message)
        [TestMethod]
        public void LandlineNoMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLandlineNo = "";
            SomeLandlineNo = SomeLandlineNo.PadLeft(14);
            string ExpectedReturnMsg = "";
            string LandlineErrMsg = TestStaff.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);
        }

        // test LandlineNo for maximum value (15 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void LandlineNoMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLandlineNo = "";
            SomeLandlineNo = SomeLandlineNo.PadLeft(15);
            string ExpectedReturnMsg = "";
            string LandlineErrMsg = TestStaff.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);
        }
        // test LandlineNo for maximum value plus 1 (16 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void LandlineNoMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLandlineNo = "";
            SomeLandlineNo = SomeLandlineNo.PadLeft(16);
            string ExpectedReturnMsg = "LandLineNo No more than 15 characters";
            string LandlineErrMsg = TestStaff.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the landline which is 50 characters
        [TestMethod]
        public void LandlineExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeLandlineNo = "";
            SomeLandlineNo = SomeLandlineNo.PadLeft(50);
            string ExpectedReturnMsg = "LandLineNo No more than 15 characters";
            string LandlineErrMsg = TestStaff.ValidateLandlineNo(SomeLandlineNo);
            Assert.AreEqual(LandlineErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for MobileNo property **********/
        [TestMethod]
        public void MobileNoPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeMobileNo = "07762342635";
            //assign the test data to the property
            TestStaff.MobileNo = SomeMobileNo;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.MobileNo, SomeMobileNo);
        }

        // test MobileNo for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void MobileNoMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeMobileNo = "";
            string ExpectedReturnMsg = "";
            string MobileErrorMsg = TestStaff.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrorMsg, ExpectedReturnMsg);
        }
        // test MobileNo for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void MobileNoMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeMobileNo = "0";
            string ExpectedReturnMsg = "";
            string MobileErrorMsg = TestStaff.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrorMsg, ExpectedReturnMsg);
        }

        // test MobileNo for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void MobileNoMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeMobileNo = "01";
            string ExpectedReturnMsg = "";
            string MobileErrMsg = TestStaff.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrMsg, ExpectedReturnMsg);
        }

        // test MobileNo for maximum value minus 1 (14 characters). should return blank string (no error message)
        [TestMethod]
        public void MobileNoMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeMobileNo = "";
            SomeMobileNo = SomeMobileNo.PadLeft(14);
            string ExpectedReturnMsg = "";
            string MobileNoErrMsg = TestStaff.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileNoErrMsg, ExpectedReturnMsg);
        }

        // test MobileNo for maximum value (15 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void MobileNoMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeMobileNo = "";
            SomeMobileNo = SomeMobileNo.PadLeft(15);
            string ExpectedReturnMsg = "";
            string MobileErrMsg = TestStaff.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrMsg, ExpectedReturnMsg);
        }
        // test MobileNo for maximum value plus 1 (16 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void MobileNoMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeMobileNo = "";
            SomeMobileNo = SomeMobileNo.PadLeft(16);
            string ExpectedReturnMsg = "MobileNo No more than 15 characters";
            string MobileErrMsg = TestStaff.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the MobileNo which is 50 characters
        [TestMethod]
        public void MobileExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeMobileNo = "";
            SomeMobileNo = SomeMobileNo.PadLeft(50);
            string ExpectedReturnMsg = "MobileNo No more than 15 characters";
            string MobileNoErrMsg = TestStaff.ValidateMobileNo(SomeMobileNo);
            Assert.AreEqual(MobileNoErrMsg, ExpectedReturnMsg);
        }

        /******** Testing for EmailAddress property **********/
        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaff TestStaff = new clsStaff();
            //create some test data to assign to the property
            string SomeEmail = "theriff27@yahoo.com";
            //assign the test data to the property
            TestStaff.EmailAddress = SomeEmail;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestStaff.EmailAddress, SomeEmail);
        }

        // test EmailAddress for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeEmail = "";
            string ExpectedReturnMsg = "";
            string EmailErrorMsg = TestStaff.ValidateEmail(SomeEmail);
            Assert.AreEqual(EmailErrorMsg, ExpectedReturnMsg);
        }
        // test Email for minimum value. should accept it and return blank string (no error message)
        [TestMethod]
        public void EmailMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeEmail = "t";
            string ExpectedReturnMsg = "";
            string EmailErrorMsg = TestStaff.ValidateEmail(SomeEmail);
            Assert.AreEqual(EmailErrorMsg, ExpectedReturnMsg);
        }

        // test Email for minimum value plus 1 (2 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeEmail = "th";
            string ExpectedReturnMsg = "";
            string EmailErrMsg = TestStaff.ValidateEmail(SomeEmail);
            Assert.AreEqual(EmailErrMsg, ExpectedReturnMsg);
        }

        // test Email for maximum value minus 1 (49 characters). should return blank string (no error message)
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadLeft(49);
            string ExpectedReturnMsg = "";
            string EmailErrMsg = TestStaff.ValidateEmail(SomeEmail);
            Assert.AreEqual(EmailErrMsg, ExpectedReturnMsg);
        }

        // test Email for maximum value (50 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void EmailMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadLeft(50);
            string ExpectedReturnMsg = "";
            string EmailErrMsg = TestStaff.ValidateEmail(SomeEmail);
            Assert.AreEqual(EmailErrMsg, ExpectedReturnMsg);
        }
        // test Email for maximum value plus 1 (51 characters).  should return error msg as 50 characters max
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeEmail = "";
            SomeEmail = SomeEmail.PadLeft(51);
            string ExpectedReturnMsg = "Email No more than 50 characters";
            string EmailErrMsg = TestStaff.ValidateEmail(SomeEmail);
            Assert.AreEqual(EmailErrMsg, ExpectedReturnMsg);

        }
        // test the extreme max of the Email which is 500 characters
        [TestMethod]
        public void EmailExtremeMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeEmail= "";
            SomeEmail = SomeEmail.PadLeft(500);
            string ExpectedReturnMsg = "Email No more than 50 characters";
            string EmailErrMsg = TestStaff.ValidateEmail(SomeEmail);
            Assert.AreEqual(EmailErrMsg, ExpectedReturnMsg);
        }


        /*****  Testing for DateJoined Property of the staff *****/
        // only test as the date is generated by the system as the actual day date when the satff is joining
        [TestMethod]
        public void DateJoined()
        {
            clsStaff TestStaff = new clsStaff();
            TestStaff.DateJoined = DateTime.Now;
        }

        // Test the Min of dateJoined
        [TestMethod]
        public void DateJoinedMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeDateJoined = Convert.ToString(DateTime.Today);
            //SomeDateJoined = TestStaff.DateJoined;
            string ExpectedReturnMsg = "";
            string DateJoinedErrMsg = TestStaff.ValidateDateJoined(SomeDateJoined);
            Assert.AreEqual(DateJoinedErrMsg, ExpectedReturnMsg);
        }


        // Test the Max of DateJoined
        [TestMethod]
        public void DateJoinedMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeDateJoined = Convert.ToString(DateTime.Today);
            string ExpectedReturnMsg = "";
            string DateJoinedErrMsg = TestStaff.ValidateDateJoined(SomeDateJoined);
            Assert.AreEqual(DateJoinedErrMsg, ExpectedReturnMsg);

        }

        // Test the Min of date Left
        [TestMethod]
        public void DateLeftMin()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeDateLeft = Convert.ToString(DateTime.Now);
            //SomeDateLeft = TestStaff.DateLeft;
            string ExpectedReturnMsg = "";
            string DateLeftErrMsg = TestStaff.ValidateDateLeft(SomeDateLeft);
            Assert.AreEqual(DateLeftErrMsg, ExpectedReturnMsg);
        }

        // Test the Max of date left
        [TestMethod]
        public void DateLeftMax()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeDateLeft = Convert.ToString(DateTime.Now);
            string ExpectedReturnMsg = "";
            string DateLeftErrMsg = TestStaff.ValidateDateLeft(SomeDateLeft);
            Assert.AreEqual(DateLeftErrMsg, ExpectedReturnMsg);

        }


        // Test the Max+1 of date left
        [TestMethod]
        public void DateLeftMaxPlusOne()
        {
            clsStaff TestStaff = new clsStaff();
            string SomeDateLeft = Convert.ToString(DateTime.Now.AddDays(1));
            string ExpectedReturnMsg = "";
            string DateLeftErrMsg = TestStaff.ValidateDateLeft(SomeDateLeft);
            Assert.AreEqual(DateLeftErrMsg, ExpectedReturnMsg);

        }




    }
}
