﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace ClassLibrary
{
    public class clsObservationCollection
    {

        //global variable MyDatabase
        clsDataConnection MyDatabase = new clsDataConnection();

        // constructor
        public clsObservationCollection()
        {
        }

        /** Insert method to add an observation into the database
        
           This function will help us add a new observation to the database
           It accepts a single parameter which is an object of type clsObservation
           Once the function is added the function returns the primary key value of the new record
           
                 @ObservationType     VARCHAR(20),
                 @PatientWeight       DECIMAL(5,2),  
                 @Height              DECIMAL(5,2),
                 @Temperature         DECIMAL(5,2),
                 @BloodPressure       VARCHAR (10),
                 @Pulse               INT,
                 @DateTimeTaken       DATETIME,
	             @MRIScanImage        VARCHAR(MAX),
                 @PhysicalStateNotes  TEXT,
                 @MentalStateNotes    TEXT,
                 @PatientID           INT,
	             @StaffID             INT
            AS
        -- insert the value stored in the parameters into the fields of the new record
	       INSERT INTO tblObservation
         (ObservationType,
          PatientWeight,  
          Height,
          Temperature,
          BloodPressure,
          Pulse,
          DateTimeTaken,
          MRIScanImage,
          PhysicalStateNotes,
          MentalStateNotes,
          PatientID,
	      StaffID)

	     SELECT 
	     @ObservationType,
         @PatientWeight,  
         @Height,
         @Temperature,
         @BloodPressure,
         @Pulse,
         Format(@DateTimeTaken,'MM/dd/yyyy hh:mm tt'),
	     @MRIScanImage,
         @PhysicalStateNotes,
         @MentalStateNotes,
         @PatientID,
         @StaffID;
	       
		  
RETURN @@Identity
               **/
        public Int32 InsertObservation(clsObservation NewObservation)
        {
            // no need inserting the primary key as it is auto generated by the database when the form displays it -1
            // Add the paramters to the query for inserting the new patient properties into the DB
            MyDatabase.AddParameter("ObservationType", NewObservation.ObservationType);
            MyDatabase.AddParameter("PatientWeight", NewObservation.PatientWeight);
            MyDatabase.AddParameter("Height", NewObservation.Height);
            MyDatabase.AddParameter("Temperature", NewObservation.Temperature);
            MyDatabase.AddParameter("BloodPressure", NewObservation.BloodPressure);
            MyDatabase.AddParameter("Pulse", NewObservation.Pulse);
            MyDatabase.AddParameter("MRIScanImage", NewObservation.MRIScanImage);
            MyDatabase.AddParameter("DateTimeTaken", NewObservation.DateTimeTaken);
            MyDatabase.AddParameter("PhysicalStateNotes", NewObservation.PhysicalStateNotes);
            MyDatabase.AddParameter("MentalStateNotes", NewObservation.MentalStateNotes);

            //the two foreign keys to insert as well in an observation record are 
            MyDatabase.AddParameter("PatientID", NewObservation.PatientID);
            MyDatabase.AddParameter("StaffID", NewObservation.StaffID);

            //Execute the Insert procedure 
            // bearing in mind that it always returns the PK value @@Identity of any record so return needs to added in this function
            return MyDatabase.Execute("sproc_tblObservation_Insert");
        }


    }
}
