using Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using Sysstem.Text;

namespace ClassLibrary
{
    public class clsFoodPaymentCollection
    {
        //private data member for the list
        List<clsFoodPayment> foodPaymentList = new List<clsFoodPayment>();
        //private data member thisFoodPayment
        clsFoodPayment thisFoodPayment = new clsFoodPayment();

        //public property for the client list
        public List<clsFoodPayment> FoodPaymentList
        {

            get
            {
                //return the private data 
                return foodPaymentList;
            }

            set
            {
                //set the private data
                foodPaymentList = value;

            }

        }

        //public property for count
        public int Count
        {
            get

            {
                //return the count of the list 
                return foodPaymentList.Count;
            }
            set
            {

            }
        }

        //public property for this food payment
        public clsFoodPayment ThisFoodPayment
        {

            get
            {
                //return the private data
                return ThisFoodPayment;

            }

            set
            {
                //set the private data
                thisFoodPayment = value;
            }


        }

        //public constructor for the class
        public clsFoodPaymentCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblFoodPayment_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank foodpayment
                clsFoodPayment AFoodPayment = new clsFoodPayment();
                //read in the fields from the current record
                AFoodPayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                AFoodPayment.CardNumber = Convert.ToString(DB.DataTable.Rows[Index]["CardNumber"]);
                AFoodPayment.CardVerificationCode = Convert.ToString(DB.DataTable.Rows[Index]["CardVerificationCode"]);
                AFoodPayment.AccountNumber = Convert.ToString(DB.DataTable.Rows[Index]["AccountNumber"]);
                AFoodPayment.NameOnCard = Convert.ToString(DB.DataTable.Rows[Index]["NameOnCard"]);
                AFoodPayment.ExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ExpiryDate"]);
                AFoodPayment.SortCode = Convert.ToString(DB.DataTable.Rows[Index]["SortCode"]);
                AFoodPayment.StaffID = Convert.ToString(DB.DataTable.Rows[Index]["StaffID"]);

                //add the record to the private data member
                foodPaymentList.Add(AFoodPayment);
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
            DB.AddParameter("@PaymentID", thisFoodPayment.PaymentID);
            DB.AddParameter("@CardNumber", thisFoodPayment.CardNumber);
            DB.AddParameter("@CardVerificationCode", thisFoodPayment.CardVerificationCode);
            DB.AddParameter("@AccountNumber", thisFoodPayment.AccountNumber);
            DB.AddParameter("@NameOnCard", thisFoodPayment.NameOnCard);
            DB.AddParameter("@ExpiryDate", thisFoodPayment.ExpiryDate);
            DB.AddParameter("@SortCode", thisFoodPayment.SortCode);
            DB.AddParameter("@StaffID", thisFoodPayment.StaffID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblFoodPayment_InsertFoodPayment");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisFoodPayment
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FoodID", thisFoodPayment.PaymentID);
            //execute the stored procedure
            DB.Execute("sproc_tblFoodPayment_DeleteFoodPayment");
        }

        public void Update()
        {
            {
                //update an existing record based on the values of thisfoodpayment
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@PaymentID", thisFoodPayment.PaymentID);
                DB.AddParameter("@CardNumber", thisFoodPayment.CardNumber);
                DB.AddParameter("@CardVerificationCode", thisFoodPayment.CardVerificationCode);
                DB.AddParameter("@AccountNumber", thisFoodPayment.AccountNumber);
                DB.AddParameter("@NameOnCard", thisFoodPayment.NameOnCard);
                DB.AddParameter("@ExpiryDate", thisFoodPayment.ExpiryDate);
                DB.AddParameter("@SortCode", thisFoodPayment.SortCode);
                DB.AddParameter("@StaffID", thisFoodPayment.StaffID);
                //execute the query returning the primary key value
                DB.Execute("sproc_tblFoodPayment_UpdateFoodPayment");
            }
        }
    }
}