using System;

namespace ClassLibrary
{
    public class clsFoodPayment
    {
        public string FoodOrdering { get; set; }
        public string FoodPayment { get; set; }
        public string AccountNumber { get; set; }
        public string CardNumber { get; set; }
        public string CardVerificationCode { get; set; }
        public string ExpiryDate { get; set; }
        public int PaymentID { get; set; }
        public string NameOnCard { get; set; }
        public string SortCode { get; set; }
        public string StaffID { get; set; }

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