using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class clsObservation
    {
  
        // private attributes that are encapsulated
        private Int32 observationID;
        private string observationType;
        private double patientWeight;
        private double height;
        private double temperature;
        private string bloodPressure;
        private Int32 pulse;
        private string mriScanImage;
        private DateTime dateTimeTaken; // date and time observation was taken
        private string physicalStateNotes;
        private string mentalStateNotes;
        
        private Int32 staffID;
        private Int32 patientID;
        

        //public properties for de-encapsulation
        public Int32 ObservationID { get { return observationID; } set { observationID = value; }}
        public string ObservationType { get { return observationType; } set { observationType = value; } }
        public double PatientWeight { get { return patientWeight; } set { patientWeight = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Temperature { get { return temperature; } set { temperature = value; } }
        public Int32 Pulse { get { return pulse; } set { pulse = value; } }
        public string BloodPressure { get { return bloodPressure; } set { bloodPressure = value; } }

        public DateTime DateTimeTaken { get { return dateTimeTaken; } set { dateTimeTaken = value; } }
        public string MRIScanImage { get { return mriScanImage; } set { mriScanImage = value; } }
        public string PhysicalStateNotes { get { return physicalStateNotes; } set { physicalStateNotes = value; } }
        public string MentalStateNotes { get { return mentalStateNotes; } set { mentalStateNotes = value; } }

        public Int32 StaffID { get { return staffID; } set { staffID = value; } }
        public Int32 PatientID { get { return patientID; } set { patientID = value; } }

       

        // validation methods for both PhysicalStateNotes and MentalStateNotes
        public string ValidateNotes(string SomeNotes)
        {
            string NotesErrMsg = "";

            if (SomeNotes.Length == 0)
            {
                return NotesErrMsg;
            }
            else if (SomeNotes.Length > 5000)
            {
                NotesErrMsg = "Notes No more than 5000 characters";
            }
            return NotesErrMsg;
        }

        // validate the weight of a patient 
        public string ValidateWeight(string someWeight)
        {
            string WeightErrMsg = "";
            string ErrorMessage = "The weight can only be between 20kg minimum to 300kg max";

            try
            {
                double tempWeight; // Temporary variable to store the value of a weight
                tempWeight = Convert.ToDouble(someWeight); // Convert the string Value input and Assign it to the temporary variable

                if ((tempWeight < 20) || (tempWeight > 300))
                {
                    WeightErrMsg = "The weight can only be between 20kg minimum to 300kg max";
                }
            }
            catch
            {
                return ErrorMessage;
            }

            return WeightErrMsg;
        }

        // validate the height of a patient 
        public string ValidateHeight(string someHeight)
        {
            string HeightErrMsg = "";
            string ErrorMessage = "The height can only be between 0.5m minimum to 3m max";

            try
            {
                double tempHeight; // Temporary variable to store the value of a height
                tempHeight = Convert.ToDouble(someHeight); // Convert the string Value input and Assign it to the temporary variable

                if ((tempHeight < 0.5) || (tempHeight > 3))
                {
                    HeightErrMsg = "The height can only be between 0.5m minimum to 3m max";
                }
            }
            catch
            {
                return ErrorMessage;
            }

            return HeightErrMsg;
        }

        // validate the temperature of a patient 
        public string ValidateTemperature(string someTemperature)
        {
            string TemperatureErrMsg = "";
            string ErrorMessage = "The temperature can only be between 27 minimum to 42 max";

            try
            {
                double temp; // Temporary variable to store the value of a temperature
                temp = Convert.ToDouble(someTemperature); // Convert the string Value input and Assign it to the temporary variable

                if ((temp < 27) || (temp > 45))
                {
                    TemperatureErrMsg = "The temperature can only be between 27 minimum to 45 max";
                }
            }
            catch
            {
                return ErrorMessage;
            }

            return TemperatureErrMsg;
        }

        // validate Blood pressure
        public string ValidateBloodPressure(string BloodPressure)
        {
            string BloodPressureErrMsg = "";

            if (BloodPressure.Length == 0)
            {
                return BloodPressureErrMsg;
            }
            else if (BloodPressure.Length > 10)
            {
                BloodPressureErrMsg = "Blood Pressure No more than 10 characters";
            }
            return BloodPressureErrMsg;
        }

        // validate the pulse of a patient 
        public string ValidatePulse(string somePulse)
        {
            string PulseErrMsg = "";
            string ErrorMessage = "The Pulse can only be between 20 minimum to 180 max";

            try
            {
                int tempPulse; // Temporary variable to store the value of the pulse
                tempPulse = Convert.ToInt32(somePulse); // Convert the string Value input and Assign it to the temporary variable

                if ((tempPulse < 20) || (tempPulse> 180))
                {
                    PulseErrMsg = "The Pulse can only be between 20 minimum to 180 max";
                }
            }
            catch
            {
                return ErrorMessage;
            }

            return PulseErrMsg;
        }


        //Method to check the date and time of the observation done
        public string ValidateDateTimeTaken(string ObservationDate)
        {
            string DateObservationErrMsg = "";
            string ErrorMessage = "Observation date can only be between 1934 and today";

            try
            {
                // variable to store the date
                DateTime tempDate;
                // assign the date to the temporary variable
                tempDate = Convert.ToDateTime(ObservationDate);

                
                // 1 jan 1934 < Observation Date < Today
                if (tempDate > DateTime.Today)
                {
                    // record an error
                    DateObservationErrMsg = "observation date can't be after today in the future";
                }
                
                else if (tempDate < DateTime.Parse("1 jan 1934"))
                {
                    // record an error
                    DateObservationErrMsg = "Observation date can't be before 1 jan 1934";
                }

            }
            catch
            {
                // record an error message that is general of the two tests
                return ErrorMessage;
            }

            return DateObservationErrMsg;
        }

        
    }
}