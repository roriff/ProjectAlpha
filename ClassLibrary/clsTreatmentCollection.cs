using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsTreatmentCollection
    {
        // constructor
        public clsTreatmentCollection()
        {

        }

        // create an instance of the data connection class called MyDatabase
        clsDataConnection MyDatabase = new clsDataConnection();


        // method to find the treatment details
        public clsTreatment FindPatientTreatment(Int32 TreatmentID)
        {

            //add the parameter named @PatientID 
            MyDatabase.AddParameter("@TreatmentID", TreatmentID);

            // Execute the procedure 
            MyDatabase.Execute("sproc_tblTreatment_FilterByTreatmentID");

            //If only one record is found which is obvious since one primary key refers to one only counted record
            if (MyDatabase.Count == 1)
            {
                // create an instance of clsPatient
                clsTreatment ThisTreatmentRecord = new clsTreatment();

                ThisTreatmentRecord.TreatmentID = Convert.ToInt32(MyDatabase.DataTable.Rows[0]["TreatmentID"]);
                ThisTreatmentRecord.TreatmentType = Convert.ToString(MyDatabase.DataTable.Rows[0]["TreatmentType"]);
                ThisTreatmentRecord.MedicalCondition = Convert.ToString(MyDatabase.DataTable.Rows[0]["MedicalCondition"]);
                ThisTreatmentRecord.MedicationGiven = Convert.ToString(MyDatabase.DataTable.Rows[0]["MedicationGiven"]);
                ThisTreatmentRecord.Comments = Convert.ToString(MyDatabase.DataTable.Rows[0]["Comments"]);
                
                // return the Object ThisPatientRecord
                return ThisTreatmentRecord;

            }

            else
            {
                //return a null value
                return null;
            }

        }

        // method to find the treatmentID
        public Int32 FindTreatment(Int32 PatientID)
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

                ThisPatientRecord.TreatmentID = Convert.ToInt32(MyDatabase.DataTable.Rows[0]["TreatmentID"]);

                // return the Object ThisPatientRecord
                return ThisPatientRecord.TreatmentID;

            }

            else
            {
                //return a TreatmentId with  value = 0 which is the first TreatmentID (Not stated)
                return 0; // Not stated which has the TreatmentID 0 
            }

        }

    }
}
