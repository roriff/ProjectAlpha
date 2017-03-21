using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace ClassLibrary
{
    public class clsPatientCollection
    {

        // constructor
        public clsPatientCollection()
        {

        }

        // create an instance of the data connection class called MyDatabase
        clsDataConnection MyDatabase = new clsDataConnection();

        
        /* The Function PatientList to deal with the list of patients will be a property 
         as it only allows us to access data in the database without changing or manipulating 
         the data. it only has a get method as it only reads the data.... 
         no setting or writing is done here....just reading
         the property return a array list so the type of the property is List<clsPatient>
        */
        public List<clsPatient> PatientList
        {
            get
            {
                // create an array list of type clsPatient to store the values of the data in order to put it into the list in UI
                List<clsPatient> patientList = new List<clsPatient>();

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
                    clsPatient BlankPatient = new clsPatient();

                    // get the data value from the database at index
                    //using the DataTable property on the object MyDatabase and put it into the declared variables
                    BlankPatient.PatientID = Convert.ToInt32(MyDatabase.DataTable.Rows[index]["PatientID"]);
                    BlankPatient.Title = Convert.ToString(MyDatabase.DataTable.Rows[index]["Title"]);
                    BlankPatient.FirstName = Convert.ToString(MyDatabase.DataTable.Rows[index]["FirstName"]);
                    BlankPatient.LastName = Convert.ToString(MyDatabase.DataTable.Rows[index]["LastName"]);
                    BlankPatient.DateOfBirth = Convert.ToDateTime(MyDatabase.DataTable.Rows[index]["DateOfBirth"]);
                    BlankPatient.Gender = Convert.ToString(MyDatabase.DataTable.Rows[index]["Gender"]);
                    BlankPatient.Street = Convert.ToString(MyDatabase.DataTable.Rows[index]["Street"]);
                    BlankPatient.Town = Convert.ToString(MyDatabase.DataTable.Rows[index]["Town"]);
                    BlankPatient.County = Convert.ToString(MyDatabase.DataTable.Rows[index]["County"]);
                    BlankPatient.PostCode = Convert.ToString(MyDatabase.DataTable.Rows[index]["PostCode"]);
                    BlankPatient.LandlineNo = Convert.ToString(MyDatabase.DataTable.Rows[index]["LandlineNo"]);
                    BlankPatient.MobileNo = Convert.ToString(MyDatabase.DataTable.Rows[index]["MobileNo"]);
                    BlankPatient.DateAdmitted = Convert.ToDateTime(MyDatabase.DataTable.Rows[index]["DateAdmitted"]);
                    BlankPatient.DateDischarged = Convert.ToDateTime(MyDatabase.DataTable.Rows[index]["DateDischarged"]);
                    BlankPatient.Occupation = Convert.ToString(MyDatabase.DataTable.Rows[index]["Occupation"]);
                    BlankPatient.MaritalStatus = Convert.ToString(MyDatabase.DataTable.Rows[index]["MaritalStatus"]);
                    BlankPatient.SexualOrientation = Convert.ToString(MyDatabase.DataTable.Rows[index]["SexualOrientation"]);
                    BlankPatient.Ethnicity = Convert.ToString(MyDatabase.DataTable.Rows[index]["Ethnicity"]);
                    BlankPatient.FirstLanguage = Convert.ToString(MyDatabase.DataTable.Rows[index]["FirstLanguage"]);
                    BlankPatient.Religion = Convert.ToString(MyDatabase.DataTable.Rows[index]["Religion"]);
                    BlankPatient.NextOfKin = Convert.ToString(MyDatabase.DataTable.Rows[index]["NextOfKin"]);
                    BlankPatient.NextOfKinPhoneNo = Convert.ToString(MyDatabase.DataTable.Rows[index]["NextOfKinPhoneNo"]);
                    BlankPatient.GPDetails = Convert.ToString(MyDatabase.DataTable.Rows[index]["GPDetails"]);
                    BlankPatient.Notes = Convert.ToString(MyDatabase.DataTable.Rows[index]["Notes"]);

                    BlankPatient.WardNo = Convert.ToInt32(MyDatabase.DataTable.Rows[index]["WardNo"]);
                    BlankPatient.TreatmentID = Convert.ToInt32(MyDatabase.DataTable.Rows[index]["TreatmentID"]);

                    // First add the blankpatient to an array list of type clsPatient created above 
                    // using the function Add which is a standard list function and incorporated in the list library 
                    patientList.Add(BlankPatient);

                    // then increment the index to move to the next index whithin the loop
                    index++;
                }

                // return the list as the return value of the property
                return patientList;
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
        public void FindPatientByName(string firstNameFilter, string lastNameFilter)
        {
            // adding a parameter to the object MyDatabase connection used  to filter by first name
            MyDatabase.AddParameter("@FirstName", firstNameFilter);

            // adding the parameter to the object MyDatabase used to filter by last name
            MyDatabase.AddParameter("@LastName", lastNameFilter);

            // Execute the query FilterByName
            MyDatabase.Execute("sproc_tblPatient_FilterByName");
        }


        // This method will allow us to find a record based on the patient's ward 
        public void FindPatientByWard(Int32 wardNoFilter)
        {
            // adding a parameter to the object MyDatabase connection used  to filter by WardNo
            MyDatabase.AddParameter("@WardNo", wardNoFilter);

            // Execute the query FilterByWard
            MyDatabase.Execute("sproc_tblPatient_FilterByWard");
        }


        /*** Methods useful for the DataGridView **/
        // function to recreate datatable after data passed through private members to bind to patient datagridview
        public DataTable Patients_DataTable
        {
            get
            {

                //create a datatable 
                DataTable DT = new DataTable();


                // add columns to the datatable
                DT.Columns.Add("PatientID");
                DT.Columns.Add("Gender");
                DT.Columns.Add("FirstName");
                DT.Columns.Add("LastName");
                DT.Columns.Add("DateOfBirth");
                DT.Columns.Add("DateAdmitted");
                DT.Columns.Add("DateDischarged");

                //Fill in the datatable now
                int Index = 0;
                while (Index < Count)
                {
                    var Record = DT.NewRow();
                    Record["PatientID"] = PatientList[Index].PatientID;
                    Record["Gender"] = PatientList[Index].Gender;
                    Record["FirstName"] = PatientList[Index].FirstName;
                    Record["LastName"] = PatientList[Index].LastName;
                    Record["DateOfBirth"] = PatientList[Index].DateOfBirth.ToString("dd/MM/yyyy");// Just displaying date without time
                    Record["DateAdmitted"] = PatientList[Index].DateAdmitted.ToString("dd/MM/yyyy hh:mm tt");
                    Record["DateDischarged"] = PatientList[Index].DateDischarged.ToString("dd/MM/yyyy hh:mm tt");

                    DT.Rows.Add(Record);

                    Index++;
                }

                // return the datatable now
                return DT;
            }
        }


        /************************************** End of those methdos for dataGridview  *********************************/



        /** Insert method to add a patient into the database
         
            This function will help us add a new patient to the database
            It accepts a single parameter which is an object of type clsPatient
            Once the function is added the function returns the primary key value of the new record
            
             INSERT INTO tblPatient
             (Title,
              FirstName,
              LastName,
              DateOfBirth,
              Gender,
              Street,
              Town,
              County,
              PostCode,
              LandlineNo,
              MobileNo,
              DateAdmitted,
              DateDischarged,
              Occupation,
              MaritalStatus,
              SexualOrientation,
              Ethnicity,
              FirstLanguage,
              Religion,
              NextOfKin,
              NextOfKinPhoneNo,
              GPDetails,
              Notes,
              WardNo,
              TreatmentID)
              
              SELECT

              @Title,
              @FirstName,  
              @LastName,
              @DateOfBirth,
              @Gender,
              @Street,
              @Town,
              @County,
              @PostCode,
              @LandlineNo,
              @MobileNo,
              @DateAdmitted,
              @DateDischarged,
              @Occupation,
              @MaritalStatus,
              @SexualOrientation,
              @Ethnicity,
              @FirstLanguage,
              @Religion,
              @NextOfKin,
              @NextOfKinPhoneNo,
              @GPDetails,
              @Notes,
              @WardNo,
              @TreatmentID;

              RETURN @@Identity
                **/
        public Int32 InsertPatient(clsPatient NewPatient)
        {
 
            // Add the paramters to the query for inserting the new patient properties into the DB
            MyDatabase.AddParameter("Title", NewPatient.Title);
            MyDatabase.AddParameter("FirstName", NewPatient.FirstName);
            MyDatabase.AddParameter("LastName", NewPatient.LastName);
            MyDatabase.AddParameter("DateOfBirth", NewPatient.DateOfBirth);
            MyDatabase.AddParameter("Gender", NewPatient.Gender);
            MyDatabase.AddParameter("Street", NewPatient.Street);
            MyDatabase.AddParameter("Town", NewPatient.Town);
            MyDatabase.AddParameter("County", NewPatient.County);
            MyDatabase.AddParameter("PostCode", NewPatient.PostCode);
            MyDatabase.AddParameter("LandlineNo", NewPatient.LandlineNo);
            MyDatabase.AddParameter("MobileNo", NewPatient.MobileNo);
            MyDatabase.AddParameter("DateAdmitted", NewPatient.DateAdmitted);
            MyDatabase.AddParameter("DateDischarged", NewPatient.DateDischarged);
            MyDatabase.AddParameter("Occupation", NewPatient.Occupation);
            MyDatabase.AddParameter("MaritalStatus", NewPatient.MaritalStatus);
            MyDatabase.AddParameter("SexualOrientation", NewPatient.SexualOrientation);
            MyDatabase.AddParameter("Ethnicity", NewPatient.Ethnicity);
            MyDatabase.AddParameter("FirstLanguage", NewPatient.FirstLanguage);
            MyDatabase.AddParameter("Religion", NewPatient.Religion);
            MyDatabase.AddParameter("NextOfKin", NewPatient.NextOfKin);
            MyDatabase.AddParameter("NextOfKinPhoneNo", NewPatient.NextOfKinPhoneNo);
            MyDatabase.AddParameter("GPDetails", NewPatient.GPDetails);
            MyDatabase.AddParameter("Notes", NewPatient.Notes);

            //the two foreign keys to insert as well in a patient record are 
            MyDatabase.AddParameter("WardNo", NewPatient.WardNo);
            MyDatabase.AddParameter("TreatmentID", NewPatient.TreatmentID);

            //Execute the Insert procedure 
            // bearing in mind that it always returns the PK value @@Identity of any record so return needs to added in this function

            return MyDatabase.Execute("sproc_tblPatient_Insert");
        }



        /**This function will update an existing patient  in the database without returning a value 
           it accepts a single parameter an object of type clsPatient
           the PatientID property must have a valid value for this to work
            
           @PatientID     int,
            ....... other added paramaters

           UPDATE tblPatient
           SET
           Title = @Title,
           FirstName = @FirstName,
           LastName = @LastName,
           DateOfBirth = @DateOfBirth,
           Gender = @Gender,
           Street = @Street,
           Town = @Town,
           County = @County,
           PostCode = @PostCode,
           LandlineNo = @LandlineNo,
           MobileNo = @MobileNo,
           DateAdmitted = @DateAdmitted,
           DateDischarged = @DateDischarged,
           Occupation = @Occupation,
           MaritalStatus = @MaritalStatus,
           SexualOrientation = @SexualOrientation,
           Ethnicity = @Ethnicity,
           FirstLanguage = @FirstLanguage,
           Religion = @Religion,
           NextOfKin = @NextOfKin,
           NextOfKinPhoneNo = @NextOfKinPhoneNo,
           GPDetails = @GPDetails,
           Notes = @Notes,
           WardNo = @WardNo,
           TreatmentID = @TreatmentID

         -- where the PatientID selected matches the PatientID of the patient we want to update

          WHERE PatientID = @PatientID;
          RETURN 0
            **/

        public void UpdatePatient(clsPatient ExistingPatient)
        {
            // Add the Primary Key PatientID to the query
            MyDatabase.AddParameter("PatientID", ExistingPatient.PatientID);

            // Add the others parameters to the query
            MyDatabase.AddParameter("Title", ExistingPatient.Title);
            MyDatabase.AddParameter("FirstName", ExistingPatient.FirstName);
            MyDatabase.AddParameter("LastName", ExistingPatient.LastName);
            MyDatabase.AddParameter("DateOfBirth", ExistingPatient.DateOfBirth);
            MyDatabase.AddParameter("Gender", ExistingPatient.Gender);
            MyDatabase.AddParameter("Street", ExistingPatient.Street);
            MyDatabase.AddParameter("Town", ExistingPatient.Town);
            MyDatabase.AddParameter("County", ExistingPatient.County);
            MyDatabase.AddParameter("PostCode", ExistingPatient.PostCode);
            MyDatabase.AddParameter("LandlineNo", ExistingPatient.LandlineNo);
            MyDatabase.AddParameter("MobileNo", ExistingPatient.MobileNo);
            MyDatabase.AddParameter("DateAdmitted", ExistingPatient.DateAdmitted);
            MyDatabase.AddParameter("DateDischarged", ExistingPatient.DateDischarged);
            MyDatabase.AddParameter("Occupation", ExistingPatient.Occupation);
            MyDatabase.AddParameter("MaritalStatus", ExistingPatient.MaritalStatus);
            MyDatabase.AddParameter("SexualOrientation", ExistingPatient.SexualOrientation);
            MyDatabase.AddParameter("Ethnicity", ExistingPatient.Ethnicity);
            MyDatabase.AddParameter("FirstLanguage", ExistingPatient.FirstLanguage);
            MyDatabase.AddParameter("Religion", ExistingPatient.Religion);
            MyDatabase.AddParameter("NextOfKin", ExistingPatient.NextOfKin);
            MyDatabase.AddParameter("NextOfKinPhoneNo", ExistingPatient.NextOfKinPhoneNo);
            MyDatabase.AddParameter("GPDetails", ExistingPatient.GPDetails);
            MyDatabase.AddParameter("Notes", ExistingPatient.Notes);

            //the two foreign keys to insert as well in a patient record are 
            MyDatabase.AddParameter("WardNo", ExistingPatient.WardNo);
            MyDatabase.AddParameter("TreatmentID", ExistingPatient.TreatmentID);

            //Just Execute the update procedure 
            MyDatabase.Execute("sproc_tblPatient_Update");
        }


        ///This property finds a patient record based on the primary key value passed as a parameter
        /// It returns an instance of clsPatient populated with the data if the record is found
        /// If the record is not not found it returns a null value 
        public clsPatient FindPatient(Int32 PatientID)
        {

            //add the parameter named @PatientID 
            MyDatabase.AddParameter("@PatientID", PatientID);

            // Execute the procedure 
            MyDatabase.Execute("sproc_tblPatient_FilterByPatientID");

            //If only one record is found which is obvious since one primary key refers to one only counted record
            if (MyDatabase.Count == 1)
            {
                // create an instance of clsPatient
                clsPatient ThisPatientRecord = new clsPatient();

                // Now let us  Copy this data record data from the database at index 0 since it is the only record
                // since the obvious index is 0 for this record on a table as it is the only found record
                ThisPatientRecord.PatientID = Convert.ToInt32(MyDatabase.DataTable.Rows[0]["PatientID"]);
                ThisPatientRecord.Title = Convert.ToString(MyDatabase.DataTable.Rows[0]["Title"]);
                ThisPatientRecord.FirstName = Convert.ToString(MyDatabase.DataTable.Rows[0]["FirstName"]);
                ThisPatientRecord.LastName = Convert.ToString(MyDatabase.DataTable.Rows[0]["LastName"]);
                ThisPatientRecord.DateOfBirth = Convert.ToDateTime(MyDatabase.DataTable.Rows[0]["DateOfBirth"]);
                ThisPatientRecord.Gender = Convert.ToString(MyDatabase.DataTable.Rows[0]["Gender"]);
                ThisPatientRecord.Street = Convert.ToString(MyDatabase.DataTable.Rows[0]["Street"]);
                ThisPatientRecord.Town = Convert.ToString(MyDatabase.DataTable.Rows[0]["Town"]);
                ThisPatientRecord.County = Convert.ToString(MyDatabase.DataTable.Rows[0]["County"]);
                ThisPatientRecord.PostCode = Convert.ToString(MyDatabase.DataTable.Rows[0]["PostCode"]);
                ThisPatientRecord.LandlineNo = Convert.ToString(MyDatabase.DataTable.Rows[0]["LandlineNo"]);
                ThisPatientRecord.MobileNo = Convert.ToString(MyDatabase.DataTable.Rows[0]["MobileNo"]);
                ThisPatientRecord.DateAdmitted = Convert.ToDateTime(MyDatabase.DataTable.Rows[0]["DateAdmitted"]);
                ThisPatientRecord.DateDischarged = Convert.ToDateTime(MyDatabase.DataTable.Rows[0]["DateDischarged"]);
                ThisPatientRecord.Occupation = Convert.ToString(MyDatabase.DataTable.Rows[0]["Occupation"]);
                ThisPatientRecord.MaritalStatus = Convert.ToString(MyDatabase.DataTable.Rows[0]["MaritalStatus"]);
                ThisPatientRecord.SexualOrientation = Convert.ToString(MyDatabase.DataTable.Rows[0]["SexualOrientation"]);
                ThisPatientRecord.Ethnicity = Convert.ToString(MyDatabase.DataTable.Rows[0]["Ethnicity"]);
                ThisPatientRecord.FirstLanguage = Convert.ToString(MyDatabase.DataTable.Rows[0]["FirstLanguage"]);
                ThisPatientRecord.Religion = Convert.ToString(MyDatabase.DataTable.Rows[0]["Religion"]);
                ThisPatientRecord.NextOfKin = Convert.ToString(MyDatabase.DataTable.Rows[0]["NextOfKin"]);
                ThisPatientRecord.NextOfKinPhoneNo = Convert.ToString(MyDatabase.DataTable.Rows[0]["NextOfKinPhoneNo"]);
                ThisPatientRecord.GPDetails = Convert.ToString(MyDatabase.DataTable.Rows[0]["GPDetails"]);
                ThisPatientRecord.Notes = Convert.ToString(MyDatabase.DataTable.Rows[0]["Notes"]);

                ThisPatientRecord.WardNo = Convert.ToInt32(MyDatabase.DataTable.Rows[0]["WardNo"]);
                ThisPatientRecord.TreatmentID = Convert.ToInt32(MyDatabase.DataTable.Rows[0]["TreatmentID"]);

                // return the Object ThisPatientRecord
                return ThisPatientRecord;

            }

            else
            {
                //return a null value
                return null;
            }

        }



    }
}
