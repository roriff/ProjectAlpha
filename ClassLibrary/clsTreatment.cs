using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsTreatment
    {
        // Declare all the variables private so we will use them to store the values from the database
        // making them private is using the principle of encapsulation
        private Int32 treatmentID;
        private string treatementType;
        private string medicalCondition;
        private string medicationGiven;
        private string comments;

        //Now we de-encapsulate them variables by creating the variables individual public property making them public
        public Int32 TreatmentID { get { return treatmentID; } set { treatmentID = value; } }
        public string TreatmentType { get { return treatementType; } set { treatementType = value; } }
        public string MedicalCondition { get { return medicalCondition; } set { medicalCondition = value; } }
        public string MedicationGiven { get { return medicationGiven; } set { medicationGiven = value; } }
        public string Comments { get { return comments; } set { comments = value; } }


        //Validate Medication given
        public string ValidateMedication(string Medication)
        {
            string MedicationErrMsg = "";

            if (Medication.Length == 0)
            {
                return MedicationErrMsg;
            }
            else if (Medication.Length > 50)
            {
                MedicationErrMsg = "Medication No more than 50 characters";
            }
            return MedicationErrMsg;

        }

        //Validate Medication given
        public string ValidateComments(string Comments)
        {
            string CommentsErrMsg = "";

            if (Comments.Length == 0)
            {
                return CommentsErrMsg;
            }
            else if (Comments.Length > 1000)
            {
                CommentsErrMsg = "Comments No more than 1000 characters";
            }
            return CommentsErrMsg;

        }
    }
}
