using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsPatient
    {
        // Declare all the variables private so we will use them to store the values from the database
        // making them private is using the principle of encapsulation
        private Int32 patientID;
        private string title;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string gender;
        //private string genderSymbol;
        private string street;
        private string town;
        private string county;
        private string postCode;
        private string landlineNo;
        private string mobileNo;
        private DateTime dateAdmitted;
        private DateTime dateDischarged;
        private string occupation;
        private string maritalStatus;
        private string sexualOrientation;
        private string ethnicity;
        private string firstLanguage;
        private string religion;
        private string nextOfKin;
        private string nextOfKinPhoneNo;
        private string gpDetails;
        private string notes;
        private Int32 wardNo;
        private Int32 treatmentID;
        



        //Now we de-encapsulate them variables by creating the variables individual public property making them public
        public Int32 PatientID { get{ return patientID; } set{ patientID = value; } }
        public string Title { get { return title; } set{title = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string Gender { get { return gender; } set {gender=value; } }
        /**public string GenderSymbol { get { return genderSymbol; } set { genderSymbol = value; } }**/
        public string Street { get { return street; } set { street = value; } }
        public string Town { get { return town; } set { town = value; } }
        public string County { get { return county; } set { county = value; } }
        public string PostCode { get { return postCode; } set { postCode = value; } }
        public string LandlineNo { get { return landlineNo; } set { landlineNo = value; } }
        public string MobileNo { get { return mobileNo; } set { mobileNo = value; } }
        public DateTime DateAdmitted { get { return dateAdmitted; } set { dateAdmitted = value; } }
        public DateTime DateDischarged { get { return dateDischarged; } set { dateDischarged = value; }}
        public string Occupation { get { return occupation; } set { occupation = value; } }
        public string MaritalStatus { get { return maritalStatus; } set { maritalStatus = value; } }
        public string SexualOrientation { get { return sexualOrientation; } set { sexualOrientation = value; } }
        public string Ethnicity { get { return ethnicity; } set { ethnicity = value; } }
        public string FirstLanguage { get { return firstLanguage; } set { firstLanguage = value; } }
        public string Religion { get { return religion; } set { religion = value;} }
        public string NextOfKin { get { return nextOfKin; } set { nextOfKin = value; } }
        public string NextOfKinPhoneNo { get { return nextOfKinPhoneNo; } set { nextOfKinPhoneNo = value; } }
        public string GPDetails { get { return gpDetails; } set { gpDetails = value ;} }
        public string Notes { get { return notes; } set { notes = value; } }

        public Int32 WardNo { get { return wardNo; } set { wardNo = value; } }
        public Int32 TreatmentID { get { return treatmentID; } set { treatmentID = value; } }

        




        /**** Validation methoids for each attributes so when user enters data each 
         attribute is tested individually *****/

        // Validate Title data entered
        public bool ValidateTitle(string Title)
        {
            //boolean attribute to indicate that everything is OK
            Boolean OK = true;
            //if the title of the patient  is blank
            if ( Title == "")
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

        //Validate DateOfBirth of the patient
        public string ValidateDateOfBirth(string DateOfBirth)
        {
            string DateOfBirthErrMsg = "";
            string errorMessage = "Date of Birth should be between 1 jan 1916 and 1 Jan 1996";

            try
            {
                // variable to store the date
                DateTime tempDate;
                // assign the date to the temporary variable
                tempDate = Convert.ToDateTime(DateOfBirth);

                // Now test the validity of a date saying the date should be before 1 jan 1996 
                // people over 100 years are not allowed in the system
                if ((tempDate < DateTime.Parse("1 Jan 1916")))
                {
                    // record an error
                    DateOfBirthErrMsg = "Date of Birth should be on or after 1 Jan 1916";
                }
                //and people under 18 - children are not allowed to be registered in the system and
                else if (tempDate > DateTime.Parse("1 jan 1996"))
                {
                    // record an error
                    DateOfBirthErrMsg = "Date of Birth should be on or before 1 Jan 1996";
                }

            }
            catch
            {
                // record an error message that is general of the two tests
                return errorMessage; 
            }

            return DateOfBirthErrMsg;
        }

        // validate Gender of the patient
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

        // Validate Street of the patient
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

        // Validate Town of patient
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

        // validate DateAdmitted
        public string ValidateDateAdmitted(string DateAdmitted)
        {
            string DateAdmittedErrMsg = "";
            string ErrorMessage = "DateAdmitted can only be between 1934 and today";

            try
            {
                // variable to store the date
                DateTime tempDate;
                // assign the date to the temporary variable
                tempDate = Convert.ToDateTime(DateAdmitted);

                // Now test the validity of a date saying the date can't be after today
                // as a patient is admitted on the day or before today's date not in the future
                // 1 jan 1934 < DateAdmitted < Today
                if (tempDate > DateTime.Today)
                {
                    // record an error
                    DateAdmittedErrMsg = "DateAdmitted can't be after today in the future";
                }
                /** and patient can't be admitted before 1 jan 1934 as it is too far back
                    a remembering that a patient must be an adult of 18tears when admitted
                    if the minimum date of birt is 1 jan 1916, so patient will be 18 in 1934
                **/
                else if (tempDate < DateTime.Parse("1 jan 1934"))
                {
                    // record an error
                    DateAdmittedErrMsg = "DateAdmitted can't be before 1 jan 1934";
                }

            }
            catch
            {
                // record an error message that is general of the two tests
                return ErrorMessage;
            }

            return DateAdmittedErrMsg;

        }


        // Validate DateDischarged
        public string ValidateDateDischarged(string DateDischarged)
        {
            string DateDischargedErrMsg = "";
            string ErrorMessage = "DateDischarged can only be bewtween 1934 and 2117";

            try
            {
                // variable to store the date
                DateTime tempDate;
                // assign the date to the temporary variable
                tempDate = Convert.ToDateTime(DateDischarged);

                // Now test the validity of a date saying the date should never be before 1 jan 1934 
                //as the patient can't be admitted .... 1 jan 1934 < DateDischarged < 1 jan 2117
                if (tempDate < DateTime.Parse("1 jan 1934"))
                {
                    // record an error
                    DateDischargedErrMsg = "DateDischarged can't be before 1 jan 1934";
                }
                // and date discharged can't be in 100 years from today
                // as a patient shouldn't be in hospital for 100 years
                else if (tempDate > DateTime.Parse("1 jan 2117"))
                {
                    // record an error
                    DateDischargedErrMsg = "DateDischarged can't be 100 years away from today";
                }

            }
            catch
            {
                // record an error message that is general of the two tests
                return ErrorMessage;
            }

            return DateDischargedErrMsg;

        }

        // Validation method comparing the two dates DateAdmiitted and DateDischarged
        public string ValidateDateAdmitted_DateDischarged(string DateAdmitted,string DateDischarged)
        {
            string DateErrMsg = "";
            string ErrorMessage = "DateDischarged can only be on or after DateAdmitted";

            try
            {
                // variable to store the date admitted
                DateTime tempDateAdmitted;
                // assign the date to the temporary variable
                tempDateAdmitted = Convert.ToDateTime(DateAdmitted);

                // variable to store the date discharged
                DateTime tempDateDischarged;
                // assign the date to the temporary variable
                tempDateDischarged = Convert.ToDateTime(DateDischarged);


                // Now test the validity of the two dates bearing in mind that DateAdmitted =< DateDischarged
                if (tempDateAdmitted > tempDateDischarged)
                {
                    // record an error
                    DateErrMsg = "DateDischarged can only be on or after DateAdmitted";
                }
                
            }
            catch
            {
                // record an error message that is general of the two tests
                return ErrorMessage;
            }

            return DateErrMsg;

        }

        // Validate Occupation
        public string ValidateOccupation(string Occupation)
        {
            string OccupationErrMsg = "";

            if (Occupation.Length == 0)
            {
                return OccupationErrMsg;
            }
            else if (Occupation.Length > 50)
            {
                OccupationErrMsg = "Occupation No more than 50 characters";
            }
            return OccupationErrMsg;
        }

        // Validate next of kin
        public string ValidateNextOfKin(string NextOfKin)
        {
            string NextOfKinErrMsg = "";

            if (NextOfKin.Length == 0)
            {
                return NextOfKinErrMsg;
            }
            else if (NextOfKin.Length > 100)
            {
                NextOfKinErrMsg = "Next Of Kin No more than 100 characters";
            }
            return NextOfKinErrMsg;
        }

        // Validate next of kin PhoneNo
        public string ValidateNextOfKinPhoneNo(string NextOfKinPhoneNo)
        {
            string NextOfKinPhoneNoErrMsg = "";

            if (NextOfKinPhoneNo.Length == 0)
            {
                return NextOfKinPhoneNoErrMsg;
            }
            else if (NextOfKinPhoneNo.Length > 40)
            {
                NextOfKinPhoneNoErrMsg = "Next Of Kin PhoneNo No more than 40 characters";
            }
            return NextOfKinPhoneNoErrMsg;
        }

        //Validate GP details
        public string ValidateGPDetails(string GPDetails)
        {
            string GPDetailsErrMsg = "";

            if (GPDetails.Length == 0)
            {
                return GPDetailsErrMsg;
            }
            else if (GPDetails.Length > 500)
            {
                GPDetailsErrMsg = "GP Details No more than 500 characters";
            }
            return GPDetailsErrMsg;
        }


        //Validate Notes
        public string ValidateNotes(string Notes)
        {
            string NotesErrMsg = "";

            if (Notes.Length == 0)
            {
                return NotesErrMsg;
            }
            else if (Notes.Length > 1000)
            {
                NotesErrMsg = "Notes No more than 1000 characters";
            }
            return NotesErrMsg;

        }
     
    }
}
