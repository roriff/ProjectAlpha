using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstObservation
    {
  
        [TestMethod]
        public void InstanceObservationOK()
        {
            //create an instance of the class we want to create
            clsObservation TestObs = new clsObservation();
            //test to see that the instance actually exists
            Assert.IsNotNull(TestObs);
        }

        /*Testing the attribute ObservationID which is an auto generated number*/
        [TestMethod]
        public void ObservationIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsObservation TestObs = new clsObservation();
            //create some test data to assign to the property
            Int32 SomeObsID = 1;
            //assign the test data to the property
            TestObs.ObservationID = SomeObsID;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestObs.ObservationID, SomeObsID);
        }

        /******** Testing for the weight property of a patient's observation **********/
        [TestMethod]
        public void WeightPropertyOK()
        {
            // create an instance of the class we want to create
            clsObservation TestObservation = new clsObservation();
            //create some test data to assign to the property
            double SomeWeight = 80.90;
            //assign the test data to the property
            TestObservation.PatientWeight = SomeWeight;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestObservation.PatientWeight, SomeWeight);
        }


        // test  for min less one value. should return an error msg 
        [TestMethod]
        public void WeightMinLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeWeight = "19";
            string ExpectedReturnMsg = "The weight can only be between 20kg minimum to 300kg max";
            string WeightErrorMsg = TestObservation.ValidateWeight(SomeWeight);
            Assert.AreEqual(WeightErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value of weight which is 20kg , return success
        [TestMethod]
        public void WeightMin()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeWeight = "20.00";
            string ExpectedReturnMsg = "";
            string WeightErrorMsg = TestObservation.ValidateWeight(SomeWeight);
            Assert.AreEqual(WeightErrorMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 , return success
        [TestMethod]
        public void WeightMinPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeWeight = "21.00";
            string ExpectedReturnMsg = "";
            string WeightErrorMsg = TestObservation.ValidateWeight(SomeWeight);
            Assert.AreEqual(WeightErrorMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 being 300- 1 = 299kg
        [TestMethod]
        public void WeightMaxLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeWeight = "299.00";
            string ExpectedReturnMsg = "";
            string WeightErrorMsg = TestObservation.ValidateWeight(SomeWeight);
            Assert.AreEqual(WeightErrorMsg, ExpectedReturnMsg);

        }

        // test for maximum value 300kg, return success
        [TestMethod]
        public void WeightMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeWeight = "300.00";
            string ExpectedReturnMsg = "";
            string WeightErrorMsg = TestObservation.ValidateWeight(SomeWeight);
            Assert.AreEqual(WeightErrorMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 (301kg).  should return error msg as 300kg is max weight
        [TestMethod]
        public void WeightMaxPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeWeight = "301.00";
            string ExpectedReturnMsg = "The weight can only be between 20kg minimum to 300kg max";
            string WeightErrorMsg = TestObservation.ValidateWeight(SomeWeight);
            Assert.AreEqual(WeightErrorMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 500 kg, return error
        [TestMethod]
        public void WeightExtremeMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeWeight = "500.00";
            string ExpectedReturnMsg = "The weight can only be between 20kg minimum to 300kg max";
            string WeightErrorMsg = TestObservation.ValidateWeight(SomeWeight);
            Assert.AreEqual(WeightErrorMsg, ExpectedReturnMsg);
        }

        /******** Testing for the height property of a patient's observation **********/
        [TestMethod]
        public void HeightPropertyOK()
        {
            // create an instance of the class we want to create
            clsObservation TestObservation = new clsObservation();
            //create some test data to assign to the property
            double SomeHeight = 1.90;
            //assign the test data to the property
            TestObservation.Height = SomeHeight;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestObservation.Height, SomeHeight);
        }


        // test  for min less one value. should return an error
        [TestMethod]
        public void HeightMinLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeWeight = "0.4";
            string ExpectedReturnMsg = "The height can only be between 0.5m minimum to 3m max";
            string HeightErrorMsg = TestObservation.ValidateHeight(SomeWeight);
            Assert.AreEqual(HeightErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value of weight which is 0.5m , return success
        [TestMethod]
        public void HeightMin()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeHeight = "0.5";
            string ExpectedReturnMsg = "";
            string HeightErrorMsg = TestObservation.ValidateHeight(SomeHeight);
            Assert.AreEqual(HeightErrorMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 , return success
        [TestMethod]
        public void HeightMinPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeHeight = "1.50";
            string ExpectedReturnMsg = "";
            string HeightErrorMsg = TestObservation.ValidateHeight(SomeHeight);
            Assert.AreEqual(HeightErrorMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 being 3 -1 = 2m
        [TestMethod]
        public void HeightMaxLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeHeight = "2.00";
            string ExpectedReturnMsg = "";
            string HeightErrorMsg = TestObservation.ValidateHeight(SomeHeight);
            Assert.AreEqual(HeightErrorMsg, ExpectedReturnMsg);

        }

        // test for maximum value 3 m, return success
        [TestMethod]
        public void HeightMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeHeight = "3.00";
            string ExpectedReturnMsg = "";
            string HeightErrorMsg = TestObservation.ValidateHeight(SomeHeight);
            Assert.AreEqual(HeightErrorMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 = 4m .  should return error msg as 3 m is max height
        [TestMethod]
        public void HeightMaxPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeHeight = "301.00";
            string ExpectedReturnMsg = "The height can only be between 0.5m minimum to 3m max";
            string HeightErrorMsg = TestObservation.ValidateHeight(SomeHeight);
            Assert.AreEqual(HeightErrorMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 5 m , return error
        [TestMethod]
        public void HeightExtremeMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeHeight = "5.00";
            string ExpectedReturnMsg = "The height can only be between 0.5m minimum to 3m max";
            string HeightErrorMsg = TestObservation.ValidateHeight(SomeHeight);
            Assert.AreEqual(HeightErrorMsg, ExpectedReturnMsg);
        }

        /******** Testing for the temperature property of a patient's observation **********/
        [TestMethod]
        public void TemperaturePropertyOK()
        {
            // create an instance of the class we want to create
            clsObservation TestObservation = new clsObservation();
            //create some test data to assign to the property
            double SomeTemperature = 36.4;
            //assign the test data to the property
            TestObservation.Temperature = SomeTemperature;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestObservation.Temperature, SomeTemperature);
        }


        // test  for min less one value. should return an error
        [TestMethod]
        public void TemperatureMinLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeTemp = "26.00";
            string ExpectedReturnMsg = "The temperature can only be between 27 minimum to 45 max";
            string TempErrorMsg = TestObservation.ValidateTemperature(SomeTemp);
            Assert.AreEqual(TempErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value of the temperature which is 27 , returns success
        [TestMethod]
        public void TemperatureMin()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeTemp = "27.00";
            string ExpectedReturnMsg = "";
            string TempErrorMsg = TestObservation.ValidateTemperature(SomeTemp);
            Assert.AreEqual(TempErrorMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 , return success
        [TestMethod]
        public void TempMinPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeTemp = "28.00";
            string ExpectedReturnMsg = "";
            string TempErrorMsg = TestObservation.ValidateTemperature(SomeTemp);
            Assert.AreEqual(TempErrorMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 being 45 -1 = 44
        [TestMethod]
        public void TempMaxLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeTemp = "44.00";
            string ExpectedReturnMsg = "";
            string TempErrorMsg = TestObservation.ValidateTemperature(SomeTemp);
            Assert.AreEqual(TempErrorMsg, ExpectedReturnMsg);

        }

        // test for maximum value 45, return success
        [TestMethod]
        public void TempMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeTemp = "45.00";
            string ExpectedReturnMsg = "";
            string TempErrorMsg = TestObservation.ValidateTemperature(SomeTemp);
            Assert.AreEqual(TempErrorMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 = 46 .  should return error msg as 45 is max temperature
        [TestMethod]
        public void TempMaxPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeTemp= "46.00";
            string ExpectedReturnMsg = "The temperature can only be between 27 minimum to 45 max";
            string TempErrorMsg = TestObservation.ValidateTemperature(SomeTemp);
            Assert.AreEqual(TempErrorMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 50 , return error
        [TestMethod]
        public void TempExtremeMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeTemp= "50.00";
            string ExpectedReturnMsg = "The temperature can only be between 27 minimum to 45 max";
            string TempErrorMsg = TestObservation.ValidateTemperature(SomeTemp);
            Assert.AreEqual(TempErrorMsg, ExpectedReturnMsg);
        }

        /******** Testing for the blood pressure property of a patient's observation **********/
        [TestMethod]
        public void BloodPressurePropertyOK()
        {
            // create an instance of the class we want to create
            clsObservation TestObservation = new clsObservation();
            //create some test data to assign to the property
            string SomeBP = "179 / 29 ";
            //assign the test data to the property
            TestObservation.BloodPressure = SomeBP;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestObservation.BloodPressure, SomeBP);
        }


        // test  for min less one value. should return an error
        [TestMethod]
        public void BloodPressureMinLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeBP = "";
            string ExpectedReturnMsg = "";
            string BPErrorMsg = TestObservation.ValidateBloodPressure(SomeBP);
            Assert.AreEqual(BPErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value of the blood pressure which is 1 , returns success
        [TestMethod]
        public void BloodPressureMin()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeBP = "1";
            string ExpectedReturnMsg = "";
            string BPErrorMsg = TestObservation.ValidateBloodPressure(SomeBP);
            Assert.AreEqual(BPErrorMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 , return success
        [TestMethod]
        public void BloodPressureMinPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeBP = "21";
            string ExpectedReturnMsg = "";
            string BPErrorMsg = TestObservation.ValidateBloodPressure(SomeBP);
            Assert.AreEqual(BPErrorMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 being 10 -1 = 9 characters
        [TestMethod]
        public void BloodPressureMaxLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeBP = " 179/127 ";
            string ExpectedReturnMsg = "";
            string BPErrorMsg = TestObservation.ValidateBloodPressure(SomeBP);
            Assert.AreEqual(BPErrorMsg, ExpectedReturnMsg);

        }

        // test for maximum value 10 characters, return success
        [TestMethod]
        public void BloodPressureMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeBP = " 180 / 66 ";
            string ExpectedReturnMsg = "";
            string BPErrorMsg = TestObservation.ValidateBloodPressure(SomeBP);
            Assert.AreEqual(BPErrorMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 = 11 charcters .  should return error msg as 10 characters is max temperature
        [TestMethod]
        public void BloodPressureMaxPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeBP = "181/123cc45";
            string ExpectedReturnMsg = "Blood Pressure No more than 10 characters";
            string BPErrorMsg = TestObservation.ValidateBloodPressure(SomeBP);
            Assert.AreEqual(BPErrorMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 20 cahracters , return error
        [TestMethod]
        public void BloodPressureExtremeMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeBP = "200/286Pressure";
            string ExpectedReturnMsg = "Blood Pressure No more than 10 characters";
            string BPErrorMsg = TestObservation.ValidateBloodPressure(SomeBP);
            Assert.AreEqual(BPErrorMsg, ExpectedReturnMsg);
        }



        /******** Testing for the pulse property of a patient's observation **********/
        [TestMethod]
        public void PulsePropertyOK()
        {
            // create an instance of the class we want to create
            clsObservation TestObservation = new clsObservation();
            //create some test data to assign to the property
            int SomePulse = 79;
            //assign the test data to the property
            TestObservation.Pulse= SomePulse;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestObservation.Pulse, SomePulse);
        }


        // test  for min less one value. should return an error
        [TestMethod]
        public void PulseMinLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomePulse = "19";
            string ExpectedReturnMsg = "The Pulse can only be between 20 minimum to 180 max";
            string PulseErrorMsg = TestObservation.ValidatePulse(SomePulse);
            Assert.AreEqual(PulseErrorMsg, ExpectedReturnMsg);
        }
        // test for minimum value of the temperature which is 20 , returns success
        [TestMethod]
        public void PulseMin()
        {
            clsObservation TestObservation = new clsObservation();
            string SomePulse = "20";
            string ExpectedReturnMsg = "";
            string PulseErrorMsg = TestObservation.ValidatePulse(SomePulse);
            Assert.AreEqual(PulseErrorMsg, ExpectedReturnMsg);
        }

        // test  for minimum value plus 1 , return success
        [TestMethod]
        public void PulseMinPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomePulse = "21";
            string ExpectedReturnMsg = "";
            string PulseErrorMsg = TestObservation.ValidatePulse(SomePulse);
            Assert.AreEqual(PulseErrorMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 being 180 -1 = 179
        [TestMethod]
        public void PulseMaxLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomePulse = "179";
            string ExpectedReturnMsg = "";
            string PulseErrorMsg = TestObservation.ValidatePulse(SomePulse);
            Assert.AreEqual(PulseErrorMsg, ExpectedReturnMsg);

        }

        // test for maximum value 180, return success
        [TestMethod]
        public void PulseMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomePulse = "180";
            string ExpectedReturnMsg = "";
            string PulseErrorMsg = TestObservation.ValidatePulse(SomePulse);
            Assert.AreEqual(PulseErrorMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 = 181 .  should return error msg as 180 is max temperature
        [TestMethod]
        public void PulseMaxPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomePulse = "181";
            string ExpectedReturnMsg = "The Pulse can only be between 20 minimum to 180 max";
            string PulseErrorMsg = TestObservation.ValidatePulse(SomePulse);
            Assert.AreEqual(PulseErrorMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 200 , return error
        [TestMethod]
        public void PulseExtremeMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomePulse = "200";
            string ExpectedReturnMsg = "The Pulse can only be between 20 minimum to 180 max";
            string PulseErrorMsg = TestObservation.ValidatePulse(SomePulse);
            Assert.AreEqual(PulseErrorMsg, ExpectedReturnMsg);
        }




        /*****  Testing for DateTimeTaken Property of the observation *****/
        // only test as the date is generated by the system as the actual day date when the observation is taken
        [TestMethod]
        public void DateTimeTaken()
        {
            clsObservation TestObservation= new clsObservation();
            TestObservation.DateTimeTaken = DateTime.Now;
        }

        // Test the Min of dateTimeTaken being on the day the observation is done
        [TestMethod]
        public void DateTimeTakenMin()
        {
            clsObservation TestObservation= new clsObservation();
            string SomeDateTimeTaken = Convert.ToString(DateTime.Today);
            string ExpectedReturnMsg = "";
            string DateTimeTakenErrMsg = TestObservation.ValidateDateTimeTaken(SomeDateTimeTaken);
            Assert.AreEqual(DateTimeTakenErrMsg, ExpectedReturnMsg);
        }


        // Test the Max of DateTimeTaken being on the day the observation is done
        [TestMethod]
        public void DateTimetakenMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeDateTimeTaken = Convert.ToString(DateTime.Today);
            string ExpectedReturnMsg = "";
            string DateTimeTakenErrMsg = TestObservation.ValidateDateTimeTaken(SomeDateTimeTaken);
            Assert.AreEqual(DateTimeTakenErrMsg, ExpectedReturnMsg);

        }

        /******** Testing for Mental state Notes property of Patient's observation **********/
        [TestMethod]
        public void MentalSateNotesPropertyOK()
        {
            // create an instance of the class we want to create
            clsObservation TestObservation = new clsObservation();
            //create some test data to assign to the property
            string SomeNotes = "James mental state has been up and down today, he seems unsettled.";
            //assign the test data to the property
            TestObservation.MentalStateNotes = SomeNotes;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestObservation.MentalStateNotes, SomeNotes);
        }

        /******** Testing for Physical state Notes property of Patient's observation **********/
        [TestMethod]
        public void PhysicalSateNotesPropertyOK()
        {
            // create an instance of the class we want to create
            clsObservation TestObservation= new clsObservation();
            //create some test data to assign to the property
            string SomeNotes = "James physical state is of no concern, his vital signs are all fine";
            //assign the test data to the property
            TestObservation.PhysicalStateNotes = SomeNotes;
            //test to see that the two values are in fact the same
            Assert.AreEqual(TestObservation.PhysicalStateNotes, SomeNotes);
        }

        // test  for blank string. should return success msg as it is not a required attribute
        [TestMethod]
        public void NotesMinLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeNotes = "";
            string ExpectedReturnMsg = "";
            string NotesErrorMsg = TestObservation.ValidateNotes(SomeNotes);
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
            clsObservation TestObservation = new clsObservation();
            string SomeNotes = "Ca";
            string ExpectedReturnMsg = "";
            string NotesErrMsg = TestObservation.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value minus 1 (2999 characters).  should return blank string (no error message)
        [TestMethod]
        public void NotesMaxLessOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeNotes = "";
            SomeNotes = SomeNotes.PadLeft(4999);
            string ExpectedReturnMsg = "";
            string NotesErrMsg = TestObservation.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);
        }

        // test for maximum value (3000 characters).  should accept it and return blank string (no error message)
        [TestMethod]
        public void NotesMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeNotes = "";
            SomeNotes = SomeNotes.PadLeft(5000);
            string ExpectedReturnMsg = "";
            string NotesErrMsg = TestObservation.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);
        }
        // test for maximum value plus 1 (3001 characters).  should return error msg as 3000 characters max
        [TestMethod]
        public void NotesMaxPlusOne()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeNotes = "";
            SomeNotes = SomeNotes.PadLeft(5001);
            string ExpectedReturnMsg = "Notes No more than 5000 characters";
            string NotesErrMsg = TestObservation.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);

        }
        // test for its extreme max value being 5000 characters
        [TestMethod]
        public void NotesExtremeMax()
        {
            clsObservation TestObservation = new clsObservation();
            string SomeNotes = "";
            SomeNotes = SomeNotes.PadLeft(10000);
            string ExpectedReturnMsg = "Notes No more than 5000 characters";
            string NotesErrMsg = TestObservation.ValidateNotes(SomeNotes);
            Assert.AreEqual(NotesErrMsg, ExpectedReturnMsg);
        }

        /**** Test PatientID Property ****/
        // only one test as data generated by system
        [TestMethod]
        public void PatientID()
        {
            clsPatient TestPatient = new clsPatient();
            TestPatient.PatientID = 1;
        }

        /*** Test StaffID Property ***/
        // only one test as data generated by system
        [TestMethod]
        public void StaffID()
        {
            clsStaff TestPatient = new clsStaff();
            TestPatient.StaffID = 1;
        }
    }
}
