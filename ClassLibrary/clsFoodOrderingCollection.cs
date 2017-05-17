using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsFoodOrderingCollection
    {
        //private data member for the list
        List<clsFoodOrdering> foodOrderingList = new List<clsFoodOrdering>();
        //private data member thisCompany
        clsFoodOrdering thisFoodOrdering = new clsFoodOrdering();

        //public property for the client list
        public List<clsFoodOrdering> FoodOrderingList
        {

            get
            {
                //return the private data 
                return foodOrderingList;
            }

            set
            {
                //set the private data
                foodOrderingList = value;

            }

        }

        //public property for count
        public int Count
        {
            get

            {
                //return the count of the list 
                return foodOrderingList.Count;
            }
            set
            {

            }
        }

        //public property for this client
        public clsFoodOrdering ThisFoodOrdering
        {

            get
            {
                //return the private data
                return thisFoodOrdering;

            }

            set
            {
                //set the private data
                thisFoodOrdering = value;
            }


        }

        //public constructor for the class
        public clsFoodOrderingCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblFoodOrdering_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsFoodOrdering AFoodOrdering = new clsFoodOrdering();
                //read in the fields from the current record
                AFoodOrdering.FoodOrderingID = Convert.ToInt32(DB.DataTable.Rows[Index]["FoodOrderingID"]);
                AFoodOrdering.RestaurantID = Convert.ToInt32(DB.DataTable.Rows[Index]["RestaurantID"]);
                //add the record to the private data member
                foodOrderingList.Add(AFoodOrdering);
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
            DB.AddParameter("@FoodOrderingID", thisFoodOrdering.FoodOrderingID);
            DB.AddParameter("@RestaurantID", thisFoodOrdering.RestaurantID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblFoodOrdering_InsertFoodOrdering");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisFoodOrdering
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FoodOrderingID", thisFoodOrdering.FoodOrderingID);
            DB.AddParameter("@RestaurantID", thisFoodOrdering.RestaurantID);
            //execute the stored procedure
            DB.Execute("sproc_tblFoodOrdering_DeleteFoodOrdering");
        }

        public void Update()
        {
            {
                //update an existing record based on the values of thisaddress
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@FoodOrderingID", thisFoodOrdering.FoodOrderingID);
                DB.AddParameter("@RestaurantID", thisFoodOrdering.RestaurantID);
                //execute the query returning the primary key value
                DB.Execute("sproc_tblFoodOrdering_UpdateFoodOrdering");
            }
        }
    }
}