using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsFoodCollection
    {
        //private data member for the list
        List<clsFood> foodList = new List<clsFood>();
        //private data member thisCompany
        clsFood thisFood = new clsFood();

        //public property for the client list
        public List<clsFood> FoodList
        {

            get
            {
                //return the private data 
                return foodList;
            }

            set
            {
                //set the private data
                foodList = value;

            }

        }

        //public property for count
        public int Count
        {
            get

            {
                //return the count of the list 
                return foodList.Count;
            }
            set
            {

            }
        }

        //public property for this client
        public clsFood ThisFood
        {

            get
            {
                //return the private data
                return thisFood;

            }

            set
            {
                //set the private data
                thisFood = value;
            }


        }

        //public constructor for the class
        public clsFoodCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblFood_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsFood AFood = new clsFood();
                //read in the fields from the current record
                AFood.FoodID= Convert.ToInt32(DB.DataTable.Rows[Index]["FoodID"]);
                AFood.FoodName = Convert.ToString(DB.DataTable.Rows[Index]["FoodName"]);
                AFood.FoodPrice = Convert.ToString(DB.DataTable.Rows[Index]["FoodPrice"]);
                AFood.Quantity = Convert.ToString(DB.DataTable.Rows[Index]["Quantity"]);
                //add the record to the private data member
                foodList.Add(AFood);
                //point at the next record
                Index++;
            }

        }

        public int Add()
        {
            //adds a new record to the database based on the values of thisaddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FoodID", thisFood.FoodID);
            DB.AddParameter("@FoodName", thisFood.FoodName);
            DB.AddParameter("@FoodPrice", thisFood.FoodPrice);
            DB.AddParameter("@Quantity", thisFood.Quantity);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblFood_InsertFood");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCompany
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FoodID", thisFood.FoodID);
            //execute the stored procedure
            DB.Execute("sproc_tblFood_DeleteFood");
        }

        public void Update()
        {
            {
                //update an existing record based on the values of thisaddress
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@FoodID", thisFood.FoodID);
                DB.AddParameter("@FoodName", thisFood.FoodName);
                DB.AddParameter("@FoodPrice", thisFood.FoodPrice);
                DB.AddParameter("@Quantity", thisFood.Quantity);
                //execute the query returning the primary key value
                DB.Execute("sproc_tblFood_InsertFood");
            }
        }
    }
}