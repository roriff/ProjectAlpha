using System;
namespace ClassLibrary
{
    public class clsFoodPayment
    {
        //private data member for the FoodID property
        private Int32 paymentID;
        //private data member for the FoodName property
        private string accountNumber;
        //private data member for the FoodPrice property
        private string cardNumber;
        //private data member for the Quantity property
        private string cardVerificationCode;
        //private data member for the Quantity property
        private string expiryDate;
        //private data member for the Quantity property
        private string nameOnCard;
        //private data member for the Quantity property
        private string sortCode;
        //private data member for the Quantity property
        private string staffID;

        public string AccountNumber
        {

            get
            {
                //return the private data
                return accountNumber;
            }
            set
            {
                //set the value of the private data member
                accountNumber = value;
            }
        }
        public string CardNumber
        {

            get
            {
                //return the private data
                return cardNumber;
            }
            set
            {
                //set the value of the private data member
                cardNumber = value;
            }
        }
        public string CardVerificationCode
        {

            get
            {
                //return the private data
                return cardVerificationCode;
            }
            set
            {
                //set the value of the private data member
                cardVerificationCode = value;
            }
        }
        public string ExpiryDate
        {

            get
            {
                //return the private data
                return expiryDate;
            }
            set
            {
                //set the value of the private data member
                expiryDate = value;
            }
        }
        public int PaymentID
        {

            get
            {
                //return the private data
                return paymentID;
            }
            set
            {
                //set the value of the private data member
                paymentID = value;
            }
        }
        public string NameOnCard
        {

            get
            {
                //return the private data
                return nameOnCard;
            }
            set
            {
                //set the value of the private data member
                nameOnCard = value;
            }
        }
        public string SortCode
        {

            get
            {
                //return the private data
                return sortCode;
            }
            set
            {
                //set the value of the private data member
                sortCode = value;
            }
        }
        public string StaffID
        {

            get
            {
                //return the private data
                return staffID;
            }
            set
            {
                //set the value of the private data member
                staffID = value;
            }
        }

        public bool Valid(string SomeFoodPayment)
        {
            //if the name of the food payment is not blank
            if (SomeFoodPayment != "")
            {
                //return true
                return true;
            }
            //otherwise return false
            else
            {
                //return false
                return false;
            }

        }
    }
}