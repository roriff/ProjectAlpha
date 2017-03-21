using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private variables
        private Int32 staffID;
        private string title;
        private string firstName;
        private string lastName;
        private string gender;
        private string userName;
        private string password;
        private string industrySector;
        private string position;
        private string highestQualification;
        private string street;
        private string town;
        private string county;
        private string postCode;
        private string landlineNo;
        private string mobileNo;
        private string emailAddress;
        private DateTime dateJoined;
        private DateTime dateLeft;

        private string staffDetails; // variable to display the staff details on the list

        private string staffLoginDetails; // variable to display the staff details on the list



        //Now we de-encapsulate them variables by creating the variables individual public property making them public
        public Int32 StaffID { get { return staffID; } set { staffID = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string UserName { get { return userName; } set {userName = value; } }
        public string Password { get { return password; } set { password= value; } }
        public string IndustrySector { get { return industrySector; } set { industrySector= value; } }
        public string Position { get { return position; } set { position = value; } }
        public string HighestQualification { get { return highestQualification; } set {highestQualification = value; } }
        public string Street { get { return street; } set { street = value; } }
        public string Town { get { return town; } set { town = value; } }
        public string County { get { return county; } set { county = value; } }
        public string PostCode { get { return postCode; } set { postCode = value; } }
        public string LandlineNo { get { return landlineNo; } set { landlineNo = value; } }
        public string MobileNo { get { return mobileNo; } set { mobileNo = value; } }
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }

        public DateTime DateJoined { get { return dateJoined; } set { dateJoined = value; } }
        public DateTime DateLeft { get { return dateLeft; } set { dateLeft = value; } }

        public string StaffDetails { get { return staffDetails; } set { staffDetails = value; } }

        public string StaffLoginDetails { get { return staffLoginDetails; } set { staffLoginDetails = value; } }
        
        
        /**** Validation methods for each attribute so when user enters data each 
         attribute is tested individually *****/

        // Validate Title data entered
        public bool ValidateTitle(string Title)
        {
            //boolean attribute to indicate that everything is OK
            Boolean OK = true;
            //if the title of the patient  is blank
            if (Title == "")
            {
                // it is Ok
                return OK;
            }
            //if the title is more than 6 characters
            if (Title.Length > 6)
            {
                //show an error
                OK = false;
            }

            return OK;
        }

        // validate Title length for a string, the previous validate title is bool and is not useful for a string
        public string ValidateTitleString(string Title)
        {
            string TitleErrMsg = "";

            if (Title.Length == 0)
            {
                return TitleErrMsg;
            }
            else if (Title.Length > 6)
            {
                TitleErrMsg = "Title No more than 6 characters";
            }
            return TitleErrMsg;
        }


        // validate FirstName data entered.  Required attribute.  Return error msg if blank string or too many characters entered
        public string ValidateFirstName(string FirstName)
        {
            string FirstNameErrMsg = "";

            if (FirstName.Length == 0)
            {
                FirstNameErrMsg = "First Name cannot be blank";
            }
            else if (FirstName.Length > 50)
            {
                FirstNameErrMsg = "First Name No more than 50 characters";
            }
            return FirstNameErrMsg;
        }

        // validate LastName data entered.  Required attribute.  Return error msg if blank string or too many characters entered
        public string ValidateLastName(string LastName)
        {
            string LastNameErrMsg = "";

            if (LastName.Length == 0)
            {
                LastNameErrMsg = "Last Name cannot be blank";
            }
            else if (LastName.Length > 50)
            {
                LastNameErrMsg = "Last Name No more than 50 characters";
            }
            return LastNameErrMsg;
        }

        // validate Gender 
        public string ValidateGender(string Gender)
        {
            string GenderErrMsg = "";

            if (Gender.Length == 0)
            {
                GenderErrMsg = "Gender cannot be blank";
            }
            else if (Gender.Length > 12)
            {
                GenderErrMsg = "Gender No more than 12 characters";
            }
            return GenderErrMsg;
        }


        //Validate UserName
        public string ValidateUserName(string UserName)
        {
            string UserNameErrMsg = "";

            if (UserName.Length == 0)
            {
                return UserNameErrMsg;
            }
            else if (UserName.Length > 12)
            {
                UserNameErrMsg = "UserName No more than 12 characters";
            }
            return UserNameErrMsg;

        }

        //Validate Password
        public string ValidatePassword(string Password)
        {
            string PasswordErrMsg = "";

            if (Password.Length == 0)
            {
                return PasswordErrMsg;
            }
            else if (Password.Length > 8)
            {
                PasswordErrMsg = "Password No more than 8 characters";
            }
            return PasswordErrMsg;

        }


        // Validate Industry Sector
        public string ValidateIndustrySector(string IndustrySector)
        {
            string IndustrySectorErrMsg = "";

            if (IndustrySector.Length == 0)
            {
                IndustrySectorErrMsg = "Industry Sector cannot be blank";
            }
            else if (IndustrySector.Length > 50)
            {
                IndustrySectorErrMsg = "Industry Sector No more than 50 characters";
            }
            return IndustrySectorErrMsg;
        }


        // Validate position
        public string ValidatePosition(string Position)
        {
            string PositionErrMsg = "";

            if (Position.Length == 0)
            {
                PositionErrMsg = "Position cannot be blank";
            }
            else if (Position.Length > 50)
            {
                PositionErrMsg = "Position No more than 50 characters";
            }
            return PositionErrMsg;
        }

        // validate Qualification
        public string ValidateQualification(string HighestQualification)
        {
            string QualificationErrMsg = "";

            if (HighestQualification.Length == 0)
            {
                return QualificationErrMsg;
            }
            else if (HighestQualification.Length > 50)
            {
                QualificationErrMsg = "Qualification No more than 50 characters";
            }
            return QualificationErrMsg;

        }


        // Validate Street 
        public string ValidateStreet(string Street)
        {
            string StreetErrMsg = "";

            if (Street.Length == 0)
            {
                StreetErrMsg = "Street cannot be blank";
            }
            else if (Street.Length > 50)
            {
                StreetErrMsg = "Street No more than 50 characters";
            }
            return StreetErrMsg;
        }

        // Validate Town 
        public string ValidateTown(string Town)
        {
            string TownErrMsg = "";

            if (Town.Length == 0)
            {
                TownErrMsg = "Town cannot be blank";
            }
            else if (Town.Length > 50)
            {
                TownErrMsg = "Town No more than 50 characters";
            }
            return TownErrMsg;
        }

        // validate county
        public string ValidateCounty(string County)
        {
            string CountyErrMsg = "";

            if (County.Length == 0)
            {
                return CountyErrMsg;
            }
            else if (County.Length > 50)
            {
                CountyErrMsg = "County No more than 50 characters";
            }
            return CountyErrMsg;

        }

        // Validate PostCode
        public string ValidatePostCode(string PostCode)
        {
            string PostCodeErrMsg = "";

            if (PostCode.Length == 0)
            {
                PostCodeErrMsg = "PostCode cannot be blank";
            }
            else if (PostCode.Length > 10)
            {
                PostCodeErrMsg = "PostCode No more than 10 characters";
            }
            return PostCodeErrMsg;
        }

        //Validate LandlineNo
        public string ValidateLandlineNo(string LandlineNo)
        {
            string LandlineErrMsg = "";

            if (LandlineNo.Length == 0)
            {
                return LandlineErrMsg;
            }
            else if (LandlineNo.Length > 15)
            {
                LandlineErrMsg = "LandLineNo No more than 15 characters";
            }
            return LandlineErrMsg;

        }

        //Validate MobileNo
        public string ValidateMobileNo(string MobileNo)
        {
            string MobileErrMsg = "";

            if (MobileNo.Length == 0)
            {
                return MobileErrMsg;
            }
            else if (MobileNo.Length > 15)
            {
                MobileErrMsg = "MobileNo No more than 15 characters";
            }
            return MobileErrMsg;

        }

        //Validate Email Address
        public string ValidateEmail(string Email)
        {
            string EmailErrMsg = "";

            if (Email.Length == 0)
            {
                return EmailErrMsg;
            }
            else if (Email.Length > 50)
            {
                EmailErrMsg = "Email No more than 50 characters";
            }
            return EmailErrMsg;

        }

        // validate DateJoined
        public string ValidateDateJoined(string DateJoined)
        {
            string DateJoinedErrMsg = "";
            string ErrorMessage = "DateJoined can only be between 1934 and today";

            try
            {
                // variable to store the date
                DateTime tempDate;
                // assign the date to the temporary variable
                tempDate = Convert.ToDateTime(DateJoined);

                // Now test the validity of a date saying the date can't be after today
                // as a staff joines on the day or before today's date not in the future
                // 1 jan 1934 < DateAdmitted < Today
                if (tempDate > DateTime.Today)
                {
                    // record an error
                    DateJoinedErrMsg = "DateJoined can't be after today in the future";
                }
                /** and staff can't be admitted before 1 jan 1934 as it is too far back
                    a remembering that a staff must be an adult of 18 years when joining
                    if the minimum date of birth is 1 jan 1916, so staff will be 18 in 1934
                **/
                else if (tempDate < DateTime.Parse("1 jan 1934"))
                {
                    // record an error
                    DateJoinedErrMsg = "DateAdmitted can't be before 1 jan 1934";
                }

            }
            catch
            {
                // record an error message that is general of the two tests
                return ErrorMessage;
            }

            return DateJoinedErrMsg;

        }


        // Validate DateLeft
        public string ValidateDateLeft(string DateLeft)
        {
            string DateLeftErrMsg = "";
            string ErrorMessage = "DateLeft can only be bewtween 1934 and 2117";

            try
            {
                // variable to store the date
                DateTime tempDate;
                // assign the date to the temporary variable
                tempDate = Convert.ToDateTime(DateLeft);

                // Now test the validity of a date saying the date should never be before 1 jan 1934 
                //as the staff can't have joined .... 1 jan 1934 < DateLeft < 1 jan 2117
                if (tempDate < DateTime.Parse("1 jan 1934"))
                {
                    // record an error
                    DateLeftErrMsg = "DateLeft can't be before 1 jan 1934";
                }
                // and date left can't be in 100 years from today
                // as a staff shouldn't be working for 100 years
                else if (tempDate > DateTime.Parse("1 jan 2117"))
                {
                    // record an error
                    DateLeftErrMsg = "DateLeft can't be 100 years away from today";
                }

            }
            catch
            {
                // record an error message that is general of the two tests
                return ErrorMessage;
            }

            return DateLeftErrMsg;

        }

        // Validation method comparing the two dates DateJoined and DateLeft
        public string ValidateDateJoined_DateLeft(string DateJoined, string DateLeft)
        {
            string DateErrMsg = "";
            string ErrorMessage = "DateLeft can only be on or after DateJoined";

            try
            {
                // variable to store the date joined
                DateTime tempDateJoined;
                // assign the date to the temporary variable
                tempDateJoined = Convert.ToDateTime(DateJoined);

                // variable to store the dae left
                DateTime tempDateLeft;
                // assign the date to the temporary variable
                tempDateLeft = Convert.ToDateTime(DateLeft);


                // Now test the validity of the two dates bearing in mind that DateAdmitted =< DateDischarged
                if (tempDateJoined> tempDateLeft)
                {
                    // record an error
                    DateErrMsg = "DateLeft can only be on or after DateJoined";
                }

            }
            catch
            {
                // record an error message that is general of the two tests
                return ErrorMessage;
            }

            return DateErrMsg;

        }

    }
}