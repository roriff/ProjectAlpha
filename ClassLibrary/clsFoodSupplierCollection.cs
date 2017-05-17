using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsFoodSupplierCollection
    {
        //private data member for the list
        List<clsFoodSupplier> foodSupplierList = new List<clsFoodSupplier>();
        //private data member thisFoodPayment
        clsFoodSupplier thisFoodSupplier = new clsFoodSupplier();

        //public property for the client list
        public List<clsFoodSupplier> FoodSupplierList
        {

            get
            {
                //return the private data 
                return foodSupplierList;
            }

            set
            {
                //set the private data
                foodSupplierList = value;

            }

        }

        //public property for count
        public int Count
        {
            get

            {
                //return the count of the list 
                return foodSupplierList.Count;
            }
            set
            {

            }
        }

        //public property for this food payment
        public clsFoodSupplier ThisFoodSupplier
        {

            get
            {
                //return the private data
                return ThisFoodSupplier;

            }

            set
            {
                //set the private data
                ThisFoodSupplier = value;
            }


        }

        //public constructor for the class
        public clsFoodSupplierCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblFoodSupplier_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank foodpayment
                clsFoodSupplier AFoodSupplier = new clsFoodSupplier();
                //read in the fields from the current record
                AFoodSupplier.FoodSupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["FoodSupplierID"]);
                AFoodSupplier.FoodSupplierName = Convert.ToString(DB.DataTable.Rows[Index]["FoodSupplierName"]);
                AFoodSupplier.FoodSupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["FoodSupplierAddress"]);
                AFoodSupplier.FoodSupplierPostCode = Convert.ToString(DB.DataTable.Rows[Index]["FoodSupplierPostCode"]);
                AFoodSupplier.FoodSupplierCity = Convert.ToString(DB.DataTable.Rows[Index]["FoodSupplierCity"]);
                AFoodSupplier.FoodSupplierCounty = Convert.ToString(DB.DataTable.Rows[Index]["FoodSupplierCounty"]);
                AFoodSupplier.FoodSupplierRegion = Convert.ToString(DB.DataTable.Rows[Index]["FoodSupplierRegion"]);
                AFoodSupplier.FoodSupplierPhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["FoodSupplierPhoneNo"]);
                AFoodSupplier.FoodSupplierMobileNo = Convert.ToString(DB.DataTable.Rows[Index]["FoodSupplierMobileNo"]);
                AFoodSupplier.FoodSupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["FoodSupplierEmail"]);
                //add the record to the private data member
                foodSupplierList.Add(AFoodSupplier);
                //point at the next record
                Index++;
            }

        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisfoodPayment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FoodSupplierID", thisFoodSupplier.FoodSupplierID);
            DB.AddParameter("@FoodSupplierName", thisFoodSupplier.FoodSupplierName);
            DB.AddParameter("@FoodSupplierAddress", thisFoodSupplier.FoodSupplierAddress);
            DB.AddParameter("@FoodSupplierPostCode", thisFoodSupplier.FoodSupplierPostCode);
            DB.AddParameter("@FoodSupplierCity", thisFoodSupplier.FoodSupplierCity);
            DB.AddParameter("@FoodSupplierCounty", thisFoodSupplier.FoodSupplierCounty);
            DB.AddParameter("@FoodSupplierPhoneNo", thisFoodSupplier.FoodSupplierPhoneNo);
            DB.AddParameter("@FoodSupplierMobileNo", thisFoodSupplier.FoodSupplierMobileNo);
            DB.AddParameter("@FoodSupplierEmail", thisFoodSupplier.FoodSupplierEmail);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblFoodSupplier_InsertFoodSupplier");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisFoodSupplier
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FoodSupplierID", thisFoodSupplier.FoodSupplierID);
            //execute the stored procedure
            DB.Execute("sproc_tblFoodSupplier_DeleteFoodSupplier");
        }

        public void Update()
        {
            {
                //update an existing record based on the values of thisfoodsupplier
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@FoodSupplierID", thisFoodSupplier.FoodSupplierID);
                DB.AddParameter("@FoodSupplierName", thisFoodSupplier.FoodSupplierName);
                DB.AddParameter("@FoodSupplierAddress", thisFoodSupplier.FoodSupplierAddress);
                DB.AddParameter("@FoodSupplierPostCode", thisFoodSupplier.FoodSupplierPostCode);
                DB.AddParameter("@FoodSupplierCity", thisFoodSupplier.FoodSupplierCity);
                DB.AddParameter("@FoodSupplierCounty", thisFoodSupplier.FoodSupplierCounty);
                DB.AddParameter("@FoodSupplierPhoneNo", thisFoodSupplier.FoodSupplierPhoneNo);
                DB.AddParameter("@FoodSupplierMobileNo", thisFoodSupplier.FoodSupplierMobileNo);
                DB.AddParameter("@FoodSupplierEmail", thisFoodSupplier.FoodSupplierEmail);
                //execute the query returning the primary key value
                DB.Execute("sproc_tblFood_UpdateFoodSupplier");
            }
        }
    }
}