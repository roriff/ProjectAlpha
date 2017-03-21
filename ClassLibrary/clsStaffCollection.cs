using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ClassLibrary
{

    public class clsStaffCollection
    {

        //construtor
        public clsStaffCollection()
        {

        }

        // create an instance of the data connection class called MyDatabase
        clsDataConnection MyDatabase = new clsDataConnection();

        // this method is to test any staff login credentials off the database of every user 
        public Boolean TestLogin(string UserName, string Password)
        {

            // add the parameters to use for this function
            MyDatabase.AddParameter("@UserName", UserName);
            MyDatabase.AddParameter("@Password", Password);

            // execute the stsored procedure
            MyDatabase.Execute("sproc_tblStaff_Login");

            // if a record is found 
            if (MyDatabase.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // this method is to test only the hospital staff login credentials off the database of every user 
        public Boolean TestHospitalStaffLogin(string UserName, string Password)
        {

            // add the parameters to use for this function
            MyDatabase.AddParameter("@UserName", UserName);
            MyDatabase.AddParameter("@Password", Password);

            // execute the stsored procedure applied only on the view table ViewHospitalLogin
            MyDatabase.Execute("sproc_ViewHospitalStaffLogins_Login");

            // if a record is found 
            if (MyDatabase.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // this method is to test only the hospital managers and System admin login credentials off the database of every user 
        // It is manily for accesing the back end of the Care Observation system
        public Boolean TestHospitalStaff_BackEnd_Login(string UserName, string Password)
        {

            // add the parameters to use for this function
            MyDatabase.AddParameter("@UserName", UserName);
            MyDatabase.AddParameter("@Password", Password);

            // execute the stsored procedure applied only on the view table ViewHospitalLogin
            MyDatabase.Execute("sproc_ViewHospitalStaff_BackEndLogins_Login");

            // if a record is found 
            if (MyDatabase.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This method will give us the name off the database of the user who is logged in
        public clsStaff GetStaffLoginDetails(string thisUserName)
        {
            // add the parameter to be used for the query
            MyDatabase.AddParameter("@UserName", thisUserName);

            // Execute the stored procedure related to this query
            MyDatabase.Execute("sproc_tblStaff_GetStaffLoginDetails");

            //if a record is found
            if (MyDatabase.Count == 1)
            {
                // create an instance of the clsStaff
                clsStaff ThisStaff = new clsStaff();

                // copy the data from the database
                ThisStaff.StaffLoginDetails = Convert.ToString(MyDatabase.DataTable.Rows[0]["StaffLoginDetails"]);

                // return the object ThisStaff
                return ThisStaff; ;
            }
            else
            {
                // return a value to indicate that something has gone wrong
                return null;
            }
        }

        //This method will give us the StaffID off the database of the staff who is logged in
        public clsStaff GetStaffID(string thisUserName)
        {
            // add the parameter to be used for the query
            MyDatabase.AddParameter("@UserName", thisUserName);

            // Execute the stored procedure related to this query
            MyDatabase.Execute("sproc_tblStaff_GetStaffID");

            //if a record is found
            if (MyDatabase.Count == 1)
            {
                // create an instance of the clsStaff
                clsStaff ThisStaff = new clsStaff();

                // copy the data from the database
                ThisStaff.StaffID = Convert.ToInt32(MyDatabase.DataTable.Rows[0]["StaffID"]);

                // return the object ThisStaff
                return ThisStaff; ;
            }
            else
            {
                // return a value to indicate that something has gone wrong
                return null;
            }
        }





        /* The Function StaffList to deal with the list of staff will be a property 
           as it only allows us to access data in the database without changing or manipulating 
           the data. it only has a get method as it only reads the data.... 
           no setting or writing is done here....just reading
           the property return a array list so the type of the property is List<clsStaff>
            */
        public List<clsStaff> StaffList
        {
            get
            {
                // create an array list of type clsStaff to store the values of the data in order to put it into the list in UI
                List<clsStaff> staffList = new List<clsStaff>();

                // variable to store the the count of the records in the database
                Int32 recordCount;

                // Variable to store the starting index for the loop as we know all record start at index 0
                Int32 index = 0;

                // get the count of the records in database using the property Count in the clsDataConnection
                recordCount = MyDatabase.Count;

                // Keep looping all over the records in database till all records are processed
                while (index < recordCount)
                {
                    // create a blank patient storage page
                    clsStaff BlankStaff = new clsStaff();

                    // get the data value from the database at index
                    //using the DataTable property on the object MyDatabase and put it into the declared variables
                    BlankStaff.StaffID = Convert.ToInt32(MyDatabase.DataTable.Rows[index]["StaffID"]);
                    BlankStaff.Title = Convert.ToString(MyDatabase.DataTable.Rows[index]["Title"]);
                    BlankStaff.FirstName = Convert.ToString(MyDatabase.DataTable.Rows[index]["FirstName"]);
                    BlankStaff.LastName = Convert.ToString(MyDatabase.DataTable.Rows[index]["LastName"]);
                    BlankStaff.Gender = Convert.ToString(MyDatabase.DataTable.Rows[index]["Gender"]);
                    BlankStaff.UserName = Convert.ToString(MyDatabase.DataTable.Rows[index]["UserName"]);
                    BlankStaff.Password = Convert.ToString(MyDatabase.DataTable.Rows[index]["Password"]);
                    BlankStaff.IndustrySector = Convert.ToString(MyDatabase.DataTable.Rows[index]["IndustrySector"]);
                    BlankStaff.Position = Convert.ToString(MyDatabase.DataTable.Rows[index]["Position"]);
                    BlankStaff.HighestQualification = Convert.ToString(MyDatabase.DataTable.Rows[index]["HighestQualification"]);
                    BlankStaff.Street = Convert.ToString(MyDatabase.DataTable.Rows[index]["Street"]);
                    BlankStaff.Town = Convert.ToString(MyDatabase.DataTable.Rows[index]["Town"]);
                    BlankStaff.County = Convert.ToString(MyDatabase.DataTable.Rows[index]["County"]);
                    BlankStaff.PostCode = Convert.ToString(MyDatabase.DataTable.Rows[index]["PostCode"]);
                    BlankStaff.LandlineNo = Convert.ToString(MyDatabase.DataTable.Rows[index]["LandlineNo"]);
                    BlankStaff.MobileNo = Convert.ToString(MyDatabase.DataTable.Rows[index]["MobileNo"]);
                    BlankStaff.EmailAddress = Convert.ToString(MyDatabase.DataTable.Rows[index]["EmailAddress"]);
                    BlankStaff.DateJoined = Convert.ToDateTime(MyDatabase.DataTable.Rows[index]["DateJoined"]);
                    BlankStaff.DateLeft = Convert.ToDateTime(MyDatabase.DataTable.Rows[index]["DateLeft"]);



                    // First add the blankstaff to an array list of type clsStaff created above 
                    // using the function Add which is a standard list function and incorporated in the list library 
                    staffList.Add(BlankStaff);

                    // then increment the index to move to the next index whithin the loop
                    index++;
                }

                // return the list as the return value of the property
                return staffList;
            }

        }


        // property Count
        public Int32 Count
        {
            get
            {
                // get the count of the records in database using the property Count in the clsDataConnection
                return MyDatabase.Count;
            }
        }


        // This method will allow us to find a record based on the patient's full name 
        public void FindStaffByName(string firstNameFilter, string lastNameFilter)
        {
            // adding a parameter to the object MyDatabase connection used  to filter by first name
            MyDatabase.AddParameter("@FirstName", firstNameFilter);

            // adding the parameter to the object MyDatabase used to filter by last name
            MyDatabase.AddParameter("@LastName", lastNameFilter);

            // Execute the query FilterByName
            MyDatabase.Execute("sproc_tblStaff_FilterByName");
        }


        /** Insert method to add a staff into the database
         
            This function will help us add a new staff to the database
            It accepts a single parameter which is an object of type clsStaff
            Once the function is added the function returns the primary key value of the new record
        
    CREATE PROCEDURE [dbo].[sproc_tblStaff_Insert]
	-- parameters for the query without the PK as it is inserted automatically as an increment
    --@StaffID     int,
	@Title            VARCHAR (6),
    @FirstName        VARCHAR (50),  
    @LastName         VARCHAR (50),
    @Gender           VARCHAR (12),
    @UserName         VARCHAR (12),
	@Password         VARCHAR (8),
	@IndustrySector   VARCHAR (50),
	@Position         VARCHAR (50),
	@HighestQualification    VARCHAR (50),
    @Street           VARCHAR (50),
    @Town             VARCHAR (50),
    @County           VARCHAR (50),
    @PostCode         VARCHAR (10),
    @LandlineNo       VARCHAR (15),
    @MobileNo         VARCHAR (15),
	@EmailAddress     VARCHAR (50),
    @DateJoined       DATE, 
    @DateLeft         DATE

AS
 -- insert the value stored in the parameters into the fields of the new record
	INSERT INTO tblStaff
   ( Title ,
    FirstName,  
    LastName,
    Gender,
    UserName,
	Password,
	IndustrySector,
	Position,
	HighestQualification,
    Street,
    Town,
    County,
    PostCode,
    LandlineNo,
    MobileNo,
	EmailAddress,
    DateJoined, 
    DateLeft)

	SELECT 
	@Title ,
    @FirstName,  
    @LastName,
    @Gender,
    @UserName,
	@Password,
	@IndustrySector,
	@Position,
	@HighestQualification,
    @Street,
    @Town,
    @County,
    @PostCode,
    @LandlineNo,
    @MobileNo,
	@EmailAddress,
    @DateJoined, 
    @DateLeft
	  
RETURN @@Identity
        **/
        public Int32 InsertStaff(clsStaff NewStaff)
        {
            // Add the paramters to the query for inserting the new staff properties into the DB
            MyDatabase.AddParameter("Title", NewStaff.Title);
            MyDatabase.AddParameter("FirstName", NewStaff.FirstName);
            MyDatabase.AddParameter("LastName", NewStaff.LastName);
            MyDatabase.AddParameter("Gender", NewStaff.Gender);
            MyDatabase.AddParameter("UserName", NewStaff.UserName);
            MyDatabase.AddParameter("Password", NewStaff.Password);
            MyDatabase.AddParameter("IndustrySector", NewStaff.IndustrySector);
            MyDatabase.AddParameter("Position", NewStaff.Position);
            MyDatabase.AddParameter("HighestQualification", NewStaff.HighestQualification);
            MyDatabase.AddParameter("Street", NewStaff.Street);
            MyDatabase.AddParameter("Town", NewStaff.Town);
            MyDatabase.AddParameter("County", NewStaff.County);
            MyDatabase.AddParameter("PostCode", NewStaff.PostCode);
            MyDatabase.AddParameter("LandlineNo", NewStaff.LandlineNo);
            MyDatabase.AddParameter("MobileNo", NewStaff.MobileNo);
            MyDatabase.AddParameter("EmailAddress", NewStaff.EmailAddress);
            MyDatabase.AddParameter("DateJoined", NewStaff.DateJoined);
            MyDatabase.AddParameter("DateLeft", NewStaff.DateLeft);

            //Execute the Insert procedure 
            // bearing in mind that it always returns the PK value of any record so return needs to added in this function
            return MyDatabase.Execute("sproc_tblStaff_Insert");
        }



        /**This function will update an existing staff  in the database without returning a value 
           it accepts a single parameter an object of type clsPatient
           the StaffID property must have a valid value for this to work

    CREATE PROCEDURE [dbo].[sproc_tblStaff_Update]
    -- parameters for the query
    @StaffID     int, -- this time we get the Primary key to identify which record to update
	
	@Title            VARCHAR (6),
    @FirstName        VARCHAR (50),  
    @LastName         VARCHAR (50),
    @Gender           VARCHAR (12),
    @UserName         VARCHAR (12),
	@Password         VARCHAR (8),
	@IndustrySector   VARCHAR (50),
	@Position         VARCHAR (50),
	@HighestQualification    VARCHAR (50),
    @Street           VARCHAR (50),
    @Town             VARCHAR (50),
    @County           VARCHAR (50),
    @PostCode         VARCHAR (10),
    @LandlineNo       VARCHAR (15),
    @MobileNo         VARCHAR (15),
	@EmailAddress     VARCHAR (50),
    @DateJoined       DATE, 
    @DateLeft         DATE

AS
	UPDATE tblStaff
	 SET 
	 Title = @Title,
     FirstName = @FirstName,  
     LastName = @LastName,
     Gender = @Gender,
	 UserName = @UserName,
	 Password = @Password,
	 IndustrySector = @IndustrySector,
	 Position = @Position,
	 HighestQualification = @HighestQualification,
     Street = @Street,
     Town = @Town,
     County = @County,
     PostCode = @PostCode,
     LandlineNo = @LandlineNo,
     MobileNo =@MobileNo,
	 EmailAddress = @EmailAddress,
     DateJoined = @DateJoined,
     DateLeft = @DateLeft

	  -- where the StaffID selected matches the StaffID of the staff we want to update
	  WHERE StaffID = @StaffID;
     RETURN 0 **/

        public void UpdateStaff(clsStaff ExistingStaff)
        {
            // Add the Primary Key PatientID to the query
            MyDatabase.AddParameter("StaffID", ExistingStaff.StaffID);

            // Add the others parameters to the query
            MyDatabase.AddParameter("Title", ExistingStaff.Title);
            MyDatabase.AddParameter("FirstName", ExistingStaff.FirstName);
            MyDatabase.AddParameter("LastName", ExistingStaff.LastName);
            MyDatabase.AddParameter("Gender", ExistingStaff.Gender);
            MyDatabase.AddParameter("UserName", ExistingStaff.UserName);
            MyDatabase.AddParameter("Password", ExistingStaff.Password);
            MyDatabase.AddParameter("IndustrySector", ExistingStaff.IndustrySector);
            MyDatabase.AddParameter("Position", ExistingStaff.Position);
            MyDatabase.AddParameter("HighestQualification", ExistingStaff.HighestQualification);
            MyDatabase.AddParameter("Street", ExistingStaff.Street);
            MyDatabase.AddParameter("Town", ExistingStaff.Town);
            MyDatabase.AddParameter("County", ExistingStaff.County);
            MyDatabase.AddParameter("PostCode", ExistingStaff.PostCode);
            MyDatabase.AddParameter("LandlineNo", ExistingStaff.LandlineNo);
            MyDatabase.AddParameter("MobileNo", ExistingStaff.MobileNo);
            MyDatabase.AddParameter("EmailAddress", ExistingStaff.EmailAddress);
            MyDatabase.AddParameter("DateJoined", ExistingStaff.DateJoined);
            MyDatabase.AddParameter("DateLeft", ExistingStaff.DateLeft);

            //Just Execute the update procedure 
            MyDatabase.Execute("sproc_tblStaff_Update");
        }


        ///This property finds a staff record based on the primary key value passed as a parameter
        /// It returns an insance of clsStaff populated with the data if the record is found
        /// If the record is not not found it returns a null value 
        public clsStaff FindStaff(Int32 StaffID)
        {

            //add the parameter named @StaffID 
            MyDatabase.AddParameter("@StaffID", StaffID);

            // Execute the procedure 
            MyDatabase.Execute("sproc_tblStaff_FilterByStaffID");

            //If only one record is found which is obvious since one primary key refers to one only counted record
            if (MyDatabase.Count == 1)
            {
                // create an instance of clsPatient
                clsStaff ThisStaffRecord = new clsStaff();

                // Now let us  Copy this data record data from the database at index 0 since it is the only record
                // since the obvious index is 0 for this record on a table as it is the only record found
                ThisStaffRecord.StaffID = Convert.ToInt32(MyDatabase.DataTable.Rows[0]["StaffID"]);
                ThisStaffRecord.Title = Convert.ToString(MyDatabase.DataTable.Rows[0]["Title"]);
                ThisStaffRecord.FirstName = Convert.ToString(MyDatabase.DataTable.Rows[0]["FirstName"]);
                ThisStaffRecord.LastName = Convert.ToString(MyDatabase.DataTable.Rows[0]["LastName"]);
                ThisStaffRecord.Gender = Convert.ToString(MyDatabase.DataTable.Rows[0]["Gender"]);

                ThisStaffRecord.UserName = Convert.ToString(MyDatabase.DataTable.Rows[0]["UserName"]);
                ThisStaffRecord.Password = Convert.ToString(MyDatabase.DataTable.Rows[0]["Password"]);
                ThisStaffRecord.IndustrySector = Convert.ToString(MyDatabase.DataTable.Rows[0]["IndustrySector"]);
                ThisStaffRecord.Position = Convert.ToString(MyDatabase.DataTable.Rows[0]["Position"]);
                ThisStaffRecord.HighestQualification = Convert.ToString(MyDatabase.DataTable.Rows[0]["HighestQualification"]);

                ThisStaffRecord.Street = Convert.ToString(MyDatabase.DataTable.Rows[0]["Street"]);
                ThisStaffRecord.Town = Convert.ToString(MyDatabase.DataTable.Rows[0]["Town"]);
                ThisStaffRecord.County = Convert.ToString(MyDatabase.DataTable.Rows[0]["County"]);
                ThisStaffRecord.PostCode = Convert.ToString(MyDatabase.DataTable.Rows[0]["PostCode"]);
                ThisStaffRecord.LandlineNo = Convert.ToString(MyDatabase.DataTable.Rows[0]["LandlineNo"]);
                ThisStaffRecord.MobileNo = Convert.ToString(MyDatabase.DataTable.Rows[0]["MobileNo"]);
                ThisStaffRecord.EmailAddress = Convert.ToString(MyDatabase.DataTable.Rows[0]["EmailAddress"]);

                ThisStaffRecord.DateJoined = Convert.ToDateTime(MyDatabase.DataTable.Rows[0]["DateJoined"]);
                ThisStaffRecord.DateLeft = Convert.ToDateTime(MyDatabase.DataTable.Rows[0]["DateLeft"]);


                // return the Object ThisStaffRecord
                return ThisStaffRecord;

            }

            else
            {
                //return a null value
                return null;
            }

        }

        //**************************************************************************************************
        //**************************************************************************************************
        //**************************************************************************************************
        // CODE SPECIFIC FOR BACK END WINDOWS FORM TO DEAL WITH THE DISAPLY OF THE LIST

        // function to find data to fill listbox with all staff data (used for first time form loaded)
        public void BackEnd_Staff_SelectAll()
        {

            MyDatabase.Execute("sproc_BackEnd_tblStaff_SelectAll");
        }

        // function to find data to fill listbox with only hospital staff data (used for first time form loaded)
        public void BackEnd_ViewHospitalStaff_SelectAll()
        {

            MyDatabase.Execute("sproc_BackEnd_ViewHospitalStaff_SelectAll");
        }

        // function to find company data filtered based on criteria selected in dropdown list
        public void BackEnd_Staff_FilterByStaffID(int StaffID) // function to find company data filtered based on criteria selected in dropdown list
        {

            MyDatabase.AddParameter("@StaffID", StaffID);
            MyDatabase.Execute("sproc_BackEnd_tblStaff_Find_StaffID");
        }


        public List<clsStaff> StaffListDetails // function to get company data and create array list
        {
            get
            {
                List<clsStaff> List = new List<clsStaff>();
                int Index = 0;
                while (Index < Count)
                {
                    clsStaff GetRecord = new clsStaff();
                    GetRecord.StaffID = Convert.ToInt32(MyDatabase.DataTable.Rows[Index]["StaffID"]);
                    GetRecord.StaffDetails = Convert.ToString(MyDatabase.DataTable.Rows[Index]["StaffDetails"]);
                    Index++;
                    List.Add(GetRecord);
                }
                return List;
            }
        }


        ///This property finds a staff record based on the primary key value passed as a parameter
        /// It returns an instance of boolean populated with the data if the record is found
        /// If the record is not not found it returns a null value 
        public bool FindStaffBool(Int32 StaffID)
        {
            clsDataConnection MyDatabase = new clsDataConnection();

            //add the parameter named @StaffID 
            MyDatabase.AddParameter("@StaffID", StaffID);

            // Execute the procedure 
            MyDatabase.Execute("sproc_tblStaff_FilterByStaffID");

            //If only one record is found which is obvious since one primary key refers to one only counted record
            if (MyDatabase.Count == 1)
            {
                // create an instance of clsPatient
                clsStaff ThisStaffRecord = new clsStaff();

                // Now let us  Copy this data record data from the database at index 0 since it is the only record
                // since the obvious index is 0 for this record on a table as it is the only record found
                ThisStaffRecord.StaffID = Convert.ToInt32(MyDatabase.DataTable.Rows[0]["StaffID"]);
                ThisStaffRecord.Title = Convert.ToString(MyDatabase.DataTable.Rows[0]["Title"]);
                ThisStaffRecord.FirstName = Convert.ToString(MyDatabase.DataTable.Rows[0]["FirstName"]);
                ThisStaffRecord.LastName = Convert.ToString(MyDatabase.DataTable.Rows[0]["LastName"]);
                ThisStaffRecord.Gender = Convert.ToString(MyDatabase.DataTable.Rows[0]["Gender"]);

                ThisStaffRecord.UserName = Convert.ToString(MyDatabase.DataTable.Rows[0]["UserName"]);
                ThisStaffRecord.Password = Convert.ToString(MyDatabase.DataTable.Rows[0]["Password"]);
                ThisStaffRecord.IndustrySector = Convert.ToString(MyDatabase.DataTable.Rows[0]["IndustrySector"]);
                ThisStaffRecord.Position = Convert.ToString(MyDatabase.DataTable.Rows[0]["Position"]);
                ThisStaffRecord.HighestQualification = Convert.ToString(MyDatabase.DataTable.Rows[0]["HighestQualification"]);

                ThisStaffRecord.Street = Convert.ToString(MyDatabase.DataTable.Rows[0]["Street"]);
                ThisStaffRecord.Town = Convert.ToString(MyDatabase.DataTable.Rows[0]["Town"]);
                ThisStaffRecord.County = Convert.ToString(MyDatabase.DataTable.Rows[0]["County"]);
                ThisStaffRecord.PostCode = Convert.ToString(MyDatabase.DataTable.Rows[0]["PostCode"]);
                ThisStaffRecord.LandlineNo = Convert.ToString(MyDatabase.DataTable.Rows[0]["LandlineNo"]);
                ThisStaffRecord.MobileNo = Convert.ToString(MyDatabase.DataTable.Rows[0]["MobileNo"]);
                ThisStaffRecord.EmailAddress = Convert.ToString(MyDatabase.DataTable.Rows[0]["EmailAddress"]);

                ThisStaffRecord.DateJoined = Convert.ToDateTime(MyDatabase.DataTable.Rows[0]["DateJoined"]);
                ThisStaffRecord.DateLeft = Convert.ToDateTime(MyDatabase.DataTable.Rows[0]["DateLeft"]);


                // return the Object ThisStaffRecord
                return true;

            }

            else
            {
                //return a null value
                return false;
            }

        }


    }

}


